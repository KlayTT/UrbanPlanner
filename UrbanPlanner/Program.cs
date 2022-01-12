using System;
using UrbanPlanner.Planner;

namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate - use the 'new' keyword to create an isntance of an object
            // initialize - give an instance an initial value
            Building oneTwo = new Building("12 Address Ave")
            {
                Width = 5,
                Stories = 2,
                Depth = 10

            };
            Building threeFour = new Building("34 Address Ave")
            {
                Width = 7,
                Depth = 4,
                Stories = 3
            };
            Building fiveSix = new Building("56 Address Ave")
            {
                Width = 6,
                Depth = 15,
                Stories = 1
            };
            Building sevenEight = new Building("78 Address Ave")
            {
                Width = 7,
                Depth = 4,
                Stories = 3
            };

            oneTwo.Construct();
            threeFour.Construct();
            fiveSix.Construct();
            sevenEight.Construct();
            oneTwo.Purchased("Shelly");
            threeFour.Purchased("Jim");
            fiveSix.Purchased("Kim");
            sevenEight.Purchased("Katy");

            oneTwo.PrintToConsole();
            threeFour.PrintToConsole();
            fiveSix.PrintToConsole();
            sevenEight.PrintToConsole();

            Console.WriteLine("Thank you for your purchases!");
        }
    }
}
