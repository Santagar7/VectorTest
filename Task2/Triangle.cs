namespace Task2; 

public class Triangle : Shape {

    public double Base { get; set; }
    public double Height { get; set; }
    
    public Triangle(double _base, double height) {
        Base = _base;
        Height = height;
    }

    public override double Area {
        get {
            return Base * Height / 2;
        }
    }
}