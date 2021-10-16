using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_lekcijas_MD
{
	class Person
	{
		public string name { get; set; }

		public string surename { get; set; }

		public string hobby { get; set; }

		public string gender { get; set; }

		public int dateOfBirth { get; set; }

		public int personAge { get; set; }

		public void PersonData()
		{
			Console.WriteLine("Hello my name is " + name + " " + surename + " and I am " + personAge + " years old.");
		}
	}
}
