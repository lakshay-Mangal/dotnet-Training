// using System;

// class ODLexercise
// {
//     private static int number;
//     public static int Number
//     {
//         get
//         {
//             return number;
//         }
//     }
//     static ODLexercise()
//     {
//         Random r = new Random();
//         number = r.Next();
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Static Number ="+ ODLexercise.Number);
//     }
// }
class ODLexercise
{
    private int number;

    public int Number
    {
        get { return number; }
    }

    public ODLexercise()
    {
        Random r = new Random();
        number = r.Next();
    }
    public ODLexercise(int seed)
    {
        Random r = new Random(seed);
        number = r.Next();
    }
}

class Program
{
    static void Main(String[] args)
    {
        ODLexercise num = new ODLexercise();
        Console.WriteLine("Number=" + num.Number);

        ODLexercise num1 = new ODLexercise(400);
                Console.WriteLine("Number=" + num1.Number);

    }
}