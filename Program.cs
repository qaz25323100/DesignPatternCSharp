
using System;
using DesginPatternCSharp.Factory.SimpleFactory;

namespace DesginPatternCSharp{
    class Program{
        
        public static void Main(string[] args){
            ShapeFactory shapeFactory = new ShapeFactory();
            var shape = shapeFactory.CreateShape("Circle");
            Console.WriteLine(shape.GetString());
        }
    }
}