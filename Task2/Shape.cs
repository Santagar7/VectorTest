namespace Task2; 

public abstract class Shape : IComparable {
    
    public abstract double Area { get; }

    public int CompareTo(object? obj) {
        if (obj is not Shape) {
            throw new ArgumentException("Object is not a Shape");
        }
        return Area.CompareTo(((Shape)obj).Area);
    }
}