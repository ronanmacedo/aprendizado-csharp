using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryFormulas
{
    class CircumferanceCalculation
    {
        public CircumferanceCalculation()
        {
        }

        public int Radius { get; set; }

        public void CircleCircumferance()
        {
            Console.WriteLine("\tCircle Circumferance Calculation\n" +
            "==================================================\n" +
            "Enter the radius: ");
            Radius = int.Parse(Console.ReadLine());
            int circleCircumferance =  2 * 3 * Radius;
            Console.WriteLine("The circumferance of the circle is: " +
                circleCircumferance.ToString() + "\n" +
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
                CircleCircumferance();
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
