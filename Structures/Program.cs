using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Structures
{
    public class Program
    {
       

        public static double objectLength;
        public static double objectWidth;
        public static double objectHypo;
        public static Shape newShape = null;
        public static Shape otherShape = null;
        public static ResizeableRectangle newResize = null;
        public static Shape _temp;
        public static Shape _temp2;
        public static Shape _temp3;
        public static double length;
        public static double width;
        public static List<Shape> shapestorage = new List<Shape>();

        public static void ViewShapeInfo(Shape shape)
        {                      
            Console.WriteLine(shape.ToString());
        }

        public static void resizeRectangle()
        {
            try {
                Console.WriteLine("\n" + "Add new length:");
                length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Add new width:");
                width = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\n" + "Enter the percentage by which you want to increase the object with: ");
                int value = Convert.ToInt32(Console.ReadLine());



                IResizeable resizeRect = _temp as IResizeable;//new ResizeableRectangle(length, width);
                                                              //if(resizeRect != null)
                resizeRect.resize(value);

                Console.WriteLine("The new size of the object is: ");
                Console.WriteLine(resizeRect);
            }
            catch
            {
                Console.WriteLine("Error! Try again");
                resizeRectangle();
            }
        }


        public static void Main(string[] args)
        {

            {
                int menuSelection = 0;
                try
                {
                
                    
                    while(menuSelection != 9)
                    {

                        Console.WriteLine("Please choose by entering a number");
                        Console.WriteLine("1. Rectangle");
                        Console.WriteLine("2. Ellipse");
                        Console.WriteLine("3. Compare two objects");
                        Console.WriteLine("\n" + "9. Exit");


                        {
                            int menuChoice = (Convert.ToInt32(Console.ReadLine()));
                            
                            
                                switch (menuChoice)

                                {
                                    case 1:
                                        {
                                            Console.WriteLine("Enter the length: ");
                                            objectLength = Convert.ToDouble(Console.ReadLine());

                                            Console.WriteLine("Enter the width: ");
                                            objectWidth = Convert.ToDouble(Console.ReadLine());

                                            newShape = CreateShape(ShapeType.Rectangle);
                                            ViewShapeInfo(newShape);

                                            Console.WriteLine("\n" + "Do you want to resize it? (Y/N)");
                                            var answer = Console.ReadKey(true);
                                            if (answer.KeyChar == 'y')
                                            {
                                                resizeRectangle();
                                            }
                                            if (answer.KeyChar == 'n')
                                        {
                                            menuSelection = 9;
                                        }
                                            
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.WriteLine("Enter the length: ");
                                            objectLength = Convert.ToDouble(Console.ReadLine());
                                            Console.WriteLine("Enter the width: ");
                                            objectWidth = Convert.ToDouble(Console.ReadLine());
                                            newShape = CreateShape(ShapeType.Ellipse);
                                            ViewShapeInfo(newShape);

                                        menuSelection = 0;
                                            break;
                                        }
                                    case 3:
                                    {
                                        Console.WriteLine("\n" + "Create a rectangle");
                                        Console.WriteLine("Enter the length: ");
                                        objectLength = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("Enter the width: ");
                                        objectWidth = Convert.ToDouble(Console.ReadLine());
                                        newShape = CreateShape(ShapeType.Rectangle);

                                        Console.WriteLine("Create an ellipse");
                                        Console.WriteLine("Enter the length: ");
                                        objectLength = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("Enter the width: ");
                                        objectWidth = Convert.ToDouble(Console.ReadLine());
                                        otherShape = CreateShape(ShapeType.Ellipse);

                                        while (_temp.Area != 0 || _temp2.Area != 0)
                                        {
                                            if (_temp.Area.CompareTo(_temp2.Area) == 0)
                                            {
                                                Console.WriteLine("The objects have the same area!");
                                                break;
                                            }
                                            if (_temp.Area.CompareTo(_temp2.Area) == 1)
                                            {
                                                Console.WriteLine("The area of the rectangle is bigger");
                                                break;
                                            }
                                            else if (_temp.Area.CompareTo(_temp2.Area) == -1)
                                            {
                                                Console.WriteLine("The area of the rectangle is smaller");
                                                break;
                                            }

                                            else
                                            {
                                                Console.WriteLine("Nope");
                                            }

                                            
                                        }
                                        break;
                                    }
                                case 5:
                                    {
                                        Console.WriteLine("Enter the length: ");
                                        objectLength = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("Enter the width: ");
                                        objectWidth = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("Enter the Hypo: ");
                                        objectHypo = Convert.ToDouble(Console.ReadLine());
                                        newShape = CreateShape(ShapeType.Triangle);
                                        ViewShapeInfo(newShape);

                                        menuSelection = 0;
                                        break;
                                    }

                                case 9:
                                    {
                                        Console.WriteLine("Goodbye!");
                                        Environment.Exit(0);
                                        break;
                                    }

                                default:
                                    Console.WriteLine("\n" + "Your selection is invalid, plz try again"+ "\n");                                    
                                    break;
                                    
                                        
                                        
                                }
                        }

                    }
                }

                catch
                {
                    Console.WriteLine("Error!");
                    

                }
                
            }
            Console.ReadKey();
        }

        public static Shape CreateShape(ShapeType shape)
        {


            if (shape == ShapeType.Rectangle)
            {
                Shape rectAngle = new Rectangle(objectLength, objectWidth, objectHypo);
                _temp = rectAngle;
                return rectAngle;
            }

            else if (shape == ShapeType.Ellipse)
            {
                Shape theEllipse = new Ellipse(objectLength, objectWidth, objectHypo);
                _temp2 = theEllipse;
                return theEllipse;
            }
            else if (shape == ShapeType.Triangle)
            {
                Shape theTriangle = new Triangle(objectLength, objectWidth, objectHypo);
                _temp3 = theTriangle;
                return theTriangle;
            }
            else
                return null;
        }


    }
}