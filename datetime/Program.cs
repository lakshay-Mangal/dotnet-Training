using System;
class Program
{
    static void Main(String[] args)
    {
        DateTime? dt = null;
        dt =DateTime.Now;
        object o = dt;
        DateTime? dt2 =o as DateTime?;
        if (dt2 != null)
        {
            Console.WriteLine(dt2.Value.ToString());
        }
        Console.ReadLine();

    }
}