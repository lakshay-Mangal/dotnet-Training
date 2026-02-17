using System;

class Program
{
    
    static void Main(String [] args)
    {
        string[] s = new string[5] {"Csharp", "Asp.net","Entity","ADO.net","WCF"};
        Array.Sort(s);
        foreach(string str in s)
        Console.Write(str + " ");
    }
}