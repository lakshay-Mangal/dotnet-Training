using System;

class ODLexercise
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
    public static int Mul(int a, int b)
    {
        return a * b;
    }
    public static int Sub(int a, int b)
    {
        return a - b;
    }
    public static int Div(int a, int b)
    {
        return a / b;
    }
     public static int Mod(int a, int b)
    {
        return a % b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter 2 numbers");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int result = ODLexercise.Add(num1, num2);
        int result2= ODLexercise.Sub(num1, num2);
        int result3= ODLexercise.Mul(num1, num2);
        int result4= ODLexercise.Div(num1, num2);
        int result5= ODLexercise.Mod(num1, num2);
        Console.WriteLine(result);
        Console.WriteLine(result2);
        Console.WriteLine(result3);
        Console.WriteLine(result4);
        Console.WriteLine(result5);
    }
}
