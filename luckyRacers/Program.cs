using System;
using System.Reflection;
using static System.Collections.Specialized.BitVector32;

namespace luckyRacers
{
    class Program
    {

        public static void Main(string[] args)
        {
            Car car01 = new Car("Ford", "Fiesta");
            Line();
            Console.WriteLine("                  Lucky Racers");
            Console.WriteLine("               By Nathan Maynard");
            Console.WriteLine("        Current Time: " + DateTime.Now);
            Line();
            Console.WriteLine("");
            Console.WriteLine("Hit ENTER to Continue");
            Console.ReadKey();
            creation();
            menu(car01);


        }


        public static object createCar(string make, string model)
        {
            Car car01 = new Car(make, model);
            return car01;

        }

        static void creation()
        {
            Console.Clear();
            Console.WriteLine("Please Select a Beginner Car From Below:");
            Line();
            Console.WriteLine("Ford Fiesta");
            Console.WriteLine("Citroen C1");
            Console.WriteLine("Vauxhall Corsa");
            Line();
            Console.WriteLine("Selection: ");
            string selection = Console.ReadLine();
            if (selection == "1")
            {
                createCar("Ford", "Fiesta");
                Console.WriteLine("You Have chosen Ford Fiesta");
                Console.ReadKey();

            }
            else if (selection == "2")
            {
                createCar("Citroen", "C1");
                Console.WriteLine("You've chosen Citroen C1");
                Console.ReadKey();

            }
            else if (selection == "3")
            {
                createCar("Vauxhall", "Corsa");
                Console.WriteLine("You've chosen Vauxhall Corsa");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Incorrect Value!");
                Console.WriteLine("Press any key to retry");
                Console.ReadKey();
                creation();
            }
        }

        public static void Line()
        {
            int i;
            for (i = 0; i < 50; i++)
            {
                Console.Write("-");

            }
            Console.WriteLine("");
        }


        static void menu(Car car01)
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("      _.-.___\\__");
            Console.WriteLine("      |  _      _`-.      LUCKY RACERS");
            Console.WriteLine("      '-(_)----(_)--`   Car: {0} {1}", car01.make, car01.model);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("      Experience: {0}           Money: £{1}", car01.experience, car01.money);
            Console.WriteLine("");
            Line();
            Console.WriteLine("                    MAIN MENU");
            Console.WriteLine("                      Race");
            Console.WriteLine("                      [WIP] Upgrade");
            Console.WriteLine("                      Refuel({0})", car01.fuel);
            Console.WriteLine("                      [WIP] Garage");
            Console.WriteLine("                      [WIP] Marketplace");
            Console.WriteLine("                      Stats");
            Console.WriteLine("                      [WIP] Save & Exit");
            Line();
            Console.WriteLine("Select Option: ");
            string menuSelect = Console.ReadLine();
            if (menuSelect == "1")
            {

                car01.Race();
                Console.ReadLine();
                menu(car01);
            }
            else if (menuSelect == "6")
            {
                Console.Clear();
                Line();
                Console.WriteLine("Experience: " + car01.experience);
                Console.WriteLine("Money: £" + car01.money);
                Console.WriteLine("Wins: " + car01.wins);
                Console.ReadLine();
                menu(car01);
            }
            else if (menuSelect == "3")
            {
                car01.Refuel();
                Console.ReadLine();
                menu(car01);
            }
            else
            {
                menu(car01);
            }
        }
    }
}
