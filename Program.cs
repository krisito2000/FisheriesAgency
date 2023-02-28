namespace FisheriesAgency
{
    internal static class Program
    {
        public static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\krisi\\Source\\Repos\\FisheriesAgency\\Controller\\FisheriesAgencyDB.mdf;Integrated Security=True";
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frmLogin());
        }
        
    }
}