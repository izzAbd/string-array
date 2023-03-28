using System;

namespace Program;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        int count = 0;
        Console.WriteLine("enter string: ");
        string str = Console.ReadLine();
        char [] saitler = {'a','i','o','u','e'};
        for(int i=0;i<str.Length;i++){
            for(int j=0;j<saitler.Length;j++){
                if(str[i] == saitler[j]){
                    count++;
                }
            }
            
        }
        Console.WriteLine(count);
    }
}