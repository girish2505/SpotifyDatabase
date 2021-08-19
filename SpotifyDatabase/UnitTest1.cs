using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;

namespace SpotifyDatabase
{
    [TestClass]
    public class Spotify
    {
        public static string connectionString = @"Server = (localdb)\MSSQLLocalDB; Initial Catalog = spotify; Integrated Security=True;";
        SqlConnection connection = new SqlConnection(connectionString);

        [TestMethod]
        public void TestMethod1()
        {
            connection.Open();
            string query = @"insert into userDetails(id,userName,playlistId) values (5,'allu',7)";
            SqlCommand insertCommand = new SqlCommand(query, connection);
            int res = insertCommand.ExecuteNonQuery();
            Assert.AreEqual(1, res);
        }
    }
}
