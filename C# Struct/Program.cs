interface IShaper
{
    double Area();
    double Perimeter();
    void Info();
}

struct Rectangle : IShaper
{
    double width;
    double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public double Area() => width * height;

    public double Perimeter() => 2 * (width + height);

    public void Info() => System.Console.WriteLine($"Rectangle : width({width}), height({height}),\n Area: {Area():F2}, Perimeter: {Perimeter():F2}");
}

struct Circle : IShaper
{
    double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double Area() => Math.PI * radius * radius;

    public double Perimeter() => 2 * Math.PI * radius;

    public void Info() => System.Console.WriteLine($"Cricle : radius({radius}),\n Area: {Area():F2}, Perimeter: {Perimeter():F2}");
}

public class Program
{
    static void Main(string[] args)
    {
        var r = new Rectangle(10, 20);
        r.Info();

        var c = new Circle(10);
        c.Info();
    }
}