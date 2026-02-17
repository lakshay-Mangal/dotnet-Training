using System;
using System.Transactions;

class Program
{
    static void Main(String[] args){
    Console.WriteLine("Enter 3 letters");
   char a=  Console.ReadLine()[0];
   char b = Console.ReadLine()[0];
   char c = Console.ReadLine()[0];

   Console.WriteLine(" {0}, {1}, {2}",c,b,a);
    
    }
}