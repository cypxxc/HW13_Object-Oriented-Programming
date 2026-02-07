interface IShaper{
    double Area();
    double Perimeter();
    void info();
}

record Rectangle(double width,double height) implements IShaper{

    public double Area() {
        return width * height;
    }

    public double Perimeter() {
        return 2 * (width + height);
    }

    public void info() {
        System.out.printf("Rectangle with width %.2f and height %.2f, Area: %.2f, Perimeter: %.2f", width, height, Area(), Perimeter());
    }
}

record Cricle(double radius) implements IShaper{

    public double Area(){
        return Math.PI * radius * radius;
    }

    public double Perimeter(){
        return 2* Math.PI * radius;
    }

    public void info(){
        System.out.printf("Cricle with radius %.2f, Area: %.2f, Perimeter: %.2f", radius, Area(), Perimeter());
    }
}

public class Main {
    public static void main(String[] args) {
        var r = new Rectangle(10, 20);
        r.info();

        var c = new Cricle(10);
        c.info();
    }
}