using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.management
{
	class ConectDatabase
	{
		private MySqlConnection databaseConnection;
		private MySqlCommand commandDatabase;
		private List<string> result = new List<string>();
		private string query;
		private int colums;

		private void PrepareTheConection()
		{
			string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=hotel;";

			databaseConnection = new MySqlConnection(connectionString);
			commandDatabase = new MySqlCommand(query, databaseConnection)
			{
				CommandTimeout = 60
			};
		}

		private void Reader(MySqlDataReader reader)
		{
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					for (int i = 0; i < colums; i++)
					{
						result.Add(reader.GetString(i));

					}
				}

			}
			else
			{
				Console.WriteLine("No rows found.");
			}
		}

		public void OpenDatabase()
		{
			PrepareTheConection();
			MySqlDataReader reader;

			try
			{
				databaseConnection.Open();

				reader = commandDatabase.ExecuteReader();

				if (colums > 0)
				{
					Reader(reader);

				}
				else result.Add("UPDATE SUCCES");


				databaseConnection.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="query"> SELECT, UPDATE, INSERT or DELETE</param>
		/// <param name="colums">
		/// colums greater 0 for SELECT
		/// colums less or equals 0 for UPDATE, INSERT and DELETE
		/// </param>
		/// <returns></returns>
		public List<string> GetResult(string query, int colums)
		{
			this.query = query;
			this.colums = colums;

			OpenDatabase();

			return result;
		}
	}
}
