using Hotel.management;
using System;

namespace Hotel
{
	class Program
	{
		static void Main(string[] args)
		{
			//ManagmentDatabase database = new ManagmentDatabase();

			//"SELECT id, imie FROM moja_tabela"
			//"INSERT INTO moja_tabela VALUES (100, 'ie', 'no' , 0)"

			//List<string> wynik = database.GetResult("SELECT id, firstName, lastName FROM persons", 3);


			//foreach (string w in wynik)
			//{
			////	Console.WriteLine(w);
			////}
			///


			ManagementDatabase data = new ManagementDatabase();

			Person person = new Person(4, "Nowa", "Osoba");
			Person thesame = data.GetPerson(person);
			




			// add person
			//Person person = new Person("Nowa", "Osoba");
			//data.AddNewPerson(person);

			Console.ReadLine();
		}
	}
}
