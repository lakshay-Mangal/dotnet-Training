namespace Delegagte
{
    class UsingDelegate
    {public delegate void ArithmaticOperation (int x , int y); //delegate can be made inside or outside the class
    static void AddSimple()
        {
            Console.WriteLine("This can not be accessed by the delegate");
        }
    static void Add(int x , int y)
    {
        Console.WriteLine(x+y);
    }
    static void Sub(int x , int y)
    {
        Console.WriteLine(x-y);
    }
    static void Mul(int x , int y)
    {
        Console.WriteLine(x*y);
    }
    static void Div(int x , int y)
    {
        Console.WriteLine(x/y);
    }
    static void Main(String[] args)
        {
            // ArithmaticOperation obj= new(Add);
            // ArithmaticOperation obj1= new(Sub);

            // obj(45,66);
            // obj1(45,30);
            ArithmaticOperation obj= new(Add);
            obj+= new ArithmaticOperation(Sub);
            obj-= new ArithmaticOperation(Mul);
            obj+= new ArithmaticOperation(Div);
            obj+= new ArithmaticOperation(Mul);

            obj(45,30);
        }
}
}