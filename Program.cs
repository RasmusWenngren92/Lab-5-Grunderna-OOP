using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Circle
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Programmer   : Rasmus Wenngren
            // Program      : Fullstack .NET
            // Course       : Promgrammering med C# och .NET
            // Lab 5        : Grunderna OOP
            
            //Bool for running the program
            bool endApp = false;

            while (!endApp)
            {
                Console.Clear();
                PrintMenu();
                string menu = Console.ReadLine().ToUpper();
                //menu for choosing to work with triangular shape or spherical
                switch (menu)
                {
                    case "A":
                        CircelFunction();
                        
                    break;

                    case "B":
                        TriangularFunction();
                        
                        break; 

                    case "C":
                        Console.Clear();
                        Console.WriteLine("\n\tTack för den här gången :) ");
                        Thread.Sleep(2000);
                        endApp = true;
                        break;

                    default:

                        Console.WriteLine("\n\tVar god mata in ett alternativ från menyn.");
                        Console.ReadLine();
                        break;

                }
            }
        }
        // static function for display a menu
        public static void PrintMenu()
        {
            Console.WriteLine("\n\tHej och Välkommen!" +
                                    "\n\tVälj i menyn vad du vill göra: " +
                                    "\n\t[A] Formler för en Sfär." +
                                    "\n\t[B] Formler för en Triangel." +
                                    "\n\t[C] Avsluta programmet.");
        }
        // static function for display a menu
        public static void CircleMenu()
        {
            Console.WriteLine("\n\tHej, välj nedan vad du vill göra." +
                                    "\n\t[A] Räkna ut Arean." +
                                    "\n\t[B] Räkna ut Volymen." +
                                    "\n\t[C] Räkna ut Omkretsen." +
                                    "\n\t[D] Gå tillbaka till föregående meny.");

        }
        // static function for display a menu
        public static void TriangularMenu()
        {
            Console.WriteLine("\n\tHej, välj nedan vad du vill göra." +
                                    "\n\t[A] Räkna ut Arean." +
                                    "\n\t[B] Räkna ut Volymen." +
                                    "\n\t[C] Räkna ut Omkretsen." +
                                    "\n\t[D] Gå tillbaka till föregående meny.");
        }
        //method containing a menu and the different calculations
        static void CircelFunction()
        {
            // bool for running the loop, asking for input value
            bool circleBool = false;
            Console.Clear();
            Console.WriteLine("\n\tVar god ange Radien (cm) på Sfären: ");
            string input = Console.ReadLine();
            int radius = ReadInt.ValidInput(input);
            Circle circle = new Circle(radius);

                 while (!circleBool)
                 {
                    // showing the menu and the inpu value
                    Console.Clear();
                    Console.WriteLine($"\n\tRadien på Sfären är : {radius} cm.");
                    CircleMenu();
                    string circleMenu = Console.ReadLine().ToUpper();

                        switch (circleMenu)//a switch to let the user use different calculations and get output
                        {
                                case "A":
                                    Console.WriteLine($"\n\tSfärens Area är: {circle.GetArea()} cm2.");
                                    Console.ReadLine();
                                    break;
                                case "B":
                                    Console.WriteLine($"\n\tSfärens Volym är: {circle.GetVolume()} cm3.");
                                    Console.ReadLine();
                                    break;
                                case "C":
                                    Console.WriteLine($"\n\tSfärens Omkrets är: {circle.GetPerimeter()} cm. ");
                                    Console.ReadLine();
                                    break;
                                case "D":
                                    Console.WriteLine("\n\tTack för idag!");
                                    Thread.Sleep(2000);
                                    circleBool = true;
                                    break;

                                default:
                                    Console.WriteLine("\n\tVar god mata in ett alternativ från menyn.");
                                    Thread.Sleep(1000);
                                    break;

                        }
                            
                 }

        }
        //method containing a menu and the different calculations
        static void TriangularFunction()
        {
            // bool for running the loop and ansking for input values
            bool triangularBool = false;

            Console.Clear();
            Console.WriteLine("\n\tAnge sida A (cm) på triangeln: ");
            string userInputSideA = Console.ReadLine();
            int sideA = ReadInt.ValidInput(userInputSideA);

            Console.WriteLine("\n\tAnge sida B (cm) på triangeln: ");
            string userInputSideB = Console.ReadLine();
            int sideB = ReadInt.ValidInput(userInputSideB);

            Console.WriteLine("\n\tAnge sida C (cm) på triangeln som är dess bas: ");
            string userInputSideC = Console.ReadLine();
            int sideC = ReadInt.ValidInput(userInputSideC);
            //creating a new triangular object
            Triangular triangular = new Triangular(sideA, sideB, sideC);

                while (!triangularBool)
                {
                    // prints the menu and shows the user the input
                    Console.Clear();
                    Console.Write($"\n\tDina sidor på Triangeln är: \n\t{sideA}cm & {sideB}cm & {sideC}cm");
                    Console.WriteLine();
                    TriangularMenu();
                    string triangularLoop = Console.ReadLine().ToUpper();
                    switch (triangularLoop)//a switch to let the user use different calculations and get output
                    {
                            case "A":
                            Console.WriteLine($"\n\tTriangelns Area är: {triangular.GetArea()} cm2.");
                            Console.ReadLine();
                            break;

                            case "B":
                            Console.WriteLine($"\n\tPrismans Volym är: {triangular.GetVolume()} cm3.");
                            Console.ReadLine();
                            break;

                            case "C":
                            Console.WriteLine($"\n\tTriangelns Omkrets är: {triangular.GetPerimeter()} cm.");
                            Console.ReadLine();
                            break;

                            case "D":
                            Console.WriteLine("\n\tTack för idag!");
                            Thread.Sleep(2000);
                            triangularBool = true;
                            break;

                            default:

                            Console.WriteLine("\n\tVar god mata in ett alternativ från menyn.");
                            Console.ReadLine();
                            break;

                    }
                            
                }
        }
    }
}
