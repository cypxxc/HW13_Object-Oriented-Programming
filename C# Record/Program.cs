interface IShaper
{
    double Area();
    double Perimeter();
    void info();
}

record Rectangle(double width, double height) : IShaper
{
    public double Area() => width * height;

    public double Perimeter() => 2 * (width + height);

    public void info() => System.Console.WriteLine($"Rectangle :width({width}), height({height}),\n Area{Area():F2}, Perimeter{Perimeter():F2}");
}


record Cirlce(double radius) : IShaper
{
    public double Area() => Math.PI * radius * radius;

    public double Perimeter() => 2 * Math.PI * radius;

    public void info() => System.Console.WriteLine($"Cricle : radius({radius}),\n Area{Area():F2}, Perimeter{Perimeter():F2}");
}
public class Program
{
    static void Main(string[] args)
    {
        var r = new Rectangle(10, 20);
        r.info();

        var c = new Cirlce(10);
        c.info();
    }
}