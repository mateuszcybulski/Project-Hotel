using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.management
{
	class ManagementDatabase
	{
		ConectDatabase database = new ConectDatabase();

		public Person GetPerson(int id)
		{
			List<string> wynik = database.GetResult("SELECT firstName, lastName, worker FROM persons WHERE id = " + id, 3);
			
			foreach (string w in wynik)
			{
				//Console.WriteLine("wynik "+w);
			}

			
			if (wynik.Count > 0) {

				if (wynik[2].Equals("False"))
				{
					Customer person = new Customer(id, wynik[0], wynik[1]);
					

					return person;
				}
				else if (wynik[2].Equals("True"))
				{
					Worker person = new Worker(id, wynik[0], wynik[1]);


					return person;
				}
			}
			else
				Console.WriteLine("brak danych");


			
			return null;
		}

		public Person GetPerson(string firstName, string lastName)
		{
			List<string> wynik = database.GetResult("SELECT id, worker FROM persons " +
				"WHERE firstName = '" + firstName + "' AND lastName ='" + lastName + "'", 2);


			if (wynik.Count > 0)
			{

				if (wynik[1].Equals("False"))
				{
					//Customer person = new Customer(id, wynik[0], wynik[1]);
					Console.WriteLine("klient");

					//return person;
				}
				else if (wynik[1].Equals("True"))
				{
					//Worker person = new Worker(id, wynik[0], wynik[1]);
					Console.WriteLine("pracownik");

					//return person;
				}
			}
			else
				Console.WriteLine("brak danych");



			return null;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="person"></param>
		/// <returns>UPDATE SUCCES, ERROR UPDATE or PERSON NOT FOUND</returns>
		public string UpdatePerson(Person person) {

			List<string> wynik = database.GetResult("SELECT firstName, lastName, worker FROM persons WHERE id = " + person.Id, 3);

			string result = "";

			if (wynik.Count == 0)
			{
				result = "PERSON NOT FOUND";
			}
			else
			{
				List<string> wy = database.GetResult("UPDATE persons SET firstName = '" + person.FirstName + "', lastName = '" + person.LastName + "' " +
					"WHERE id = " + person.Id, 0);
				if (wy[0].Equals("UPDATE SUCCES"))
				{
					result = "SUCCES";
				}
				else result = "ERROR UPDATE";
			}
			return result;
		}


		public void AddNewPerson(Person person)
		{
			/*List<string> data = database.GetResult("SELECT id FROM persons", 1);

			if (data.Count > 0)
			{
				Console.WriteLine(data[data.Count - 1]);

			}
			else {
				Console.WriteLine("brak danych w bazie");

			}*/


			List<string> theSamePerson = database.GetResult(
				"SELECT id FROM persons " +
				"WHERE fistName = '" + person.FirstName + "', lastName = '" + person.LastName + "'", 1);

			foreach (var item in theSamePerson)
			{
				Console.WriteLine(item);
			}

			//List<string> databaseResult = database.GetResult("INSERT INTO `persons`(`firstName`, `lastName`, `worker`) VALUES ('Nowa', 'Osoba', 0)", 0);
			




		}

	}
}
