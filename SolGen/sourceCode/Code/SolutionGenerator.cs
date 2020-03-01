#region Copyright MIT License
/*
 * Copyright © 2008 François St-Arnaud and John Wood
 * 
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 * 
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * SolGen, Visual Studio Solution Generator for C# Projects (http://codeproject.com/SolGen)
 * Based on original work by John Wood developer of Priorganizer (http://www.priorganizer.com)
 * Adapted for Visual Studio 2005 by François St-Arnaud (francois.starnaud@videotron.ca)
 * Published to CodePlex with original author's permission.
 * 
 * Original software copyright notice:
 * © Copyright 2005 J. Wood Software Services. All rights reserved.
 * You are free to modify this source code at will, but please give credit to John Wood
 * if decide to incorporate or redistribute the resultant binary.
 * http://www.servicestuff.com/jwss/page.aspx?page=utility.htm&utility=solgen
 * 
 */
#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Reflection;

using Microsoft.Build.BuildEngine;

namespace SolGen
{
    class SolutionGenerator
    {

        #region Constants
        private const string ProjectRefs = ".projRefs";
        private const string AssemblyRefs = ".dllRefs";
        private const string CSProjFileExtension = ".csproj";
        private const string SolutionFileExtension = ".sln";
        private const string AllProjectsSolutionFileName = "all";
        private const string AssemblyName = "AssemblyName";
        private const string ProjectGuid = "ProjectGuid";
        private const string AllCSProj = "*" + CSProjFileExtension;
        private const string AllFiles = "*.*";
        private const string AllDLLs = "*.dll";
        private const string AllSLNs = "*.sln";
        private const string Reference = "Reference";
        private const string ProjectReference = "ProjectReference";
        private const string Project = "Project";
        private const string Obj = @"\obj\";

        // From Computer\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\8.0\Projects\
        private const string CSProjGUID = "{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}";
        private const string FolderGUID = "{2150E333-8FDC-42A3-9474-1A3956D46DE8}";
        
        #endregion

        #region Enums
        private enum RefTypes
        {
            Assembly,
            Project,
            Both
        }

        private enum SolutionTypes
        {
            Flat,
            Deep
        }
        #endregion

        #region Members
        private readonly IDictionary<string, ProjectInfo> m_ProjectsByName = new Dictionary<string, ProjectInfo>();
        private readonly IDictionary<string, ProjectInfo> m_ProjectsByFile = new Dictionary<string, ProjectInfo>();
        private readonly IDictionary<string, ProjectInfo> m_ProjectsByGuid = new Dictionary<string, ProjectInfo>();
        private readonly IDictionary<string, ProjectInfo> m_FoldersByPath  = new Dictionary<string, ProjectInfo>();
        private readonly IList<ProjectInfo> m_AssemblyRefProjectFilesHandled = new List<ProjectInfo>();
        private readonly IList<ProjectInfo> m_ProjectRefProjectFilesHandled = new List<ProjectInfo>();
        private readonly IList<string> m_ProjectFiles = new List<string>();
        private readonly Engine m_Engine = new Engine();

        private Arguments m_Arguments = new Arguments();

        #endregion

        #region Private sub-classes

        /// <summary>
        /// Represents a project reference or loaded project.
        /// </summary>
        private class ProjectInfo
        {
            public string ProjectName = null;
            public string ProjectGuid = null;
            public string Filename = null;
            public string AssemblyName = null;
            public string FolderGuid = null;

            // list of assemblynames
            public List<string> References = new List<string>();

            public Project MSBuildProject;

            public ProjectInfo ShallowCopy()
            {
                return (ProjectInfo)this.MemberwiseClone();
            }
        }

        /// <summary>
        /// Represents command-line arguments.
        /// </summary>
        private class Arguments
        {
            public List<string> ProbeFolders = null;
            public RefTypes Refs = RefTypes.Both;
            public string HintPath = null;
            public string RootFolder = null;
            public List<string> Ignore = null;
            public bool Overwrite = false;
            public SolutionTypes Solution = SolutionTypes.Flat;
        }
        #endregion

        #region Private methods

        #region Command-line arguments handling
        private static void Header()
        {
            Console.WriteLine("SolGen: C# Solution Generator, Version " + Assembly.GetExecutingAssembly().GetName().Version);
            Console.WriteLine("Copyright © 2008 François St-Arnaud and John Wood under MIT License.");
            Console.WriteLine("For more information, see http://codeplex.com/SolGen");
        }

        private static void Usage()
        {
            Console.WriteLine("\nSolGen scans the specified root folder and subfolders looking for");
            Console.WriteLine("C# project files (.csproj). For each project file found, it creates up to 4 files:\n");
            Console.WriteLine("If /refs is set to 'project' or 'both':");
            Console.WriteLine("1) a .projRefs.csproj file which contains project references");
            Console.WriteLine("2) a .projRefs.sln file that contains the current project and all referenced projects\n");
            Console.WriteLine("If /refs is set to 'assembly' or 'both':");
            Console.WriteLine("3) a .dllRefs.csproj file that contains assembly references");
            Console.WriteLine("4) a .dllRefs.sln file that contains only .dllRefs.csproj\n");
            Console.WriteLine("Also, SolGen creates top-level solution files for each subfolder of the specified root");
            Console.WriteLine("until a .csproj file is found. A top-level solution file is a .projRefs.sln file that");
            Console.WriteLine("contains all created .projRefs.csproj files below the root folder.\n");
            Console.WriteLine("Usage: solgen [switches]");
            Console.WriteLine(" /root:folder, the root folder where to start looking for projects");
            Console.WriteLine("</refs:[assembly|project|both]>, optional, default: 'both'");
            Console.WriteLine("</ignore:folder,(...)>, optional, the list of sub-folders to ignore (e.g.: .svn)");
            Console.WriteLine("</probe:folder,(...)>, optional, additional folders where to look for referenced projects\n");
            Console.WriteLine("</overwrite>, optional, when 'refs' is 'assembly' or 'project', overwrite existing files\n");
            Console.WriteLine("</solution:[flat|deep]>, optional, organize projects in folder structure, default: 'flat'\n");
        }

        private static void GetArg(string line, string prefix, ref string output)
        {
            if (line.ToUpper().StartsWith(prefix.ToUpper()))
            {
                output = line.Substring(prefix.Length);
            }
        }

        private static bool ParseArguments(string[] args, out Arguments arguments)
        {
            string probe = null;
            string refs = null;
            string ignore = null;
            string overwrite = null;
            string solution = null;

            arguments = new Arguments();

            if (args.Length == 0)
            {
                Usage();
                return false;
            }

            foreach (string str in args)
            {
                GetArg(str, "/probe:", ref probe);
                GetArg(str, "/hintpath:", ref arguments.HintPath);
                GetArg(str, "/root:", ref arguments.RootFolder);
                GetArg(str, "/ignore:", ref ignore);
                GetArg(str, "/refs:", ref refs);
                GetArg(str, "/overwrite", ref overwrite);
                GetArg(str, "/solution:", ref solution);
            }

            if (arguments.RootFolder == null)
            {
                Usage();
                return false;
            }

            if (!Directory.Exists(arguments.RootFolder))
            {
                Console.WriteLine("\nSpecified root folder does not exists.");
                Console.WriteLine(arguments.RootFolder);
                return false;
            }

            arguments.RootFolder = Path.GetFullPath(arguments.RootFolder);

            if (ignore != null)
            {
                string[] ignores = ignore.Split(new char[] { ';', ',' });
                arguments.Ignore = new List<string>(Array.ConvertAll(ignores, element => Path.GetFullPath(element)));
            }

            if (overwrite != null)
            {
                if (overwrite != String.Empty)
                {
                    Console.WriteLine("\nOverwrite argument is binary.");
                    return false;
                }
                arguments.Overwrite = true;
            }

            if (solution != null)
            {
                switch (solution.ToLower())
                {
                    case "flat":
                        arguments.Solution = SolutionTypes.Flat;
                        break;
                    case "deep":
                        arguments.Solution = SolutionTypes.Deep;
                        break;
                    default:
                        Console.WriteLine("\nUnknown /solution switch value " + solution + "!.");
                        return false;
                }
            }

            if (probe != null)
            {
                string[] probes = probe.Split(new char[] { ';', ',' });
                arguments.ProbeFolders = new List<string>(probes);
                foreach (string probeFolder in arguments.ProbeFolders)
                {
                    if (!Directory.Exists(probeFolder))
                    {
                        Console.WriteLine("\nSpecified probe folder does not exists.");
                        Console.WriteLine(probeFolder);
                        return false;
                    }
                }
            }
            else
            {
                arguments.ProbeFolders = new List<string>();
            }
            arguments.ProbeFolders.Add(arguments.RootFolder);

            if (refs != null)
            {
                switch (refs.ToLower())
                {
                    case "assembly":
                        arguments.Refs = RefTypes.Assembly;
                        break;
                    case "project":
                        arguments.Refs = RefTypes.Project;
                        break;
                    case "both":
                        arguments.Refs = RefTypes.Both;
                        break;
                    default:
                        Console.WriteLine("\nUnknown /refs switch value " + refs + "!.");
                        return false;
                }
            }

            if (arguments.HintPath == null)
            {
                arguments.HintPath = string.Empty;
            }

            return true;
        }

        #endregion

        #region Utility methods

        private static string GetAssemblyNameFromFullyQualifiedName(string fullyQualifiedName)
        {
            string assemblyName = fullyQualifiedName;
            if (assemblyName.IndexOf(",") != -1)
            {
                assemblyName = assemblyName.Remove(assemblyName.IndexOf(","));
            }
            return assemblyName;
        }

        private static string GetRelativePath(string fromPath, string toPath)
        {
            string[] fromDirectories = fromPath.Split(Path.DirectorySeparatorChar);
            string[] toDirectories = toPath.Split(Path.DirectorySeparatorChar);

            // Get the shortest of the two paths
            int length = fromDirectories.Length < toDirectories.Length
                             ? fromDirectories.Length
                             : toDirectories.Length;

            int lastCommonRoot = -1;
            int index;

            // Find common root
            for (index = 0; index < length; index++)
            {
                if (fromDirectories[index].Equals(toDirectories[index], StringComparison.InvariantCultureIgnoreCase))
                {
                    lastCommonRoot = index;
                }
                else
                {
                    break;
                }
            }

            // If we didn't find a common prefix then abandon
            if (lastCommonRoot == -1)
            {
                return null;
            }

            // Add the required number of "..\" to move up to common root level
            StringBuilder relativePath = new StringBuilder();
            for (index = lastCommonRoot + 1; index < fromDirectories.Length; index++)
            {
                relativePath.Append(".." + Path.DirectorySeparatorChar);
            }

            // Add on the folders to reach the destination
            for (index = lastCommonRoot + 1; index < toDirectories.Length - 1; index++)
            {
                relativePath.Append(toDirectories[index] + Path.DirectorySeparatorChar);
            }
            relativePath.Append(toDirectories[toDirectories.Length - 1]);

            return relativePath.ToString();
        }

        private static bool IsInIgnoreList(string folder, IEnumerable<string> ignoreList)
        {
            bool ret = false;
            if (folder != null && ignoreList != null)
            {
                foreach (string ignore in ignoreList)
                {
                    if (folder.StartsWith(ignore, StringComparison.InvariantCultureIgnoreCase))
                    {
                        ret = true;
                        break;
                    }
                }
            }
            return ret;
        }

        #endregion

        #region Project and DLL probing and reference handling methods

        /// <summary>
        /// Extracts information from a project file
        /// </summary>
        private void ProcessProject(string folder, string file)
        {
            // ignore projects that *we* created...
            if ((file.EndsWith(ProjectRefs + CSProjFileExtension)) ||
                (file.EndsWith(AssemblyRefs + CSProjFileExtension)))
            {
                return;
            }

            m_ProjectFiles.Add(file);

            string qualifiedFile = Path.Combine(folder, file);
            Project project = new Project(m_Engine);
            project.Load(qualifiedFile);

            ProjectInfo pinfo = new ProjectInfo();
            pinfo.MSBuildProject = project;
            pinfo.ProjectName = Path.GetFileNameWithoutExtension(file);
            pinfo.Filename = qualifiedFile;

            foreach (BuildPropertyGroup buildPropertyGroup in project.PropertyGroups)
            {
                foreach (BuildProperty buildProperty in buildPropertyGroup)
                {
                    if (buildProperty.Name == AssemblyName)
                    {
                        pinfo.AssemblyName = buildProperty.Value;
                    }
                    else if (buildProperty.Name == ProjectGuid)
                    {
                        pinfo.ProjectGuid = buildProperty.Value;
                    }
                }

                if ((pinfo.AssemblyName != null) && (pinfo.ProjectGuid != null))
                {
                    break;
                }
            }

            Debug.Assert(pinfo.AssemblyName != null);
            Debug.Assert(pinfo.ProjectGuid != null);

            if (m_ProjectsByName.ContainsKey(pinfo.AssemblyName.ToUpper()))
            {
                ProjectInfo existing = m_ProjectsByName[pinfo.AssemblyName.ToUpper()];

                Console.WriteLine("\nThe project " + pinfo.ProjectName);
                Console.WriteLine("With assembly name " + pinfo.AssemblyName);
                Console.WriteLine("Is defined in more than one project file; using:");
                Console.WriteLine(existing.Filename);
            }
            else
            {
                m_ProjectsByName.Add(pinfo.AssemblyName.ToUpper(), pinfo);
            }

            // only record the project if it's not already there
            if (!m_ProjectsByFile.ContainsKey(pinfo.Filename.ToUpper()))
            {
                m_ProjectsByFile.Add(pinfo.Filename.ToUpper(), pinfo);
            }

            // keep a record of the project keyed by its GUID
            if (!m_ProjectsByGuid.ContainsKey(pinfo.ProjectGuid))
            {
                m_ProjectsByGuid.Add(pinfo.ProjectGuid, pinfo);
            }
            else
            {
                Console.WriteLine("\nProjects with same GUID found ! " + pinfo.ProjectGuid);
                Console.WriteLine(pinfo.Filename);
                Console.WriteLine(m_ProjectsByGuid[pinfo.ProjectGuid].Filename);
            }

        }

        /// <summary>
        /// Locates all projects under the given folder
        /// </summary>
        private void FindAllProjects(string folder)
        {
            foreach (string file in Directory.GetFiles(folder, AllCSProj))
            {
                ProcessProject(folder, file);
            }

            foreach (string subFolder in Directory.GetDirectories(folder, AllFiles))
            {
                if (IsInIgnoreList(subFolder, m_Arguments.Ignore))
                {
                    continue;
                }
                string newFolder = Path.Combine(folder, subFolder);
                FindAllProjects(newFolder);
            }
        }

        /// <summary>
        /// Retrieves the information on references in the project
        /// </summary>
        private void GatherProjectReferences()
        {
            foreach (ProjectInfo projectInfo in m_ProjectsByName.Values)
            {
                Debug.Assert(projectInfo.MSBuildProject != null);

                foreach (BuildItemGroup buildItemGroup in projectInfo.MSBuildProject.ItemGroups)
                {
                    foreach (BuildItem buildItem in buildItemGroup)
                    {
                        // Add assembly references
                        if (buildItem.Name == Reference)
                        {
                            projectInfo.References.Add(GetAssemblyNameFromFullyQualifiedName(buildItem.Include));
                        }
                        // Add project references
                        else if (buildItem.Name == ProjectReference)
                        {
                            projectInfo.References.Add(buildItem.GetMetadata(Project));
                        }
                    }
                }
            }
        }

        private void CollectRelatedProjects(string projectFile, IDictionary<string, ProjectInfo> projects)
        {
            string upperCaseProjectFile = projectFile.ToUpper();
            Debug.Assert(m_ProjectsByFile.ContainsKey(upperCaseProjectFile));

            ProjectInfo pinfo = m_ProjectsByFile[upperCaseProjectFile];

            if (!projects.ContainsKey(pinfo.AssemblyName))
            {
                projects.Add(pinfo.AssemblyName, pinfo);
            }

            foreach (string assembly in pinfo.References)
            {
                ProjectInfo reference;
                m_ProjectsByName.TryGetValue(assembly.ToUpper(), out reference);
                if (reference != null)
                {
                    CollectRelatedProjects(reference.Filename, projects);
                }
            }
        }

        private void ResolveProjectGuids()
        {
            foreach (ProjectInfo pinfo in m_ProjectsByName.Values)
            {
                List<string> newReferences = new List<string>();
                foreach (string reference in pinfo.References)
                {
                    string newReference = reference;
                    if (reference.StartsWith("{"))
                    {
                        // must be a GUID...
                        if (m_ProjectsByGuid.ContainsKey(reference))
                        {
                            newReference = m_ProjectsByGuid[reference].AssemblyName;
                        }
                        else
                        {
                            Console.WriteLine("\nReferenced GUID not found !");
                            Console.WriteLine(reference);
                            Console.WriteLine(pinfo.Filename);
                        }
                    }
                    newReferences.Add(newReference);
                }
                pinfo.References = newReferences;
            }
        }

        private void SetFolderParents()
        {
            int rootIndex = m_Arguments.RootFolder.Length + 1;
            foreach (ProjectInfo projectInfo in m_ProjectsByFile.Values)
            {
                // TODO Substring unsafe; assumes Filename.StartsWith(RootFolder)
                string projectPath = Path.GetDirectoryName(projectInfo.Filename).Substring(rootIndex);
                string[] projParts = projectPath.Split(Path.DirectorySeparatorChar);
                StringBuilder sb = new StringBuilder(m_Arguments.RootFolder);
                ProjectInfo parent = null;
                for (int projIndex = 0; projIndex < projParts.Length; projIndex++)
                {
                    string folderName = projParts[projIndex];
                    ProjectInfo folderInfo = null;
                    sb.Append(Path.DirectorySeparatorChar);
                    sb.Append(folderName);
                    m_FoldersByPath.TryGetValue(sb.ToString(), out folderInfo);
                    if (folderInfo == null)
                    {
                        folderInfo = new ProjectInfo();
                        folderInfo.ProjectGuid = "{" + Guid.NewGuid().ToString().ToUpper() + "}";
                        folderInfo.ProjectName = folderName;
                        folderInfo.Filename = folderName;
                        if (parent != null)
                        {
                            folderInfo.FolderGuid = parent.ProjectGuid;
                        }
                        m_FoldersByPath.Add(sb.ToString(), folderInfo);
                    }
                    parent = folderInfo;
                }
            }
        }

        #endregion

        #region Project file creation methods

        private void CreateProjectReferenceProjectFile(IDictionary<string, ProjectInfo> projects)
        {
            foreach (ProjectInfo projectInfo in projects.Values)
            {
                if (m_ProjectRefProjectFilesHandled.Contains(projectInfo))
                {
                    continue;
                }
                Debug.Assert(projectInfo.MSBuildProject != null);

                List<BuildItem> assemblyReferencesToMove = new List<BuildItem>();
                BuildItemGroup assemblyReferencesBuildItemGroup = null;
                BuildItemGroup projectReferencesBuildItemGroup = null;

                foreach (BuildItemGroup buildItemGroup in projectInfo.MSBuildProject.ItemGroups)
                {
                    foreach (BuildItem buildItem in buildItemGroup)
                    {
                        // Find all assembly references to convert to project references
                        if (buildItem.Name == Reference)
                        {
                            // Keep a bookmark on the BuildItemGroup that holds assembly references
                            assemblyReferencesBuildItemGroup = buildItemGroup;

                            // Take a look at all assembly references to identify those to convert to project references
                            ProjectInfo referencedProjectInfo;
                            string projectName = GetAssemblyNameFromFullyQualifiedName(buildItem.Include);
                            projects.TryGetValue(projectName, out referencedProjectInfo);
                            if (referencedProjectInfo != null)
                            {
                                assemblyReferencesToMove.Add(buildItem);
                            }
                        }

                        if (buildItem.Name == ProjectReference)
                        {
                            // Keep a bookmark on the BuildItemGroup that holds project references
                            projectReferencesBuildItemGroup = buildItemGroup;
                        }
                    }
                }

                // If no assembly references found or none to move, nothing to change; save file as-is
                if (assemblyReferencesBuildItemGroup == null || assemblyReferencesToMove.Count == 0)
                {
                    //Console.WriteLine("Nothing to do.");
                }
                else
                {
                    // If no project reference group exists, create one.
                    if (projectReferencesBuildItemGroup == null)
                    {
                        projectReferencesBuildItemGroup = projectInfo.MSBuildProject.AddNewItemGroup();
                    }

                    // Remove assembly reference and replace by corresponding project reference.
                    foreach (BuildItem buildItem in assemblyReferencesToMove)
                    {
                        assemblyReferencesBuildItemGroup.RemoveItem(buildItem);
                        string replacementAssemblyName = GetAssemblyNameFromFullyQualifiedName(buildItem.Include);
                        var replacementProjectInfo = m_ProjectsByName[replacementAssemblyName.ToUpperInvariant()];
                        string remplacementInclude = GetRelativePath(Path.GetDirectoryName(projectInfo.Filename), replacementProjectInfo.Filename);
                        BuildItem newBuildItem = projectReferencesBuildItemGroup.AddNewItem(ProjectReference, remplacementInclude);
                        newBuildItem.SetMetadata("Project", replacementProjectInfo.ProjectGuid);
                        newBuildItem.SetMetadata("Name", replacementProjectInfo.ProjectName);
                        newBuildItem.SetMetadata("Private", bool.FalseString);
                    }
                }

                StringBuilder sb = new StringBuilder(Path.ChangeExtension(projectInfo.Filename, null));
                if (m_Arguments.Overwrite == false)
                {
                    sb.Append(ProjectRefs);
                }
                sb.Append(CSProjFileExtension);
                string projectFileName = sb.ToString();
                projectInfo.MSBuildProject.Save(projectFileName);
                m_ProjectRefProjectFilesHandled.Add(projectInfo);
            }
        }

        private void CreateAssemblyReferenceProjectFile(IDictionary<string, ProjectInfo> projects)
        {
            foreach (ProjectInfo projectInfo in projects.Values)
            {
                if (m_AssemblyRefProjectFilesHandled.Contains(projectInfo))
                {
                    continue;
                }

                Debug.Assert(projectInfo.MSBuildProject != null);

                List<BuildItem> projectReferencesToMove = new List<BuildItem>();
                BuildItemGroup assemblyReferencesBuildItemGroup = null;
                BuildItemGroup projectReferencesBuildItemGroup = null;

                foreach (BuildItemGroup buildItemGroup in projectInfo.MSBuildProject.ItemGroups)
                {
                    foreach (BuildItem buildItem in buildItemGroup)
                    {
                        if (buildItem.Name == Reference)
                        {
                            // Keep a bookmark on the BuildItemGroup that holds assembly references
                            assemblyReferencesBuildItemGroup = buildItemGroup;
                        }

                        if (buildItem.Name == ProjectReference)
                        {
                            // Keep a bookmark on the BuildItemGroup that holds project references
                            projectReferencesBuildItemGroup = buildItemGroup;

                            // Take a look at all project references to identify those to convert to assembly references
                            ProjectInfo referencedProjectInfo;
                            string projectGuid = buildItem.GetMetadata(Project);
                            m_ProjectsByGuid.TryGetValue(projectGuid, out referencedProjectInfo);
                            if (referencedProjectInfo != null)
                            {
                                projectReferencesToMove.Add(buildItem);
                            }
                        }
                    }
                }

                // If no project references found or none to move, nothing to change; save file as-is
                if (projectReferencesBuildItemGroup == null || projectReferencesToMove.Count == 0)
                {
                    //Console.WriteLine("Nothing to do.");
                }
                else
                {
                    if (assemblyReferencesBuildItemGroup == null)
                    {
                        assemblyReferencesBuildItemGroup = projectInfo.MSBuildProject.AddNewItemGroup();
                    }

                    foreach (BuildItem buildItem in projectReferencesToMove)
                    {
                        projectReferencesBuildItemGroup.RemoveItem(buildItem);

                        // Get the assembly name corresponding to the project GUID 
                        foreach (ProjectInfo pinfo in projects.Values)
                        {
                            if (pinfo.ProjectGuid == buildItem.GetMetadata(Project))
                            {
                                BuildItem newBuildItem =
                                    assemblyReferencesBuildItemGroup.AddNewItem(Reference, pinfo.AssemblyName);
                                newBuildItem.SetMetadata("Private", bool.FalseString);
                                newBuildItem.SetMetadata("SpecificVersion", bool.FalseString);
                                if (m_Arguments.HintPath != string.Empty)
                                {
                                    string relative =
                                        GetRelativePath(Path.GetDirectoryName(projectInfo.Filename), m_Arguments.HintPath);
                                    newBuildItem.SetMetadata("HintPath", Path.Combine(relative, pinfo.AssemblyName) + ".dll");
                                }
                                break;
                            }
                        }
                    }
                }
                StringBuilder sb = new StringBuilder(Path.ChangeExtension(projectInfo.Filename, null));
                if (m_Arguments.Overwrite == false)
                {
                    sb.Append(AssemblyRefs);
                }
                sb.Append(CSProjFileExtension);
                string projectFileName = sb.ToString();
                projectInfo.MSBuildProject.Save(projectFileName);
                m_AssemblyRefProjectFilesHandled.Add(projectInfo);
            }
        }

        /// <summary>
        /// Generates a new project file containing only references to project GUIDs
        /// </summary>
        private void CreateProjectFiles(IDictionary<string, ProjectInfo> projects)
        {
            if (m_Arguments.Refs == RefTypes.Project || m_Arguments.Refs == RefTypes.Both)
            {
                CreateProjectReferenceProjectFile(projects);
            }

            if (m_Arguments.Refs == RefTypes.Assembly || m_Arguments.Refs == RefTypes.Both)
            {
                CreateAssemblyReferenceProjectFile(projects);
            }
        }

        #endregion

        #region Solution file creation methods

        private void WriteSolutionFile(string solutionFile, IDictionary<string, ProjectInfo> projects, RefTypes refType)
        {
            Debug.Assert(solutionFile != null);

            StreamWriter writer = new StreamWriter(solutionFile);

            writer.WriteLine("Microsoft Visual Studio Solution File, Format Version 11.00");
            writer.WriteLine("# Visual Studio 2010");

            // Folders
            if (m_Arguments.Solution == SolutionTypes.Deep)
            {
                foreach (KeyValuePair<string, ProjectInfo> kvp in m_FoldersByPath)
                {
                    if (kvp.Key.StartsWith(Path.GetDirectoryName(solutionFile) + Path.DirectorySeparatorChar))
                    {
                        WriteProjectEntry(writer, kvp.Value, true, Path.GetDirectoryName(solutionFile)); 
                    }
                }
            }

            // Projects
            foreach (ProjectInfo projectInfo in projects.Values)
            {
                StringBuilder sb = new StringBuilder(Path.Combine(Path.GetDirectoryName(projectInfo.Filename), Path.GetFileNameWithoutExtension(projectInfo.Filename)));

                if (m_Arguments.Overwrite == false)
                {
                    if (refType == RefTypes.Project)
                    {
                        sb.Append(ProjectRefs);
                    }
                    else if (refType == RefTypes.Assembly)
                    {
                        sb.Append(AssemblyRefs);
                    }
                }
                sb.Append(CSProjFileExtension);

                // Create a copy of the project information to avoid modifying the project information in the reference
                // m_ProjectsByName, m_ProjectsByFile, m_ProjectsByGuid data structures.
                var projectInfoCopy = projectInfo.ShallowCopy();
                projectInfoCopy.Filename = sb.ToString();
                WriteProjectEntry(writer, projectInfoCopy, false, Path.GetDirectoryName(solutionFile)); 
            }

            // Project and folder relations
            if (m_Arguments.Solution == SolutionTypes.Deep)
            {
                writer.WriteLine("Global");
                writer.WriteLine("\tGlobalSection(NestedProjects) = preSolution");
                string format = "\t\t{0} = {1}";

                // Folder relations
                // TODO: improve; output only required folder relations
                foreach (ProjectInfo folderInfo in m_FoldersByPath.Values)
                {
                    if (folderInfo.ProjectGuid != null && folderInfo.FolderGuid != null)
                    {
                        writer.WriteLine(format, folderInfo.ProjectGuid, folderInfo.FolderGuid);
                    }
                }  
 
            // Project relations
                foreach (ProjectInfo projectInfo in projects.Values)
                {
                    ProjectInfo folderInfo = null;
                    m_FoldersByPath.TryGetValue(Path.GetDirectoryName(projectInfo.Filename), out folderInfo);
                    if (folderInfo != null)
                    {
                        writer.WriteLine(format, projectInfo.ProjectGuid, folderInfo.ProjectGuid);
                    }
                }

                writer.WriteLine("\tEndGlobalSection");
                writer.WriteLine("EndGlobal");
                writer.Close();
            }
        }

        private static void WriteProjectEntry(TextWriter writer, ProjectInfo projectInfo, bool folder, string rootFolder)
        {
            string projectPath = null;
            string guid = null;

            if (folder == false)
            {
                // TODO
                if (projectInfo.Filename.StartsWith(rootFolder))
                {
                projectPath = projectInfo.Filename.Substring(rootFolder.Length + 1);
                }
                else
                {
                    projectPath = projectInfo.Filename;
                }
                guid = CSProjGUID;
            }
            else
            {
                projectPath = projectInfo.ProjectName;
                guid = FolderGUID;
            }

            string format = "Project('{0}') = '{1}', '{2}', '{3}'".Replace('\'', '"');
            writer.WriteLine(format, guid, projectInfo.ProjectName, projectPath, projectInfo.ProjectGuid);
            writer.WriteLine("EndProject");
        }

        private void CreateSolutionFiles(string projectFile, IDictionary<string, ProjectInfo> projects)
        {
            Debug.Assert(projectFile != null);

            // Create single project solution file for project with assembly references
            Dictionary<string, ProjectInfo> singleProject = new Dictionary<string, ProjectInfo>();
            singleProject.Add(projectFile, m_ProjectsByFile[projectFile.ToUpper()]);

            StringBuilder sb = new StringBuilder(Path.Combine(Path.GetDirectoryName(projectFile), Path.GetFileNameWithoutExtension(projectFile)));
            if (m_Arguments.Overwrite == false)
            {
                sb.Append(AssemblyRefs);
            }
            sb.Append(SolutionFileExtension);
            string singleProjectSolutionFile = sb.ToString();

            WriteSolutionFile(singleProjectSolutionFile, singleProject, RefTypes.Assembly);

            // Create "complete" solution with all projects required to fulfill project references
            if (m_Arguments.Refs == RefTypes.Project || m_Arguments.Refs == RefTypes.Both)
            {
                string assemblyRefsSolutionFile = Path.Combine(Path.GetDirectoryName(projectFile), Path.GetFileNameWithoutExtension(projectFile)) + ProjectRefs + SolutionFileExtension;
                WriteSolutionFile(assemblyRefsSolutionFile, projects, RefTypes.Project);
            }
        }

        private void CreateTopLevelSolutionFiles(string folder, Dictionary<string, Dictionary<string, ProjectInfo>> allRelatedProjects)
        {
            Debug.Assert(folder != null && folder != string.Empty && Directory.Exists(folder));

            // No need to create a top-level solution file if root folder contains a .csproj file
            // No need to create a top-level solution file if root folder contains no subfolders
            if (Directory.GetFiles(folder, AllCSProj).Length > 0 || Directory.GetDirectories(folder).Length == 0)
            {
                return;
            }

            // Recursively process all sub-folders of root folder
            foreach (string subFolder in Directory.GetDirectories(folder, AllFiles))
            {
                // Ignore sub-folders in ignore list
                if (IsInIgnoreList(subFolder, m_Arguments.Ignore))
                {
                    continue;
                }

                // Ignore sub-folders that contain a project file
                if (Directory.GetFiles(subFolder, AllCSProj).Length > 0)
                {
                    continue;
                }

                CreateTopLevelSolutionFiles(subFolder, allRelatedProjects);
            }

            // Create a solution containing a list of all project files under this subfolder
            IDictionary<string, ProjectInfo> projects = new Dictionary<string, ProjectInfo>();
            foreach (KeyValuePair<string, ProjectInfo> kvp in m_ProjectsByFile)
            {
                if (kvp.Key.StartsWith(folder, StringComparison.InvariantCultureIgnoreCase) && !projects.ContainsKey(kvp.Key))
                {
                    projects.Add(kvp.Key, kvp.Value);
                    Dictionary<string, ProjectInfo> relatedProjects;
                    allRelatedProjects.TryGetValue(kvp.Value.Filename, out relatedProjects);
                    if (relatedProjects != null)
                    {
                        foreach (var kvp2 in relatedProjects)
                        {
                            var key = kvp2.Value.Filename.ToUpperInvariant();
                            if (!projects.ContainsKey(key))
                            {
                                projects.Add(key, kvp2.Value);
                            }
                        }
                    }
                }
            }
            if (projects.Count > 0)
            {
                StringBuilder sb = new StringBuilder(folder);
                string[] parts = folder.Split(Path.DirectorySeparatorChar);

                if (parts.Length > 1)
                {
                    sb.Append(Path.DirectorySeparatorChar);
                    sb.Append(parts[parts.Length - 2]);
                }

                sb.Append('.');
                sb.Append(parts[parts.Length - 1]);
  
                if (m_Arguments.Overwrite == false)
                {
                    sb.Append(ProjectRefs);
                }
                sb.Append(SolutionFileExtension);
                string solutionFileName = sb.ToString();

                WriteSolutionFile(solutionFileName, projects, RefTypes.Project);
            }
        }

        #endregion

        #endregion

        #region Start

        public void Start(string[] args)
        {
            Header();

            if (!ParseArguments(args, out m_Arguments))
            {
                return;
            }

            Console.WriteLine("\nProbing for projects...");

            // Find all projects under that specified folder
            foreach (string folder in m_Arguments.ProbeFolders)
            {
                FindAllProjects(folder);
            }

            // Retrieve project references for all loaded projects
            GatherProjectReferences();

            // Resolve any project GUIDs in the project references
            ResolveProjectGuids();

            // Assign GUIDs to all subfolders
            SetFolderParents();

            // For all project files found under the specified folder, create ProjectRefs.csproj and/or
            // AssemblyRefs.csproj file(s) that contain(s) project and/or assembly references.
            Console.WriteLine("\nCreating project and solution files under:");
            Console.WriteLine(m_Arguments.RootFolder + "...");

            // Keep track of the related projects for generating top-level solutions.
            Dictionary<string, Dictionary<string, ProjectInfo>> allRelatedProjects = new Dictionary<string, Dictionary<string, ProjectInfo>>();

            foreach (string projectFile in m_ProjectFiles)
            {
                string startFolder = Path.Combine(m_Arguments.RootFolder, " ").Trim().ToUpper();
                if (!projectFile.ToUpper().StartsWith(startFolder))
                {
                    continue;
                }

                Console.WriteLine(projectFile.Replace(m_Arguments.RootFolder, ""));

                // Find related projects
                Dictionary<string, ProjectInfo> projects = new Dictionary<string, ProjectInfo>();
                CollectRelatedProjects(projectFile, projects);
                allRelatedProjects.Add(projectFile, projects);

                // Create new project file(s)
                CreateProjectFiles(projects);

                // Create solution files
                CreateSolutionFiles(projectFile, projects); 
            }

            // Create top-level solution file
            Console.WriteLine("\nCreating top-level solution files...");
            CreateTopLevelSolutionFiles(m_Arguments.RootFolder, allRelatedProjects);

            Console.WriteLine("Done.");
        }

        #endregion
    }
}
