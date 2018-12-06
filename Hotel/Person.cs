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

		public int Id {
			get { return id; }
			set {
				if (value < 0) throw new IndexOutOfRangeException();
				else id = value;
			}
		}

		public string LastName { get; set; }
		public string ForstName { get; set; }
	}
}
