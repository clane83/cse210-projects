using System;

public abstract class Shape{
    private string _color;
    private string _shapeType;
    public string GetColor()
    {
        return _color;
    }

    public string GetShapeType(){
        return _shapeType;
    }

    public void SetColor(string color){
        _color = color;
    }

    public void SetShapeType(string shapeType){
        _shapeType = shapeType;
    }

    public abstract double GetArea();
}