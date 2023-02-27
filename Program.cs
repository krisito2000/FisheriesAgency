namespace FisheriesAgency
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frmLogin());
        }
        public static string DBPath = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\krisi\\Source\\Repos\\FisheriesAgency\\Controller\\FisheriesAgencyDB.mdf;Integrated Security=True";
    }
}