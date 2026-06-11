namespace Project
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
            Application.Run(new Form1(@"Server=localhost;Database=CMPT291_Team1_MovieRental;Trusted_Connection=True;TrustServerCertificate=True;"));
        }
    }
}