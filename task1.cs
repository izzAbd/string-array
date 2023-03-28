using System;
					
public class Program
{
	public static void Main()
	{
	Console.WriteLine("enter string: ");
	string myString = Console.ReadLine();
	string[] array = myString.Split(' ');
	int lengthArray = array.Length;
	Console.WriteLine(lengthArray);
	}
}