using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_lekcijas_MD
{
	class Car
	{
		public string Name { get; set; }

		public string RegistryNumber { get; set; }

		public int speed = 0;

		public void StartMoving()
		{
			speed = speed + 5;
			Console.WriteLine("Starting to move.");
		}

		public void Accelerate(int acceleration)
		{
			Console.WriteLine("Increasing speed by: " + acceleration);
			speed = speed + acceleration;
		}
		public void StopMoving()
		{
			speed = 0;
			Console.WriteLine("Stopped.");
		}
		public void Beep()
		{
			Console.WriteLine("Beep Beep!");
		}
	}
}
