using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPShapeCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dylan Veasey
            //11.03.2020 - 12.03.2020
            Decision Decision1 = new Decision();
            Decision1.GetInput();
        }
        public class Decision
        {
            private int _userInput;
            public int UserInput
            {
                get { return _userInput; }
            }
            public void GetInput()
            {
                Console.WriteLine("Please enter what shape you would like to calculate");
                Console.WriteLine("1)Circle");
                Console.WriteLine("2)Rectangle");
                Console.WriteLine("3)Right-angled triangle");
                _userInput = Int32.Parse(Console.ReadLine());
                this.Decide();
            }
            public void Decide()
            {
                if(_userInput == 1)
                {
                    Circle circ1 = new Circle();
                    circ1.SetRadius();
                    circ1.CalculateArea();
                    circ1.CalculatePerimeter();
                    circ1.OutputSize();
                }else if(_userInput == 2)
                {
                    Rectangle rect1 = new Rectangle();
                    rect1.SetLength();
                    rect1.SetWidth();
                    rect1.CalculatePerimeter();
                    rect1.CalculateArea();
                    rect1.OutputSize();
                }
                else if(_userInput == 3)
                {
                    Triangle tri1 = new Triangle();
                    tri1.SetBase();
                    tri1.SetHeight();
                    tri1.CalculateArea();
                    tri1.CalulatePerimeter();
                    tri1.OutputSize();
                }
                else
                {
                    Console.WriteLine("Please enter 1,2 or 3!");
                }
            }
        }
        public class Rectangle
        {
            //Declares private variables for each of the properties of a rectangle
            private int _rectArea;
            private int _rectLength;
            private int _rectWidth;
            private int _rectPerimeter;

            //Declares public variables for each of the properites of a rectangle
            public int RectWidth
            {
                get { return _rectWidth; }
            }
            public int RectLength
            {
                get { return _rectLength; }
            }
            public int RectArea
            {
                get { return _rectArea; }

            }
            public int RectPerimeter
            {
                get { return _rectPerimeter; }
            }

            //Method for calculating the area of a rectangle
            public void CalculateArea()
            {
                _rectArea = _rectLength * _rectWidth;
            }

            //Method for calculating the perimeter of a rectangle
            public void CalculatePerimeter()
            {
                _rectPerimeter = (_rectLength * 2) + (_rectWidth * 2);
            }

            //Method for getting the value of the width of a rectangle from the user
            public void SetWidth()
            {
                Console.WriteLine("Please enter the width of the rectangle:");
                _rectWidth = Int32.Parse(Console.ReadLine());
            }

            //Method for getting the value of the length of a rectangle from the user
            public void SetLength()
            {
                Console.WriteLine("Please enter the length of the rectangle:");
                _rectLength = Int32.Parse(Console.ReadLine());
            }

            //Method for outputing the values of the rectangle
            public void OutputSize()
            {
                Console.WriteLine($"The rectangle has a width of {_rectWidth} and a length of {_rectLength}, an area of {_rectArea} and a perimeter of {_rectPerimeter}.");
                Console.ReadLine();
            }
        }
        public class Circle
        {

            //Declares private variables for each of the properties of a circle
            private double _circArea;
            private double _circRadius;
            private double _circPerimeter;

            //Declares public variables for each of the properties of a circle
            public double circRadius
            {
                get { return _circRadius; }
            }
            public double circArea
            {
                get { return _circArea; }
            }
            public double circPerimeter
            {
                get { return _circPerimeter; }
            }

            //Method for calculating the area of a circle
            public void CalculateArea()
            {
                _circArea = Math.Round(Math.PI * Math.Pow(_circRadius, 2), 2);
            }

            //Method for calculating the perimeter of a circle
            public void CalculatePerimeter()
            {
                _circPerimeter = Math.Round(Math.PI * (_circRadius * 2), 2);
            }

            //Method for getting the value of the radius of a circle from the user
            public void SetRadius()
            {
                Console.WriteLine("Please enter the radius of the circle:");
                _circRadius = Int32.Parse(Console.ReadLine());
            }

            //Method for outputing the values of the circle
            public void OutputSize()
            {
                Console.WriteLine($"The circle has a radius of {_circRadius}, an area of {_circArea} and a perimeter of {_circPerimeter}");
                Console.ReadLine();
            }
        }
        public class Triangle
        {
            //Declares private variable for each property of the triangle
            private double _triArea;
            private double _triBase;
            private double _triHeight;
            private double _triPerimeter;


            //Declares public variables for the area and perimeter of the triangle
            public double TriArea
            {
                get { return _triArea; }
            }
            public double TriPerimeter
            {
                get { return _triPerimeter; }
            }


            //Method for calculating the area of the triangle
            public void CalculateArea()
            {
                _triArea = Math.Round(((_triBase * _triHeight) / 2), 2);
            }
        
            //Method for calculating the perimeter of the triangle
            public void CalulatePerimeter()
            {
                _triPerimeter = Math.Round((_triBase + _triHeight + (Math.Sqrt(Math.Pow(_triBase, 2) + (Math.Pow(_triHeight, 2))))), 2);
            }

            //Method for getting the value for the base of the triangle from the user
            public void SetBase()
            {
                Console.WriteLine("Please enter the base of the triangle");
                _triBase = Int32.Parse(Console.ReadLine());
            }

            //Method for getting the value for the height of the triangle from the user
            public void SetHeight()
            {
                Console.WriteLine("Please enter the height of the triangle");
                _triHeight = Int32.Parse(Console.ReadLine());
            }

            //Method for outputing the values of the triangle
            public void OutputSize()
            {
                Console.WriteLine($"The triangle has a base of {_triBase}, a height of {_triHeight}, an area of {_triArea} and a perimeter of {_triPerimeter}");
                Console.ReadLine();
            }
        }
    }
}
