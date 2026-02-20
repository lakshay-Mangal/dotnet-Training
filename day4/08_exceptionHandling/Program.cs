class ExcDemo1
{
    public static void SingleCatch(String[] args)
    {
        int[] nums = new int[4];

        try
        {
            Console.WriteLine("Before exception is generated");
            //Generate an index out of bounds exception
            for(int i = 0; i < 10; i++)
            {
                nums[i]=i;
                Console.WriteLine("num[{0}]:{1}", i, nums[i]);
            }
            Console.WriteLine("This won't be displayed");
        }
        catch (IndexOutOfRangeException)
        {
            //catch the exception
            Console.WriteLine("Index out of bounds");
        }
        Console.WriteLine("After catch statement");
    }
    static void MultipleCatch(String[] args)
    {
        int[] num= {4,8,16,32,64,128,256,512};
        int[] denom= {2,0,4,4,0,8};

        for(int i= 0; i < num.Length; i++)
        {
            try
            {
                Console.WriteLine(num[i] + " / "+ denom[i] + " is " + num[i]/denom[i]);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Can't divide by zero");
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("No matching element found");
            }
        }
    }

    static void ManualException(String[] args)
    {
        try
        {
            Console.WriteLine("Before throw");
            throw new DivideByZeroException();
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Can't divide by zero");

        }
    }

}

namespace CustomExceptionExample
{    class MyException: Exception
    {
        public MyException(string Message): base(Message){Console.WriteLine("Constructor chaining");}
        public MyException() {}
        public MyException( string Message , Exception inner): base (Message, inner){Console.WriteLine("The return ofConstructor chaining");}


    }

    class Program
    {
        static void Main(String[] args)
        {
            int a =50;
            int b =10;
            int k = a/b;
            try
            {
                if(k<10)
                {
                    throw new MyException("Value of k is less than than 20");
                }
            
            }
            catch(MyException e)
            {
                Console.WriteLine("Caught MY EXCEPTION");
                Console.WriteLine(e.Message);
            }
        }
    }
}