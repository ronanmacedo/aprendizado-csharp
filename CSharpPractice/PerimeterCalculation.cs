using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryFormulas
{
    class PerimeterCalculation
    {
        public PerimeterCalculation()
        {
        }

        public int Side { get; set; }

        public int Length { get; set; }

        public int Width { get; set; }

        public void SquarePerimeter()
        {
            //Create the menu for the user input
            Console.WriteLine("\tSquare Perimeter Calculation\n" +
                "==================================================\n" +
                "Enter the side: ");
            Side = int.Parse(Console.ReadLine());
            int squarePerimeter = 4 * Side;
            Console.WriteLine("The perimeter of the square is: " +
                squarePerimeter.ToString() + "\n" +
                "==================================================\n");
            Console.WriteLine("Do you wish to make another calculation?(y/n)");
            string answer = Console.ReadLine();
            
            //handling any wrong input
            while(answer != "y" && answer != "n")
            {
                Console.WriteLine("Wrong input, enter 'y' or 'n'.");
                answer = Console.ReadLine();
            }
            if(answer == "y")
            {
                SquarePerimeter();
            }
            else if(answer == "n")
            {
                Console.WriteLine("Do you would like to back to main menu?(y/n)");
                answer = Console.ReadLine();
                
                while (answer != "y" && answer != "n")
                {
                    Console.WriteLine("Wrong input, enter 'y' or 'n'.");
                    answer = Console.ReadLine();
                }

                if(answer == "y")
                {
                    Menu menu = new Menu();
                    menu.MainMenu();
                }
                else if(answer == "n")
                {
                    Console.WriteLine("Goodbye!");
                }
            }
        }

        public void RectanglePerimeter()
        {
            Console.WriteLine("\tRectangle Perimeter Calculation\n" +
                "==================================================\n" +
                "Enter the length: ");
            Length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width: ");
            Width = int.Parse(Console.ReadLine());
            int rectanglePerimeter = 2 * (Length + Width);
            Console.WriteLine("The perimeter of the rectangle is: " +
                rectanglePerimeter.ToString() + "\n" +
                "==================================================\n");
            Console.WriteLine("Do you wish to make another calculation?(y/n)");
            string answer = Console.ReadLine();
            while (answer != "y" && answer != "n")
            {
                Console.WriteLine("Wrong input, enter 'y' or 'n'.");
                answer = Console.ReadLine();
            }
            if (answer == "y")
            {
                RectanglePerimeter();
            }
            else if (answer == "n")
            {
                Console.WriteLine("Do you would like to back to main menu?(y/n)");
                answer = Console.ReadLine();

                while (answer != "y" && answer != "n")
                {
                    Console.WriteLine("Wrong input, enter 'y' or 'n'.");
                    answer = Console.ReadLine();
                }

                if (answer == "y")
                {
                    Menu menu = new Menu();
                    menu.MainMenu();
                }
                else if (answer == "n")
                {
                    Console.WriteLine("Goodbye!");
                }
            }
        }
    }
}
