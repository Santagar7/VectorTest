namespace Task2; 

public class Square : Shape {

    public double Side { get; set; }
    
    public Square(double side) {
        Side = side;
    }

    public override double Area {
        get {
            return Math.Pow(Side, 2);
        }
    }
}