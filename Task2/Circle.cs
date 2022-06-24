namespace Task2; 

public class Circle : Shape {

    public double Radius { get; set; }
    
    public Circle(double radius) {
        Radius = radius;
    }

    public override double Area {
        get {
            return Math.PI * Radius * Radius;
        }
    }
}