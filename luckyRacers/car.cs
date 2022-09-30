using System;
namespace luckyRacers
{
    public class Car
    {
        public string make;
        public string model;
        public int horsepower;
        public float experience;
        public int fuel;
        public int money;
        public int wins;


        public Car(string _make, string _model)
        {
            make = _make;
            model = _model;
            fuel = 5;
            experience = 0;
            horsepower = 100;
            money = 100;

        }

        public void Race()
        {
            if (fuel > 0)
            {
                Console.Clear();
                Program.Line();
                fuel--;
                Random rand = new Random();
                int number = rand.Next(1, 101);
                if (number > 40)
                {
                    Console.WriteLine("You Finished 1st");
                    wins++;
                    Console.WriteLine("Hit ENTER for Rewards!");
                    Console.WriteLine("You have used fuel and have {0} remaining", fuel);
                    Program.Line();
                    Console.ReadKey();
                    Reward();

                }
                else if (number > 25)
                {
                    Console.WriteLine("You Finished 2nd");
                    Console.WriteLine("Hit ENTER for Rewards!");
                    Console.WriteLine("You have used fuel and have {0} remaining", fuel);
                    Program.Line();
                    Console.ReadKey();
                    Reward();

                }
                else if (number > 20)
                {
                    Console.WriteLine("You Finished 3rd");
                    Console.WriteLine("Hit ENTER for Rewards!");
                    Program.Line();
                    Console.WriteLine("You have used fuel and have {0} remaining", fuel);
                    Console.ReadKey();
                    Reward();

                }
                else if (number < 20)
                {

                    Console.WriteLine("You Finished 4th");
                    Console.WriteLine("Hit ENTER for Rewards!");
                    Program.Line();
                    Console.WriteLine("You have used fuel and have {0} remaining", fuel);
                    Console.ReadKey();
                    Reward();
                }
                else if (number < 15)
                {

                    Console.WriteLine("You Finished 5th");
                    Console.WriteLine("Hit ENTER for Rewards!");
                    Program.Line();
                    Console.WriteLine("You have used fuel and have {0} remaining", fuel);
                    Console.ReadKey();
                    Reward();
                }
                else if (number < 10)
                {

                    Console.WriteLine("You Finished Lower than 5th");
                    Console.WriteLine("Not Eligible for Rewards!");
                    Console.WriteLine("You have used fuel and have {0} remaining", fuel);
                    Program.Line();
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Unable to Race your car is out of fuel!");
            }

        }

        public void Refuel()
        {
            fuel += 5;
            money -= 32500;
            Console.WriteLine("You've Spent £32500 Refuelling");
            Console.WriteLine("Your {0} {1} refuels and you now have {2} fuel", make, model, fuel);

        }
        private void Reward()
        {
            Random rand = new Random();
            int number = rand.Next(1, 101);
            Program.Line();
            if (number > 90)
            {
                experience += 12.5f;
                money += 25000;
                Console.WriteLine("Tier 1 Rewards!");
                Console.WriteLine("You've Gained 12.27 experience and £25000");
                Program.Line();

            }
            else if (number > 50)
            {
                experience += 6f;
                money += 12500;
                Console.WriteLine("Tier 2 Rewards!");
                Console.WriteLine("You've Gained 6.12 experience and £12500");
                Program.Line();

            }
            else if (number > 25)
            {
                experience += 3.75f;
                money += 6500;
                Console.WriteLine("Tier 3 Rewards!");
                Console.WriteLine("You've Gained 3.12 experience and £6500");
                Program.Line();

            }
            else if (number < 25)
            {

                Console.WriteLine("You Did Not Win Anything This Time!");
                Program.Line();
            }

        }
    }
}