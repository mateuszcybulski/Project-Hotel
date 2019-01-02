using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
	class Person
	{
		private int id;
		public bool worker;

		public int Id {
			get { return id; }
			set {
				if (value < 0) throw new IndexOutOfRangeException();
				else id = value;
			}
		}

		public string LastName { get; set; }
		public string FirstName { get; set; }


		public Person(int id, string FirstName, string LastName)
		{
			this.id = id;
			this.FirstName = FirstName;
			this.LastName = LastName;
		}

		public Person(string FirstName, string LastName)
		{
			this.FirstName = FirstName;
			this.LastName = LastName;
		}

	}
}
