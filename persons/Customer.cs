using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
	class Customer : Person
	{
		public Customer(int id, string FirstName, string LastName) : base(id, FirstName, LastName) {
			worker = false;
		}
		public Customer(string FirstName, string LastName) : base(FirstName, LastName)
		{
			worker = false;
		}

	}
}
