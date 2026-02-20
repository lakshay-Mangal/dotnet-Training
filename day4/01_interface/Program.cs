namespace InterfaceDemo
{
    interface IArea
    {
        void CalcArea( double radius);
    }
    interface IVolume
    {
        void CalcVol(int side);
    }

    public class CircleCube : IArea , IVolume
    {
        public void CalcArea(double radius)
        {
            double pie= 3.14;
            double result;
            result = pie*radius*radius;
            Console.WriteLine("Area of Circle is {0}", result);
        }

        public void CalcVol(int side)
        {
            int result;
            result= side*side*side;
            Console.WriteLine("Volume of Cube is {0}", result);
        }
    }

    class TestInterface
    {
        static void Main(String[] args)
        {
            CircleCube c1= new();
            double radius;
            int side;
            Console.WriteLine("Enter Radius");
             radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Side");
            side = int.Parse(Console.ReadLine());
            c1.CalcArea(radius);
            c1.CalcVol(side);
        }
    }
}