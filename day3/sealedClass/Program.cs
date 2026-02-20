class GroupAgent
{
    public virtual void Show()
    {
        Console.WriteLine("GroupAgent Created");

    }

}
class Agent: GroupAgent
{
    public sealed override void Show() //will noT work because of seal
    
    {
        Console.WriteLine("Agent  Created");
    }
}

class Booking : Agent
{
    public override void Show()
    {
        Console.WriteLine("Booking Created");
    }

}
class Program{
static void Main(String [] args)
{
    Agent A1= new();
    A1.Show();

    Booking b1 = new();
    b1.Show();
}
}