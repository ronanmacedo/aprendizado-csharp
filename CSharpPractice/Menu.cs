using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryFormulas
{
    class Menu
    {

        public Menu()
        {
        }

        public void MainMenu()
        {
            //greetings message 
            Console.WriteLine("\tGeometry Formular Calculator\n" +
                "==================================================\n" +
                "\tSelect one of the options below:\n\n" +
                "(1) Perimeter Calculations\n" +
                "(2) Circumferance Calculation\n" +
                "(3) Area Calculations\n" +
                "(4) Surface Area Calculations\n" +
                "(5) Volume Calculations\n" +
                "==================================================\n");
  
            string select = Console.ReadLine();
            while(select != "1" && select != "2" && select != "3" &&
                  select != "4" && select != "5")
            {
                Console.WriteLine("\nWrong input, enter a number between 1 to 5.\n" +
                    "Enter your option again: ");
                select = Console.ReadLine();
            }

            int iSelect = int.Parse(select);

            try
            { 
            //redirect the input to the corresponding menu
                switch(iSelect)
                {
                    case 1:
                        PerimeterMenu();
                        break;
                    case 2:
                        CircumferanceMenu();
                        break;
                    case 3:
                        AreaMenu();
                        break;
                    case 4:
                        SurfaceAreMenu();
                        break;
                    case 5:
                        VolumeMenu();
                        break;
                }
            } 
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public void PerimeterMenu()
        {
            PerimeterCalculation perimeterCalculation = new PerimeterCalculation();

            Console.WriteLine("\tPerimeter Menu\n" +
                "==================================================\n" +
                "(1) Square Perimenter Calculation\n" +
                "(2) Rectangle Perimenter Calculation\n" +
                "(3) Back to Main Menu\n" +
                "==================================================\n");

            string select = Console.ReadLine();
            while (select != "1" && select != "2" && select != "3")
            {
                Console.WriteLine("\nWrong input, enter a number between 1 to 3.\n" +
                    "Enter your option again: ");
                select = Console.ReadLine();
            }

            int iSelect = int.Parse(select);

            try
            {
                //redirect the input to the corresponding menu
                switch (iSelect)
                {
                    case 1:
                        perimeterCalculation.SquarePerimeter();
                        break;
                    case 2:
                        perimeterCalculation.RectanglePerimeter();
                        break;
                    case 3:
                        MainMenu();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public void CircumferanceMenu()
        {
            CircumferanceCalculation circumferance = new CircumferanceCalculation();

            Console.WriteLine("\tCircumferance Menu\n" +
                "==================================================\n" +
                "(1) Circle Circumferance Calculation\n" +
                "(2) Back to Main Menu\n" +
                "==================================================\n");

            string select = Console.ReadLine();
            while (select != "1" && select != "2")
            {
                Console.WriteLine("\nWrong input, enter a number between 1 to 2.\n" +
                    "Enter your option again: ");
                select = Console.ReadLine();
            }

            int iSelect = int.Parse(select);

            try
            {
                //redirect the input to the corresponding menu
                switch (iSelect)
                {
                    case 1:
                        circumferance.CircleCircumferance();
                        break;
                    case 2:
                        MainMenu();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public void AreaMenu()
        {
            AreaCalculation area = new AreaCalculation();

            Console.WriteLine("\tArea Menu\n" +
                "==================================================\n" +
                "(1) Square Area Calculation\n" +
                "(2) Rectangle Area Calculation\n" +
                "(3) Triangle Area Calculation\n" +
                "(4) Trapezoid Area Calculation\n" +
                "(5) Circle Area Calculation\n" +
                "(6) Back to Main Menu\n" +
                "==================================================\n");

            string select = Console.ReadLine();
            while (select != "1" && select != "2" && select != "3"
                   && select != "4" && select != "5" && select != "6")
            {
                Console.WriteLine("\nWrong input, enter a number between 1 to 6.\n" +
                    "Enter your option again: ");
                select = Console.ReadLine();
            }

            int iSelect = int.Parse(select);

            try
            {
                //redirect the input to the corresponding menu
                switch (iSelect)
                {
                    case 1:
                        area.SquareArea();
                        break;
                    case 2:
                        area.RectangleArea();
                        break;
                    case 3:
                        area.TriangleArea();
                        break;
                    case 4:
                        area.TrapezoidArea();
                        break;
                    case 5:
                        area.CircleArea();
                        break;
                    case 6:
                        MainMenu();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public void SurfaceAreMenu()
        {
            SurfaceAreaCalculation surfaceArea = new SurfaceAreaCalculation();

            Console.WriteLine("\tSurface Area Menu\n" +
                "==================================================\n" +
                "(1) Cube Surface Area Calculation\n" +
                "(2) Cynlinder Surface Area Calculation\n" +
                "(3) Cone Surface Area Calculation\n" +
                "(4) Sphere Surface Area Calculation\n" +
                "(5) Back to Main Menu\n" +
                "==================================================\n");

            string select = Console.ReadLine();
            while (select != "1" && select != "2" && select != "3"
                   && select != "4" && select != "5")
            {
                Console.WriteLine("\nWrong input, enter a number between 1 to 5.\n" +
                    "Enter your option again: ");
                select = Console.ReadLine();
            }

            int iSelect = int.Parse(select);

            try
            {
                //redirect the input to the corresponding menu
                switch (iSelect)
                {
                    case 1:
                        surfaceArea.CubeSurface();
                        break;
                    case 2:
                        surfaceArea.CylinderSurface();
                        break;
                    case 3:
                        surfaceArea.ConeSurface();
                        break;
                    case 4:
                        surfaceArea.SphereSurface();
                        break;
                    case 5:
                        MainMenu();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public void VolumeMenu()
        {
            VolumeCalculation volume = new VolumeCalculation();

            Console.WriteLine("\tVolume Menu\n" +
                "==================================================\n" +
                "(1) Cube Volume Calculation\n" +
                "(2) Cynlinder Volume Calculation\n" +
                "(3) Cone Volume Calculation\n" +
                "(4) Sphere Volume Calculation\n" +
                "(5) Back to Main Menu\n" +
                "==================================================\n");

            string select = Console.ReadLine();
            while (select != "1" && select != "2" && select != "3"
                   && select != "4" && select != "5")
            {
                Console.WriteLine("\nWrong input, enter a number between 1 to 5.\n" +
                    "Enter your option again: ");
                select = Console.ReadLine();
            }

            int iSelect = int.Parse(select);

            try
            {
                //redirect the input to the corresponding menu
                switch (iSelect)
                {
                    case 1:
                        volume.CubeVolume();
                        break;
                    case 2:
                        volume.CylinderVolume();
                        break;
                    case 3:
                        volume.ConeVolume();
                        break;
                    case 4:
                        volume.SphereVolume();
                        break;
                    case 5:
                        MainMenu();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
