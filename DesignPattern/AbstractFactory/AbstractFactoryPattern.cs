using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    class AbstractFactoryPattern
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
        /// 顏色介面
        /// </summary>
        public interface Color
        {
            void fill();
        }

        public class Red : Color
        {
            public void fill()
            {
                Console.WriteLine("Fill red.");
            }
        }

        public class Blue : Color
        {
            public void fill()
            {
                Console.WriteLine("Fill blue.");
            }
        }

        /// <summary>
        /// 抽象工廠
        /// </summary>
        public abstract class AbstractFactory
        {
            public abstract Color getColor(string colorName);
            public abstract Shape getShape(string shapeName);
        }

        /// <summary>
        /// 圖形工廠
        /// </summary>
        public class ShapeFactory : AbstractFactory
        {
            public override Shape getShape(string shapeName)
            {
                switch (shapeName)
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
            public override Color getColor(String colorName)
            {
                return null;
            }
        }

        /// <summary>
        /// 顏色工廠
        /// </summary>
        public class ColorFactory : AbstractFactory
        {
            public override Shape getShape(string shapeName)
            {
                return null;
            }
            public override Color getColor(String colorName)
            {
                switch (colorName)
                {
                    case "Red":
                        return new Red();
                    case "Blue":
                        return new Blue();
                    default:
                        return null;
                }
            }
        }

        /// <summary>
        /// 工廠生成
        /// 通過傳入參數類型來獲取不同工廠
        /// </summary>
        public class FactoryProducer
        {
            public static AbstractFactory getFactory(string option)
            {
                switch (option)
                {
                    case "Shape":
                        return new ShapeFactory();
                    case "Color":
                        return new ColorFactory();
                    default:
                        return null;
                }
            }
        }
        public class Demo
        {
            public static void main()
            {
                AbstractFactory shapeFactory = FactoryProducer.getFactory("Shape");
                Shape shape1 = shapeFactory.getShape("Square");
                shape1.draw();

                AbstractFactory colorFactory = FactoryProducer.getFactory("Color");
                Color color1 = colorFactory.getColor("Blue");
                color1.fill();
            }
        }
    }
}
