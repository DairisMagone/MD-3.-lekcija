using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_lekcijas_MD
{
	class Product
	{
		public Product(double length, double height, double width)
		{
			LengthCm = length;
			HeightCm = height;
			WidthCm = width;
		}
		public double WeigthKg { get; set; }

		private double LengthCm { get; set; }

		private double HeightCm { get; set; }

		private double WidthCm { get; set; }

		public void ShowData()
		{
			Console.WriteLine("weight = " + WeigthKg + " kg");
			Console.WriteLine("length = " + LengthCm + " cm");
			Console.WriteLine("height = " + HeightCm + " cm");
			Console.WriteLine("width = " + WidthCm + " cm");
		}
	}
}
