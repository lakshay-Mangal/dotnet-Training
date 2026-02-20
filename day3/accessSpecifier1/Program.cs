using System;
namespace AccessModifierDemo
{
    class UsingAccessModifier
    {
         private protected int value=5;

        public void PublicMethod()
        {
            Console.WriteLine("It is public");
        }
        private void PrivateMethod()
        {
            Console.WriteLine("It is private");
        }
        protected void ProtectedMethod()
        {
            Console.WriteLine("It is protected");
        }
        internal void InternalMethod()
        {
            Console.WriteLine("It is internal");
        }
        protected internal void ProtectedinternalMethod()
        {
            Console.WriteLine("It is protected internal");
        }
        void someMethod()
        {
            Console.WriteLine("Some Method");
        }
    }
    class Test  : UsingAccessModifier
{
    public void TestProtected()
        {
            ProtectedMethod();
        }
        public void testPrivateProtected()
        {
            value=10;
        }
    static void Main(String[] args)
    {
        UsingAccessModifier obj = new();
        obj.PublicMethod();
        obj.ProtectedinternalMethod();
        obj.InternalMethod();

        Test obj1 = new();
        obj1.TestProtected();
        Console.WriteLine(obj1.value);
        obj1.testPrivateProtected();
        Console.WriteLine(obj1.value);
    }
}
}

