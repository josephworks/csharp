using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("a");
            treeView1.Nodes.Add("b");
            treeView1.Nodes.Add("c");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListViewItem i = listView1.Items.Add("a");
            i.SubItems.Add("i");
            i.ImageIndex = 1;
            listView1.Items.Add("b").SubItems.Add("2");
            listView1.Items.Add("c").SubItems.Add("3");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory("c:\\");
            foreach (string d in Directory.GetDirectories("c:\\"))
            {
                treeView1.Nodes.Add(d);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listView1.Items.Clear();
            Directory.SetCurrentDirectory(treeView1.SelectedNode.Text);
            foreach (string f in Directory.GetFiles(Directory.GetCurrentDirectory()))
            {
                listView1.Items.Add(f);
            }
        }
    }
}
