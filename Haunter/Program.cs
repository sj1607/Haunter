namespace Haunter
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        [STAThread]
        static void Main()
        {
            //using mutex to check if another instance is running
            bool createdNew;
            using (Mutex mutex = new Mutex(true, "Haunter", out createdNew))
            {
                if (!createdNew)
                {
                    // Mutex already exists — meaning another instance is running
                    MessageBox.Show("The application is already running.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; // Exit this new instance
                }
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Application.Run(new Main());
            }
        }
    }
}