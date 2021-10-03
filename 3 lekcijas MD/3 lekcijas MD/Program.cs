using System;

namespace _3_lekcijas_MD
{
	class Program
	{
		static void Main(string[] args)
		{
			Phone phone = new Phone();

			Console.WriteLine("What phone brand do You have?");
			string phoneName = Console.ReadLine();

			phone.phoneName = phoneName;

			Console.WriteLine("What phone Model is it?");
			string phoneModel = Console.ReadLine();

			phone.phoneModel = phoneModel;

			Console.WriteLine("What is your phone Length?");
			string textPhoneLength = Console.ReadLine();
			int phoneLength = int.Parse(textPhoneLength);

			phone.phoneLength = phoneLength;

			Console.WriteLine("What is your phone Width?");
			string textPhoneWidth = Console.ReadLine();
			int phoneWidth = int.Parse(textPhoneWidth);

			phone.phoneWidth = phoneWidth;

			Console.WriteLine("What is your phone Height?");
			string textPhoneHeight = Console.ReadLine();
			int phoneHeight = int.Parse(textPhoneHeight);

			phone.phoneHeight = phoneHeight;


		}
	}
}
