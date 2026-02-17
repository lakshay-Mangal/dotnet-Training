using System;

class Program
{
    static void Main(string [] args)
    {   Console.WriteLine("Enter a number b/w 1 and 5");
        int a =int.Parse(Console.ReadLine());
        switch (a)
        {
            case 1: 
            Console.WriteLine("Your number is {0}",a);
            break;
            case 2: 
            Console.WriteLine("Your number is {0}",a);
            break;
            case 3: 
            Console.WriteLine("Your number is {0}",a);
            break;
            case 4: 
            Console.WriteLine("Your number is {0}",a);
            break;
            case 5: 
            Console.WriteLine("Your number is {0}",a);
            break;

            default:
            Console.WriteLine("Your number is not between 1 and 5");
            break;
        }
    }
}