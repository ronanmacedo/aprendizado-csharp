using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryFormulas
{
    class SurfaceAreaCalculation
    {

        public SurfaceAreaCalculation()
        {
        }

        public int Side { get; set; }

        public int CylinderRadius { get; set; }

        public int CylinderHeigth { get; set; }

        public int ConeRadius { get; set; }

        public int ConeLength { get; set; }

        public int SphereRadius { get; set; }

        public void CubeSurface()
        {
            Console.WriteLine("\tCube Surface Area Calculation\n" +
                "==================================================\n" +
                "Enter the side: ");
            Side = int.Parse(Console.ReadLine());
            int cubeSurface = 6 * Side * Side;
            Console.WriteLine("The surface area of the cube is: " +
                cubeSurface.ToString() + "\n" +
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
                CubeSurface();
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

        public void CylinderSurface()
        {
            Console.WriteLine("\tCylinder Surface Area Calculation\n" +
                "==================================================\n" +
                "Enter the radius: ");
            CylinderRadius = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the heigth: ");
            CylinderHeigth = int.Parse(Console.ReadLine());
            int cylinderSurface = 2 * 3 * CylinderRadius * CylinderHeigth + 2 * 3 * CylinderRadius * CylinderRadius;
            Console.WriteLine("The surface area of the cylinder is: " +
                cylinderSurface.ToString() + "\n" +
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
                CylinderSurface();
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

        public void ConeSurface()
        {
            Console.WriteLine("\tCone Surface Area Calculation\n" +
                "==================================================\n" +
                "Enter the radius: ");
            ConeRadius = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length");
            ConeLength = int.Parse(Console.ReadLine());
            int coneSurface = 3 * ConeRadius * ConeLength;
            Console.WriteLine("The surface area of the cone is: " +
                coneSurface.ToString() + "\n" +
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
                ConeSurface();
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

        public void SphereSurface()
        {
            Console.WriteLine("\tSphere Surface Area Calculation\n" +
                "==================================================\n" +
                "Enter the radius: ");
            SphereRadius = int.Parse(Console.ReadLine());
            int sphereSurface = 4 * 3 * SphereRadius * SphereRadius;
            Console.WriteLine("The surface area of the cone is: " +
                sphereSurface.ToString() + "\n" +
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
                SphereSurface();
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
