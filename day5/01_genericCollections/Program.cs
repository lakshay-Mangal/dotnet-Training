using System;

namespace Collection  // can store multiple values together
{
    class UsingGenerics<T>
    {
        T obj;
        public UsingGenerics(T obj)
        {
            this.obj= obj;
        }
        public T Get()
        {
            return obj;
        }
        public void Show(T obj)
        {
            Console.WriteLine("Type of T is" +typeof(T));
        }
    }
    class TestGeneric 
   {
 static void Main(String[] args)
        {
            UsingGenerics<int> objdata;
            objdata= new UsingGenerics<int>(500);
            objdata.Show(500);

        UsingGenerics<int> a = new(10);
        UsingGenerics<string> b = new("Hello");
        a.Show(32);
        b.Show("World");
        }
    }
}