﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
	/// <summary>
	/// class of dacade
	/// </summary>
	class MenagmentCustomers
	{
		public Customer ShareCustomer(int id)
		{
			//code

			return new Customer();
		}


		public Customer ShareCustomer(string firstName, string lastName)
		{
			//code

			return new Customer();
		}


		public Boolean AddCustomer(string firstName, string lastName)
		{
			//code

			return false;
		}

		public Boolean ChangeDataCustomer(int id, string lastName, string firstName)
		{
			//code

			return false;
		}

		public Boolean DeleteCustomer(int id)
		{
			//code

			return false;
		}

		public Boolean DeleteCustomer(string lastName, string firstName)
		{
			//code

			return false;
		}


	}
}
