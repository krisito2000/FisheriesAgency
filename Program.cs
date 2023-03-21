namespace FisheriesAgency
{
    internal static class Program
    {
        private static string? getDBPath = Directory.GetParent(Directory.GetParent(Path.GetDirectoryName(Environment.CurrentDirectory)).ToString()).ToString();
        public static string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={getDBPath}\\Controller\\FisheriesAgencyDB.mdf;Integrated Security=True";

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frmLogin());

        }
    }
}