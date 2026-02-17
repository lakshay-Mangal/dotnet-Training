using System;

class Program
{
    static void Main(String [] args)
    {
        int marks =85;
        Console.WriteLine("Marks: "+ marks);
        Object objmarks = marks; // boxing
        Console.WriteLine("Object Marks: "+ objmarks);
        int unboxmarks= (int)objmarks; //unboxing / explicit conversion
        Console.WriteLine("Unboxed marks: " + unboxmarks);
        unboxmarks= unboxmarks+5; //modifying unboxed value;
        Console.WriteLine("Modified Unboxed marks:" + unboxmarks);
    }
}