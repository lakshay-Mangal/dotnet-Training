using System.Net.Http.Headers;

class Car
{   
    public string name ;
    public int door;
    public Car()
    {
        name ="Default";
        door= 4;
    }
    public Car(String name, int door)
    {
         this.name = name;
         this.door=door;
    }
    public Car(string name)
    {
        this.name= name;
        door= 4;
    }
    public Car(int door)
    {
        name = "Default";
        this.door= door;
    }

}

class GroupAgent
{
    public void Show()
    {
        Console.WriteLine("GroupAgent Created");

    }

}
class Agent: GroupAgent
{
    public new void Show()
    {
        Console.WriteLine("Agent  Created");
    }
}

class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal speaking");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog Barking");
    }
}

class Program
{
    static void MethodOverloading(String [] args)
    {
        Car c1= new ();
        Car c2 = new("bmw",2);
        Car c3 = new ("Audi");
        Car c4= new(6);
        Console.WriteLine("C1 is {0} with {1} doors ", c1.name, c1.door);
        Console.WriteLine("C2 is {0} with {1} doors ", c2.name, c2.door);
        Console.WriteLine("C3 is {0} with {1} doors ", c3.name, c3.door);
        Console.WriteLine("C4 is {0} with {1} doors ", c4.name, c4.door);
    }

    static void MethodOverhiding(String [] args)
    {
        GroupAgent a1= new ();
        a1.Show();
        Agent a2= new();
        a2.Show();
    }

    static void Main(String[] args)
    {
        Animal a1= new();
        a1.Speak();
        Dog a2= new();
        a2.Speak();
    }
}