 class DrawingObject
{
    public virtual void Draw()
    {
     Console.WriteLine("Drawing Something");   
    }
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
        DrawingObject[] Object = [new Line(), new Circle(), new Square(), new DrawingObject()];
        for (int i=0;i< 4;i++) 
        Object[i].Draw();
    }
}