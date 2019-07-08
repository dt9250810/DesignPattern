using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
    class FactoryMethod
    {
        /// <summary>
        /// 圖形介面
        /// </summary>
        public interface Shape
        {
            void draw();
        }

        public class Square : Shape
        {
            public void draw()
            {
                Console.WriteLine("This is Square.");
            }
        }

        public class Circle : Shape
        {
            public void draw()
            {
                Console.WriteLine("This is Circle.");
            }
        }

        public class Rectangle : Shape
        {
            public void draw()
            {
                Console.WriteLine("This is Rectangle.");
            }
        }

        /// <summary>
        /// 圖形工廠
        /// </summary>
        public class ShapeFactory
        {
            public Shape GetShape(string shapeName)
            {
                switch(shapeName)
                {
                    case "Square":
                        return new Square();
                    case "Circle":
                        return new Circle();
                    case "Rectangle":
                        return new Rectangle();
                    default:
                        return null;
                }
            }
        }
        public class Demo
        {
            public static void main()
            {
                ShapeFactory shapeFactory = new ShapeFactory();
                Shape shape1 = shapeFactory.GetShape("Square");
                shape1.draw();
            }
        }
    }
}
