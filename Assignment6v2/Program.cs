namespace Assignment6v2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            IPersonDataSource db = new PersonListDataSource();
            MainForm mainForm = new MainForm(db);
            Application.Run(mainForm);
        }
    }
}