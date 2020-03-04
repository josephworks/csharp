using Wisej.Web;

namespace RuntimeLocalization
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static void Main()
        {
            //Application.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("fr");

            Application.MainPage = new Page1();
        }
    }
}