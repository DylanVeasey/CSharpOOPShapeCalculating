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
                Console.WriteLine("3)Triangle");
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
            //This is a private variable for the number of sides
            private int _numberOfSides = 4;

            //This is a private variable for area of the rectangle
            private int _rectArea;

            //This is a private variable for the length of the reactangle
            private int _rectLength;

            //This is a private variable for the width of the rectangle
            private int _rectWidth;

            //This is a private variable for the perimeter of the rectangle
            private int _rectPerimeter;

            //This is a public variable for the width of the rectangle
            public int RectWidth
            {
                //allows you to get the private variable and return it to the outside world
                get { return _rectWidth; }
            }

            //This is a public variable for the length of the rectangle
            public int RectLength
            {
                //allows you to get the private variable and return it to the outside world
                get { return _rectLength; }
            }

            //This is a public variable for the area of the rectangle
            public int RectArea
            {
                //allows you to get the private variable and return it to the outside world
                get { return _rectArea; }

            }

            //This is a public variable for the perimeter of the rectangle
            public int RectPerimeter
            {
                //allows you to get the private variable and return it to the outside world
                get { return _rectPerimeter; }
            }

            //This is a public function to calculate the area of the rectangle
            public void CalculateArea()
            {
                _rectArea = _rectLength * _rectWidth;
            }

            //This is a public function to calculate the perimeter of the rectangle
            public void CalculatePerimeter()
            {
                _rectPerimeter = (_rectLength * 2) + (_rectWidth * 2);
            }

            public void SetWidth()
            {
                Console.WriteLine("Please enter the width of the rectangle:");
                _rectWidth = Int32.Parse(Console.ReadLine());
            }

            public void SetLength()
            {
                Console.WriteLine("Please enter the length of the rectangle:");
                _rectLength = Int32.Parse(Console.ReadLine());
            }

            public void OutputSize()
            {
                Console.WriteLine($"The rectangle has a width of {_rectWidth} and a length of {_rectLength}, an area of {_rectArea} and a perimeter of {_rectPerimeter}.");
                Console.ReadLine();
            }
        }
        public class Circle
        {

            //This is a private variable for area of the circle
            private double _circArea;

            //This is a private variable for the length of the circle
            private double _circRadius;

            //This is a private variable for the perimeter of the circle
            private double _circPerimeter;

            //This is a public variable for the width of the circle
            public double circRadius
            {
                //allows you to get the private variable and return it to the outside world
                get { return _circRadius; }
            }

            //This is a public variable for the area of the circle
            public double circArea
            {
                //allows you to get the private variable and return it to the outside world
                get { return _circArea; }
            }

            //This is a public variable for the perimeter of the circle
            public double circPerimeter
            {
                //allows you to get the private variable and return it to the outside world
                get { return _circPerimeter; }
            }

            //This is a public function to calculate the area of the circle
            public void CalculateArea()
            {
                _circArea = Math.Round(Math.PI * Math.Pow(_circRadius, 2), 2);
            }

            //This is a public function to calculate the perimeter of the circle
            public void CalculatePerimeter()
            {
                _circPerimeter = Math.Round(Math.PI * (_circRadius * 2), 2);
            }


            public void SetRadius()
            {
                Console.WriteLine("Please enter the radius of the circle:");
                _circRadius = Int32.Parse(Console.ReadLine());
            }

            public void OutputSize()
            {
                Console.WriteLine($"The circle has a radius of {_circRadius}, an area of {_circArea} and a perimeter of {_circPerimeter}");
                Console.ReadLine();
            }
        }
        public class Triangle
        {
            private double _triArea;

            private double _triBase;

            private double _triHeight;

            private double _triPerimeter;

            public double TriArea
            {
                get { return _triArea; }
            }

            public double TriPerimeter
            {
                get { return _triPerimeter; }
            }

            public void CalculateArea()
            {
                _triArea = Math.Round(((_triBase * _triHeight) / 2), 2);
            }

            public void CalulatePerimeter()
            {
                _triPerimeter = Math.Round((_triBase + _triHeight + (Math.Sqrt(Math.Pow(_triBase, 2) + (Math.Pow(_triHeight, 2))))), 2);
            }

            public void SetBase()
            {
                Console.WriteLine("Please enter the base of the triangle");
                _triBase = Int32.Parse(Console.ReadLine());
            }

            public void SetHeight()
            {
                Console.WriteLine("Please enter the height of the triangle");
                _triHeight = Int32.Parse(Console.ReadLine());
            }

            public void OutputSize()
            {
                Console.WriteLine($"The triangle has a base of {_triBase}, a height of {_triHeight}, an area of {_triArea} and a perimeter of {_triPerimeter}");
                Console.ReadLine();
            }
        }
    }
}
