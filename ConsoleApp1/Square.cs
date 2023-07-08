using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class Square : Rectangle
	{
		public Square(int firstSide, int secondSide) : base(firstSide, secondSide)
		{

		}

		public void CalcSquareArea()
		{
			Console.WriteLine(FirstSide * SecondSide);
		}
	}
}
