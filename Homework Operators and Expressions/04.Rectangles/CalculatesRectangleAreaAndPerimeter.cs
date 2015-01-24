/*
 * Problem 4. Rectangles
Write an expression that calculates rectangle’s perimeter and area by given width and height.
Examples:
width	height	perimeter	area
3	    4	    14	        12
2.5	    3	    11	        7.5
5	    5	    20	        25
 */


using System;
    class CalculatesRectangleAreaAndPerimeter
    {
        static void Main()
        {
            Console.WriteLine("This program calculates area and perimeter of rectangle.");
            Console.Write("Enter width: ");

            double width;
            bool ValidWidth = double.TryParse(Console.ReadLine(), out width);
            while (width <= 0 || ValidWidth == false)
            {
                Console.Write("Error. Enter valid number > 0. Try again: ");
                ValidWidth = double.TryParse(Console.ReadLine(), out width);
            }

            Console.Write("Enter height: ");
            double height;
            bool ValidHeight = double.TryParse(Console.ReadLine(), out height);
            while (height <= 0 || ValidHeight == false)
            {
                Console.Write("Error. Enter valid number > 0. Try again: ");
                ValidHeight = double.TryParse(Console.ReadLine(), out height);
            }

            double perimeter = 2 * (width + height);
            double area = width * height;

            Console.WriteLine("The perimetr of the rectangle is: {0} ", perimeter);
            Console.WriteLine("The area of the rectangle is: {0} ", area);
        }
    }
