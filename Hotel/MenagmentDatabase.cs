using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Hotel
{
	class MenagmentDatabase
	{
		private MySqlConnection databaseConnection;
		private MySqlCommand commandDatabase;
		private List<string> result = new List<string>();
		private string query;
		private int colums;

		private void PrepareTheConection()
		{
			string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=test;";
			

			databaseConnection = new MySqlConnection(connectionString);
			commandDatabase = new MySqlCommand(query, databaseConnection);
			commandDatabase.CommandTimeout = 60;
			
		}

		private void Reader(MySqlDataReader reader) {
			

			if (reader.HasRows)
			{
				while (reader.Read())
				{
					//Console.WriteLine(reader.GetString(0) + " " + reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3));

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
		
		public void ConectDatabase()
		{
			

			PrepareTheConection();
			MySqlDataReader reader;


			// Let's do it !
			try
			{
				// Open the database
				databaseConnection.Open();


				// Execute the query
				reader = commandDatabase.ExecuteReader();


				Reader(reader);
				
				
				// Finally close the connection
				databaseConnection.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			
		}


		public List<string> GetResult(string query, int colums) {
			this.query = query;
			this.colums = colums;

			ConectDatabase();


			return result;
		}
	}
}
