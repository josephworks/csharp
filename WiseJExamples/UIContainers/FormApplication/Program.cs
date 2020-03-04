namespace FormApplication
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static void Main()
        {
            PrimaryForm primaryForm = new PrimaryForm();
            primaryForm.Show();

            SecondaryForm secondaryForm = new SecondaryForm();
            secondaryForm.Show();
        }
    }
}