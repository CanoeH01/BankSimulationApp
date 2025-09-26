namespace Applications_Dev_Project
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
            ApplicationConfiguration.Initialize();

            // DataStore is a static class for file I/O operations for the entire application
            // It loads data as the application starts
            // and saves data when the application exits, due to this event handler
            Application.ApplicationExit += (s, e) => DataStore.SaveAll();

            Application.Run(new Form_Login());
        }
    }
}