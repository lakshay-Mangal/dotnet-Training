using System;

class Program
{
    static void Main(string [] args)
    {   Console.WriteLine("Enter 2 numbers");
        int a =int.Parse(Console.ReadLine());
        int b=int.Parse(Console.ReadLine());
        if(a>b) Console.WriteLine("A is greater");
        else Console.WriteLine("b is greater");
    }
}