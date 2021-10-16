using System;

namespace _3_lekcijas_MD
{
	class Program
	{
		static void Main(string[] args)
		{
			//Phone phone = GetPhone();

			//DoActionsWithCar();

			//DoActionsWithProduct();

			GetCredentials();

		}

		private static void DoActionsWithProduct()
		{
			Console.WriteLine("Enter product length: ");
			string textLength = Console.ReadLine();
			double length = double.Parse(textLength);

			Console.WriteLine("Enter product height: ");
			string textHeight = Console.ReadLine();
			double height = double.Parse(textHeight);

			Console.WriteLine("Enter product width: ");
			string textWidth = Console.ReadLine();
			double width = double.Parse(textWidth);

			Product product = new Product(length, height, width);

			Console.WriteLine("Enter product weight: ");
			string textWeight = Console.ReadLine();
			product.WeigthKg = double.Parse(textWeight);

			product.ShowData();

		}

		private static void DoActionsWithCar()
		{
			Car myCar = GetMyCar();

			myCar.StartMoving();

			myCar.Beep();

			Console.WriteLine("Current car speed is: " + myCar.speed);

			Console.WriteLine("Add speed: ");
			string textAcceleration = Console.ReadLine();
			int acceleration = int.Parse(textAcceleration);
			myCar.Accelerate(acceleration);

			Console.WriteLine("Current car speed is: " + myCar.speed);

			myCar.StopMoving();

			Console.WriteLine("Current car speed is: " + myCar.speed);
		}

		static Car GetMyCar()
		{
			Car myCar = new Car();

			Console.WriteLine("What is your car trade?");
			myCar.Name = Console.ReadLine();

			Console.WriteLine("What is your car Registration Number?");
			myCar.RegistryNumber = Console.ReadLine();

			return myCar;
		}

		static Phone GetPhone()
		{
			Phone phone = new Phone();

			Console.WriteLine("What phone brand do You have?");
			string phoneName = Console.ReadLine();

			phone.PhoneName = phoneName;

			Console.WriteLine("What phone Model is it?");
			string phoneModel = Console.ReadLine();

			phone.PhoneModel = phoneModel;

			Console.WriteLine("What is your phone Length?");
			string textPhoneLength = Console.ReadLine();
			int phoneLength = int.Parse(textPhoneLength);

			phone.PhoneLength = phoneLength;

			Console.WriteLine("What is your phone Width?");
			string textPhoneWidth = Console.ReadLine();
			int phoneWidth = int.Parse(textPhoneWidth);

			phone.PhoneWidth = phoneWidth;

			Console.WriteLine("What is your phone Height?");
			string textPhoneHeight = Console.ReadLine();
			int phoneHeight = int.Parse(textPhoneHeight);

			phone.PhoneHeight = phoneHeight;

			return phone;
		}

		static Person GetCredentials()
		{
			Person person = new Person();

			Console.WriteLine("What is your name?");
			string name = Console.ReadLine();

			person.name = name;

			Console.WriteLine("What is your surename?");
			string surename = Console.ReadLine();

			person.surename = surename;

			Console.WriteLine("What is your hobby?");
			string hobby = Console.ReadLine();

			person.hobby = hobby;

			Console.WriteLine("What is your gender?");
			string gender = Console.ReadLine();

			person.gender = gender;

			Console.WriteLine("Enter a month of birth: ");
			int month = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter a day of birth: ");
			int day = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter a year of birth: ");
			int year = int.Parse(Console.ReadLine());
			DateTime dateOfBirth = new DateTime(year, month, day);

			//Console.Write("Enter a date (e.g. 10/22/1987): ");
			//DateTime inputtedDate = DateTime.Parse(Console.ReadLine());

			DateTime now = DateTime.Today;

			int personAge = now.Year - dateOfBirth.Year;
			person.personAge = personAge;

			person.PersonData();

			return person;

		}

	}
}
