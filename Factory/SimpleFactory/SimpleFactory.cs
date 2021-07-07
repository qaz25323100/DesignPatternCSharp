using System;

namespace DesginPatternCSharp.Factory.SimpleFactory{
    public interface Shape{
        string GetString();
    }
    class Circle : Shape
    {
        public string GetString()
        {
            return "I'm Cirle";
        }
    }

    class Triangle : Shape
    {
        public string GetString()
        {
            return "I'm Triangle";
        }
    }
    public class ShapeFactory{
        public Shape CreateShape(string type){
        switch(type){
            case "Circle" : {
                Console.WriteLine("New Circle");
                return new Circle();             
            }
            case "Triangle": {
                Console.WriteLine("New Triangle");
                return new Triangle();                
            }
            // 假如冒險者種類新增，增加case就可以
            default : return null;
        }
    }
    }
}