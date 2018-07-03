using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIntro
{
	class Program
	{
		static int add(int param1, int param2)
		{
			return param1 + param2;
		}
		static void Main(string[] args)
		{

			Console.WriteLine("Plece input first number");
			var x = Console.ReadLine();
			Console.WriteLine("Plece input second number");
			var y = Console.ReadLine();
             int xInt = int.MaxValue;
			int.TryParse(x, out xInt);
             int yInt = int.MaxValue;
			int.TryParse(y, out yInt);
			if (xInt == 0 || yInt == 0)
				Console.WriteLine("Incorrect input");
			else
				Console.WriteLine(add(xInt, yInt));
		}
	}
}
