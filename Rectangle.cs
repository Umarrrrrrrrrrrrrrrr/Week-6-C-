namespace Rectanglee
{
    public class Rectangle
    {
        private double length;
        private double breadth;

        // Expression-bodied properties
    public double Length
    {
        get => length;
        set => length = value;
    }

    public double Breadth
    {
        get => breadth;
        set => breadth = value;
    }

    // Expression-bodied method for area
    public double GetArea() => length * breadth;

    // Expression-bodied method for perimeter
    public double GetPerimeter() => 2 * (length + breadth);

    // Expression-bodied method for details
    public string ShowDetails() =>
        $"Length: {length}, Breadth: {breadth}, Area: {GetArea()}, Perimeter: {GetPerimeter()}";

    }
}