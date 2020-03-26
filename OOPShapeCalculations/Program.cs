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
            //11.03.2020 - 14.03.2020
            //Simple C# program that calulates the area and perimeter of shapes using the object oriented programming paradigm.
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
                Console.WriteLine("4)Equilateral or isosceles traingle");
                Console.WriteLine("5)Regular Polygon");
                try
                {
                    _userInput = Int32.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a number!");
                    this.GetInput();
                }
                this.Decide();
            }
            public void Decide()
            {
                switch(_userInput)
                {
                    case 1:
                    Circle circ1 = new Circle();
                    circ1.SetRadius();
                    circ1.CalculateArea();
                    circ1.CalculatePerimeter();
                    circ1.OutputSize();
                       break;
                    case 2:
                    Rectangle rect1 = new Rectangle();
                    rect1.SetLength();
                    rect1.SetWidth();
                    rect1.CalculateArea();
                    rect1.CalculatePerimeter();
                    rect1.OutputSize();
                        break;
                    case 3:
                    RATriangle ratri1 = new RATriangle();
                    ratri1.SetBase();
                    ratri1.SetHeight();
                    ratri1.CalculateArea();
                    ratri1.CalulatePerimeter();
                    ratri1.OutputSize();
                        break;
                    case 4:
                    EQTriangle eqtri1 = new EQTriangle();
                    eqtri1.SetBase();
                    eqtri1.SetHeight();
                    eqtri1.CalculateArea();
                    eqtri1.CalulatePerimeter();
                    eqtri1.OutputSize();
                        break;
                    case 5:
                    RegPolygon regpolygon1 = new RegPolygon();
                    regpolygon1.GetNumberOfSides();
                    regpolygon1.GetSideLength();
                    regpolygon1.CalculatePerimeter();
                    regpolygon1.CalculateArea();
                    regpolygon1.OutputSize();
                        break;
                    default:
                    Console.WriteLine("Please enter a number from 1 to 5!");
                        this.GetInput();
                        break;
                }
            }
        }
         public class Circle
        {
            //Declares private variables for each of the properties of a circle
            private double _circArea;
            private int _circRadius;
            private double _circPerimeter;

            //Declares public variables for each of the properties of a circle
            public int circRadius
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

            //Method for getting the value of the radius of a circle from the user
            public void SetRadius()
            {
                Console.WriteLine("Please enter the radius of the circle:");
                Validate Validation1 = new Validate();
                _circRadius = Validation1.ValidateInput();
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

            //Method for outputing the values of a circle
            public void OutputSize()
            {
                Console.WriteLine($"The circle has a radius of {_circRadius}, an area of {_circArea} and a perimeter of {_circPerimeter}");
                Console.ReadLine();
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

            //Method for getting the value of the length of a rectangle from the user
            public void SetLength()
            {
                Console.WriteLine("Please enter the length of the rectangle:");
                Validate Validation1 = new Validate();
                _rectLength = Validation1.ValidateInput();               
            }

             //Method for getting the value of the width of a rectangle from the user
            public void SetWidth()
            {
                Console.WriteLine("Please enter the width of the rectangle:");
                Validate Validation1 = new Validate();
                _rectWidth = Validation1.ValidateInput();
            }

            //Method for calculating the perimeter of a rectangle
            public void CalculatePerimeter()
            {
                _rectPerimeter = (_rectLength * 2) + (_rectWidth * 2);
            }

            //Method for calculating the area of a rectangle
            public void CalculateArea()
            {
                _rectArea = _rectLength * _rectWidth;
            }

            //Method for outputing the values of a rectangle
            public void OutputSize()
            {
                Console.WriteLine($"The rectangle has a width of {_rectWidth} and a length of {_rectLength}, an area of {_rectArea} and a perimeter of {_rectPerimeter}.");
                Console.ReadLine();
            }
        }
        public class RATriangle
        {
            //Declares private variable for each property of a triangle
            private double _raTriArea;
            private int _raTriBase;
            private int _raTriHeight;
            private double _raTriPerimeter;


            //Declares public variables for the area and perimeter of a triangle
            public double raTriArea
            {
                get { return _raTriArea; }
            }
            public double raTriPerimeter
            {
                get { return _raTriPerimeter; }
            }

            //Method for getting the value for the base of the triangle from the user
             public void SetBase()
            {
                Console.WriteLine("Please enter the base of the triangle");
                Validate Validation1 = new Validate();
                _raTriBase = Validation1.ValidateInput();
            }

            //Method for getting the value for the height of the triangle from the user
            public void SetHeight()
            {
                Console.WriteLine("Please enter the height of the triangle");
                Validate Validation1 = new Validate();
                _raTriHeight = Validation1.ValidateInput();     
            }

            //Method for calculating the area of a triangle
            public void CalculateArea()
            {
                _raTriArea = Math.Round(((_raTriBase * _raTriHeight) / 2.0), 2);
            }
        
            //Method for calculating the perimeter of a triangle
            public void CalulatePerimeter()
            {
                _raTriPerimeter = Math.Round((_raTriBase + _raTriHeight + (Math.Sqrt(Math.Pow(_raTriBase, 2) + (Math.Pow(_raTriHeight, 2))))), 2);
            }

            //Method for outputing the values of a triangle
            public void OutputSize()
            {
                Console.WriteLine($"The right-angled triangle has a base of {_raTriBase}, a height of {_raTriHeight}, an area of {_raTriArea} and a perimeter of {_raTriPerimeter}");
                Console.ReadLine();
            }
        }
        public class EQTriangle
        {
            //Declares private variable for each property of a triangle
            private double _eqTriArea;
            private int _eqTriBase;
            private int _eqTriHeight;
            private double _eqTriPerimeter;


            //Declares public variables for the area and perimeter of a triangle
            public double eqTriArea
            {
                get { return _eqTriArea; }
            }
            public double eqTriPerimeter
            {
                get { return _eqTriPerimeter; }
            }
            public int eqTriBase
            {
                get { return _eqTriBase; }
            }          
            public int eqTriHeight
            {
                get { return _eqTriHeight; }
            }   

            //Method for getting the value for the base of the triangle from the user
            public void SetBase()
            {
                Console.WriteLine("Please enter the base of the triangle");
                Validate Validation1 = new Validate();
                _eqTriBase = Validation1.ValidateInput();
            }      

             //Method for getting the value for the height of the triangle from the user
            public void SetHeight()
            {
                Console.WriteLine("Please enter the height of the triangle");
                Validate Validation1 = new Validate();
                _eqTriHeight = Validation1.ValidateInput();
            }          

            //Method for calculating the area of a triangle
            public void CalculateArea()
            {
                _eqTriArea = Math.Round(((_eqTriBase * _eqTriHeight) / 2.0), 2);
            }

            //Method for calculating the perimeter of a triangle
            public void CalulatePerimeter()
            {
                _eqTriPerimeter = Math.Round(_eqTriBase +  ((Math.Sqrt((Math.Pow(_eqTriBase, 2) + 4* (Math.Pow(_eqTriHeight, 2))) ) ) ), 2);

            }
        
            //Method for outputing the values of a triangle
            public void OutputSize()
            {
                Console.WriteLine($"The triangle has a base of {_eqTriBase}, a height of {_eqTriHeight}, an area of {_eqTriArea} and a perimeter of {_eqTriPerimeter}");
                Console.ReadLine();
            }
        }
        public class RegPolygon
        {
            //Declares private variables for each property of a regular polygon
            private int _numberOfSides;
            private int _regPolygonSide;
            private double _regPolygonArea;
            private double _regPolygonPerimeter;

            //Declare public variables for each property of a regular polygon
            public int NumberOfSides
            {
                get { return _numberOfSides; }
            }
            public int RegPolygonSide
            {
                get { return _regPolygonSide; }
            }
            public double RegPolgonArea
            {
                get { return _regPolygonArea; }
            }
            public double RegPolygonPerimeter
            {
                get { return _regPolygonPerimeter; }
            }

            //Method for getting the value for the number of sides of a regular polygon from the user
            public void GetNumberOfSides()
            {
                Console.WriteLine("How many sides does the regular polygon have?");
                try
                {
                    _numberOfSides = Int32.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a number!");
                    this.GetNumberOfSides();
                }
                //Validation to check that the number of sides of a regular polygon is more than 2.
                if (_numberOfSides < 3 )
                {
                    Console.WriteLine("Please enter a number greater than 2!");
                    this.GetNumberOfSides();
                }  
            }

            //Method for getting the value of the length of the side of a regular polygon from the user
            public void GetSideLength()
            {
                Console.WriteLine("What is the length of one side?");
                Validate Validation1 = new Validate();
                _regPolygonSide = Validation1.ValidateInput();
            } 

            //Method for calculating the value of the area of a regular polygon
            public void CalculateArea()
            {
                //The regular polygon is equal to...
                _regPolygonArea = 
                //Rounds the number
                Math.Round((((
                //The apothem of a regular polygon is the shortest distance from the center point to one of the sides, creating a right angle.
                //The formula for calculating the length of the apothem is this: the length of the side (_regPolygonSide) divided by 2 times the tangent of 180 degrees divided by the number of sides (_numberOfSides).
                // * Math.PI/180 converts it to radians which is needed when using Math.Tan()
                _regPolygonSide / ((Math.Tan((180 / _numberOfSides)* Math.PI / 180)) *2))
                //Area = (a x p)/2, where a is the length of the apothem (calculated in the last line) and p is the perimeter of the polygon (_regPolygonPerimeter).
                * _regPolygonPerimeter) / 2)
                //This defines how many decimal places the answer will be rounded to.
                , 2);
            } 

            //Method for calculating the value of the perimeter of a regular polygon
            public void CalculatePerimeter()
            {
                _regPolygonPerimeter = _regPolygonSide * _numberOfSides;
            }

            //Method for outputing the values of a regular polygon
            public void OutputSize()
            {
                Console.WriteLine($"The regular polygon has {_numberOfSides} sides, a side length of {_regPolygonSide}, a perimeter of {_regPolygonPerimeter} and an area of {_regPolygonArea}");
                Console.ReadLine();
            }
        }
        //A class to Validate inputs
        public class Validate
        {
            //A public method to validate the user inputs
            public int ValidateInput()
            {
                 //Declares two variables to be used in the method
                 int UserInput = 0;
                 bool IsValid = false;
                 //Validation to check that the input from the user is an integer and above 0
                 while(IsValid ==  false)
                 {
                    try
                    {
                        UserInput = Int32.Parse(Console.ReadLine());
                        if (UserInput <= 0 )
                        {
                            Console.WriteLine("Please enter a number greater than 0!");
                        }
                        else
                        {
                            //Exits out of the validation while loop if the criteria for a valid input is met
                            IsValid = true;
                        }
                    }
                    catch (Exception)
                    {
                    Console.WriteLine("Please enter a number!");
                    }
                 }  
                 return UserInput;
            }     
        }
    }
}
