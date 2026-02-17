using System;

class Program
{
    static void Main(string[] args)
    {
        int i ,j;
        Console.WriteLine("Enter 2 numbers");
        int num = int.Parse(Console.ReadLine());
        int width= int.Parse(Console.ReadLine());

        for( i = width; i >= 1; i--)
        {
            for( j=1;j<=i;j++){     
           Console.Write(num);

}                Console.WriteLine();
}
    }
}