using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
	class Program
	{
		static void Main(string[] args)
		{
			MenagmentDatabase database = new MenagmentDatabase();

			List<string> wynik = database.GetResult("SELECT id, imie FROM moja_tabela", 2);
			

			foreach (string w in wynik)
			{
				Console.WriteLine(w);
			}

			Console.ReadLine();
		}
	}
}
