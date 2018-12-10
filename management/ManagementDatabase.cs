using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.management
{
	class ManagementDatabase
	{
		ConectDatabase database = new ConectDatabase();

		public void GetPerson(int id)
		{
			List<string> wynik = database.GetResult("SELECT firstName, lastName FROM persons WHERE id = " + id, 2);



			foreach (string w in wynik)
			{
				Console.WriteLine(w);
			}


		}
	}
}
