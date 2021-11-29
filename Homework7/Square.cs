using System;


// порушений принцип L : принцип підстановки LISKOV


abstract class Shape
{
    public abstract int GetArea();
}


class Rectangle : Shape
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }
    public override int GetArea()
    {
        return Width * Height;
    }
}

//квадрат наслідується від фігури!!!
class Square : Shape
{
    private int side;
    public int Side
    {
        get { return side; }
        set
        {
            side = value;
        }
    }

    public override int GetArea()
    {
        return side * side;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape square = new Square();
        square.Side = 5;

        Console.WriteLine(square.GetArea());

        Shape rect = new Rectangle();
        rect.Width = 5;
        rect.Height = 10;

        Console.WriteLine(rect.GetArea());

        Console.ReadKey();
    }
}
