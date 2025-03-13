namespace ShapeCalculator;

class Program
{
    static void Main(string[] args)
    {
        Rectangle r = new Rectangle("Rectangle",5,3);
        r.Display();

        Circle c = new Circle("Circle", 5);
        c.Display();
    }
}
