using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryFormulas
{
    class AreaCalculation
    {
    
        public AreaCalculation()
        {
        }

        public int Side { get; set; }

        public int Length { get; set; }

        public int Width { get; set; }

        public int TriangleBase { get; set; }

        public int TriangleHeigth { get; set; }

        public int TrapezoidFirstBase { get; set; }

        public int TrapezoidSecondBase { get; set; }

        public int TrapezoidHeigth { get; set; }

        public int Radius { get; set; }

        public void SquareArea()
        {
            Console.WriteLine("\tSquare Area Calculation\n" +
                "==================================================\n" +
                "Enter the side: ");
            Side = int.Parse(Console.ReadLine());
            int squareArea = Side * Side;
            Console.WriteLine("The area of the square is: " +
                squareArea.ToString() + "\n" +
                "==================================================\n");
            
            Console.WriteLine("Do you wish to make another calculation?(y/n)");
            string answer = Console.ReadLine();

            //handling any wrong input
            while (answer != "y" && answer != "n")
            {
                Console.WriteLine("Wrong input, enter 'y' or 'n'.");
                answer = Console.ReadLine();
            }
            if (answer == "y")
            {
                SquareArea();
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

        public void RectangleArea()
        {
            Console.WriteLine("\tRectangle Area Calculation\n" +
                "==================================================\n" +
                "Enter the length: ");
            Length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width: ");
            Width = int.Parse(Console.ReadLine());
            int rectangleArea = Length * Width;
            Console.WriteLine("The area of the rectangle is: " + 
                rectangleArea.ToString() + "\n" +
                "==================================================\n");

            Console.WriteLine("Do you wish to make another calculation?(y/n)");
            string answer = Console.ReadLine();

            //handling any wrong input
            while (answer != "y" && answer != "n")
            {
                Console.WriteLine("Wrong input, enter 'y' or 'n'.");
                answer = Console.ReadLine();
            }
            if (answer == "y")
            {
                RectangleArea();
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

        public void TriangleArea()
        {
            Console.WriteLine("Triangle Area Calculation\n" +
                "==================================================\n" + 
                "Enter the base: ");
            TriangleBase = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the heigth: ");
            TriangleHeigth = int.Parse(Console.ReadLine());
            int triangleArea = (1 / 2) * TriangleBase * TriangleHeigth;
            Console.WriteLine("The area of the triangle is: " +
                triangleArea.ToString() + "\n" +
                "==================================================\n");

            Console.WriteLine("Do you wish to make another calculation?(y/n)");
            string answer = Console.ReadLine();

            //handling any wrong input
            while (answer != "y" && answer != "n")
            {
                Console.WriteLine("Wrong input, enter 'y' or 'n'.");
                answer = Console.ReadLine();
            }
            if (answer == "y")
            {
                TriangleArea();
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

        public void TrapezoidArea()
        {
            Console.WriteLine("Trapezoid Area Calculation\n" +
                "==================================================\n" +
                "Enter the first base: ");
            TrapezoidFirstBase = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second base: ");
            TrapezoidSecondBase = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the heigth: ");
            TrapezoidHeigth = int.Parse(Console.ReadLine());
            int trapezoidArea = (1 / 2) * (TrapezoidFirstBase + TrapezoidSecondBase) * TrapezoidHeigth;
            Console.WriteLine("The area of the trapezoid is: " +
                trapezoidArea.ToString() + "\n" +
                "==================================================\n");

            Console.WriteLine("Do you wish to make another calculation?(y/n)");
            string answer = Console.ReadLine();

            //handling any wrong input
            while (answer != "y" && answer != "n")
            {
                Console.WriteLine("Wrong input, enter 'y' or 'n'.");
                answer = Console.ReadLine();
            }
            if (answer == "y")
            {
                TrapezoidArea();
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

        public void CircleArea()
        {
            Console.WriteLine("Circle Area Calculation\n" +
                "==================================================\n" +
                "Enter the radius: ");
            Radius = int.Parse(Console.ReadLine());
            int circleArea = 3 * Radius * Radius;
            Console.WriteLine("The area of the circle is: " +
                circleArea.ToString() + "\n" +
                "==================================================\n");

            Console.WriteLine("Do you wish to make another calculation?(y/n)");
            string answer = Console.ReadLine();

            //handling any wrong input
            while (answer != "y" && answer != "n")
            {
                Console.WriteLine("Wrong input, enter 'y' or 'n'.");
                answer = Console.ReadLine();
            }
            if (answer == "y")
            {
                CircleArea();
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
