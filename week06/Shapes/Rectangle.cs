using System;

public class Rectangle : Shape {

    private double _length;
    private double _width;

    public void SetSides(double length, double width){
        _length = length;
        _width = width;
    }
    public override double GetArea() {
        return _length * _width;
    }
}