using System;

namespace task6;					
public class Program
{
	public static void Main()
	{
		int [] array = new int [4];
		int [] arr = GetArray(array);
		int count = Counter(arr);
        Console.WriteLine(count);
	}
	static string[] GetArray(string[] array){
				for(int i=0;i<array.Length;i++){
					Console.WriteLine("enter element of array: ");
					string element = (Console.ReadLine());
					array[i] = element;
				}
		return array;
	}
	static int Counter(int[] array){
		 int count = 0;
		 for(int i = 0; i<array.Length;i++){
         for(int j = 0; j<array[i].Length;j++){
            if(array[i][j]=='e'){
                count+=1;
            }
        }
        return count;
}
}
}