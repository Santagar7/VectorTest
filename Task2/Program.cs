namespace Task2;

static class Program {
    static void Main() {
        var side = 1.1234D;
        var radius = 1.1234D;
        var _base = 5D;
        var height = 2D;
        var shapes = new List<Shape> {
            new Square(side),
            new Circle(radius),
            new Triangle(_base, height),
            new Rectangle(1, 3)
        };
        shapes.Sort();

        foreach (var shape in shapes) {
            Console.WriteLine(shape.Area);
        }
    }
}