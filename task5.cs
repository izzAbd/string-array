using System;

namespace task5;


public class Program
{
	public static void Main(string[] args){
        int sum = 0;
        Console.WriteLine("enter number: ");
        string numberStr = Console.ReadLine();
        string [] numbers = numberStr.Split(',');
        for(int i = 0;i<numbers.Length;i++){
            sum+=int.Parse(numbers[i]);
        }
        Console.WriteLine(sum/numbers.Length);
   }
}