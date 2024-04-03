using BaltaDataAccessHandsOn.Screens.MainMenuScreen;
using BaltaDataAccessHandsOn.Screens.TagScreens;
using Microsoft.Data.SqlClient;

namespace BaltaDataAccessHandsOn
{
    class Program
    {
        private const string CONNECTION_STRING = "Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;";
        static void Main(string[] args)
        {
            Database.Connection = new SqlConnection(CONNECTION_STRING);
            Database.Connection.Open();
            MainMenuScreen.Show();
            Console.ReadKey();
            Database.Connection.Close();
        }

    }
}