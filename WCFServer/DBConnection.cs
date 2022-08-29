using System;
using System.Data.SqlClient;

namespace WCFServer
{
    public class DBConnection
    {
        private static readonly string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS1\MSSQL\DATA\E-Commerce.mdf;Integrated Security=True;MultipleActiveResultSets=True";
        private static readonly SqlConnection conn;

        static DBConnection()
        {
            conn = new SqlConnection(cs);
        }

        public static void DBOpen()
        {
            conn.Open();
        }

        public static void DBClose()
        {
            conn.Close();
        }

        public static bool Execute(string query)
        {
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();
                SqlTransaction tx = connection.BeginTransaction();
                SqlCommand sqlcmd = new SqlCommand(query, connection);
                sqlcmd.Transaction = tx;

                try
                {
                    sqlcmd.ExecuteNonQuery();
                    tx.Commit();
                    connection.Close();
                    return true;
                }
                catch (Exception)
                {
                    tx.Rollback();
                }
            }
            return false;
        }

        public static SqlDataReader Read(string query)
        {
            SqlCommand sqlcmd = new SqlCommand(query, conn);
            return sqlcmd.ExecuteReader();
        }

        public static SqlConnection GetConnection()
        {
            return conn;
        }
    }
}

