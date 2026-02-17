using System;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Enter 2 numbers");
        int num1 = int.Parse(Console.ReadLine());
        int num2= int.Parse(Console.ReadLine());

        if(num1 %2==0 && num2%2==0) Console.WriteLine("true both are even");
        else Console.WriteLine("False");

        bool bothEven = num1 % 2 == 0 && num2 % 2 == 0;

    Console.WriteLine(bothEven);     // true if both even
    Console.WriteLine(!bothEven);    // true if NOT both even
        

    }
}