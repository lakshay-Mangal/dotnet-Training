using System;

class Program
{
    static void Main()
    {
        int[] arr = [5, 2, 9, 1, 3];

        Console.WriteLine("Original Array:");
        PrintArray(arr);

        Array.Sort(arr);

        Console.WriteLine("Sorted Array (Ascending):");
        PrintArray(arr);

        Array.Reverse(arr);
        Console.WriteLine("Sorted Array (Descending):");
        PrintArray(arr);


    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
