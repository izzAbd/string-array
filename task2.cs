using System;
					
public class Program
{
	public static void Main()
	{
		int [] array = new int [4];
		int [] arr = GetArray(array);
		int sumOfarr = SumofElement(arr);
		Console.WriteLine(sumOfarr);
	}
	static int[] GetArray(int[] array){
				for(int i=0;i<array.Length;i++){
					Console.WriteLine("enter element of array: ");
					int num = int.Parse(Console.ReadLine());
					array[i] = num;
				}
		return array;
	}
	static int SumofElement(int[] array){
		int sum = 0;
		for(int i=0;i<array.Length;i++){
				sum+=array[i];
		}
		return sum;
}
}