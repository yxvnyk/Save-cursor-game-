using System.Data.SqlClient;

namespace Save_cursor__game_
{
    internal class DataBase
    {
        SqlConnection connection = new SqlConnection("(connection string to your db)");


        public SqlConnection GetConnection()
        {
            return connection;
        }
        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
