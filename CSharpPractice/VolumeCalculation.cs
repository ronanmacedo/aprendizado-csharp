using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryFormulas
{
    class VolumeCalculation
    {
        public VolumeCalculation()
        {
        }

        public int Side { get; set; }

        public int CylinderRadius { get; set; }

        public int CylinderHeigth { get; set; }

        public int ConeRadius { get; set; }

        public int ConeHeigth { get; set; }

        public int SphereRadius { get; set; }

        public void CubeVolume()
        {
            Console.WriteLine("\tCube Volume Calculation\n" +
                "==================================================\n" +
                "Enter the side: ");
            Side = int.Parse(Console.ReadLine());
            int cubeVolume = Side * Side * Side;
            Console.WriteLine("The volume of the cube is: " +
                cubeVolume.ToString() + "\n" +
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
                CubeVolume();
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

        public void CylinderVolume()
        {
            Console.WriteLine("\tCylinder Volume Calculation\n" +
                "==================================================\n" +
                "Enter the radius: ");
            CylinderRadius = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the heigth: ");
            CylinderHeigth = int.Parse(Console.ReadLine());
            int cylinderVolume = 3 * CylinderRadius * CylinderRadius * CylinderHeigth;
            Console.WriteLine("The volume of the cylinder is: " +
                cylinderVolume.ToString() + "\n" +
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
                CylinderVolume();
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

        public void ConeVolume()
        {
            Console.WriteLine("\tCone Volume Calculation\n" +
                "==================================================\n" +
                "Enter the radius: ");
            ConeRadius = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the heigth: ");
            ConeHeigth = int.Parse(Console.ReadLine());
            double cylinderVolume = (1.0 / 3.0) * 3 * ConeRadius * ConeRadius * ConeHeigth;
            int cylinderVolumeInt = (int)cylinderVolume;
            Console.WriteLine("The volume of the cone is: " +
                cylinderVolumeInt.ToString() + "\n" +
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
                ConeVolume();
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

        public void SphereVolume()
        {
            Console.WriteLine("\tSphere Volume Calculation\n" +
                "==================================================\n" +
                "Enter the radius: ");
            SphereRadius = int.Parse(Console.ReadLine());
            double sphereVolume = (4.0 / 3.0) * 3 * SphereRadius * SphereRadius * SphereRadius;
            int sphereVolumeInt = (int)sphereVolume;
            Console.WriteLine("The volume of the cone is: " +
                sphereVolumeInt.ToString() + "\n" +
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
                SphereVolume();
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
