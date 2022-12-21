using System;
using System.Data;
using System.Data.SqlClient;

namespace PizzaMizza.Helper
{
	static class SqlPizza
	{
		static string connectionString = "Server=localhost; Database = PizzaMizza ; User ID = sa; Password = Ulviyya1! ; Trusted_Connection = False";

		static SqlConnection _connection;

		public static SqlConnection Connection
		{
			get
			{
				if (_connection==null)
				{
					_connection = new SqlConnection(connectionString);
				}
				return _connection;
			}
		}

		public static int ExecCommand(string command)
		{
			int result = 0;
			Connection.Open();
			using(SqlCommand sqlcommand = new SqlCommand(command, Connection))
			{
				result = sqlcommand.ExecuteNonQuery();
			}
			Connection.Close();
			return result;
		}
		public static DataTable Execquery(string query)
		{
			DataTable dt = new DataTable();
			Connection.Open();
			using(SqlDataAdapter sda = new SqlDataAdapter(query, Connection))
			{
				sda.Fill(dt);
			}
			Connection.Close();
			return dt;
		}
	}
}

