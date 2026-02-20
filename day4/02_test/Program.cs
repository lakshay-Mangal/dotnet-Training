abstract class DrawingObject
{
    public abstract void Draw();
}


class Line : DrawingObject
{
    public override void Draw()
    {
        Console.WriteLine("Drawing Line");
    }
}
class Circle : DrawingObject
{
    public override void Draw()
    {
        Console.WriteLine("Drawing Circle");
    }
}
class Square : DrawingObject
{
    public override void Draw()
    {
        Console.WriteLine("Drawing Square");
    }
}

class Program
{
    static void Main(String[] args)
    {
        DrawingObject[] Object = [new Line(), new Circle(), new Square()];
        for (int i=0;i< 3;i++) 
        Object[i].Draw();
    }
}