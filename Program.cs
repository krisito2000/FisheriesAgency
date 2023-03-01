namespace FisheriesAgency
{
    internal static class Program
    {
        //public static string GetLocalDbConnectionString(string databaseName)
        //{
        //    string GetCurrDir = Path.GetDirectoryName(Environment.CurrentDirectory);
        //    string getDBPath = Directory.GetParent(Directory.GetParent(GetCurrDir).ToString()).ToString();
        //    return getDBPath;
        //}
        //public static string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={GetLocalDbConnectionString}\\Controller\\FisheriesAgencyDB.mdf;Integrated Security=True";
        public static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\krisi\\Source\\Repos\\FisheriesAgency\\Controller\\FisheriesAgencyDB.mdf;Integrated Security=True";

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frmLogin());

            //string GetCurrDir = Path.GetDirectoryName(Environment.CurrentDirectory);
            //string getDBPath = Directory.GetParent(Directory.GetParent(GetCurrDir).ToString()).ToString();

            //MessageBox.Show(GetCurrDir);
            //MessageBox.Show(getDBPath);
            //MessageBox.Show(connectionString);
        }
    }
}