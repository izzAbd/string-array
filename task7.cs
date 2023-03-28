using System;

namespace Ternary
{
	class Program
	{
		public static void Main(string[] args)
		{
			int number = Console.Readline();
			bool isEven;

			isEven = (number % 2 == 0) ? true : false ;  
			Console.WriteLine(isEven);
		}
        
	}
}