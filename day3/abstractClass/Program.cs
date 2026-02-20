
abstract class Vehicle
{
    public abstract void Start();

    public void Stop()
    {
        Console.WriteLine("Vehicle Stopped");
    }
}

 class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Car Started");
    }
}

class Bike: Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Bike Started");
    }
}

class Program
{
    static void Main(String[] args)
    {
        Vehicle v1 = new Car();
        v1.Start();
        v1.Stop();

        Bike b1= new();
        b1.Start();
        b1.Stop();
    }
}