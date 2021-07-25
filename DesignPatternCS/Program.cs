using System;

namespace DesignPatternCS
{
    class Program
    {
        static void Main(string[] args)
        {
            ChoosePattern();
        }

        private static void ChoosePattern()
        {
            Console.WriteLine("---- Design Pattern ----");
            Console.WriteLine("1. Factory Method (Document Pages)");
            Console.WriteLine("2. Abstract Factory (Food Chain)");
            Console.WriteLine("3. Strategy");
            Console.WriteLine("4. Builder (Vehicle Production)");
            Console.WriteLine("5. Facade (Mortgage System)");
            Console.WriteLine("0. Exit");

            Console.WriteLine("Enter pattern : ");
            OnChoose();
        }

        private static void OnChoose()
        {
            string inputString = Console.ReadLine();
            int key;

            if (!int.TryParse(inputString, out key))
            {
                key = -1;
            }

            switch (key)
            {
                case 1:
                    new FactoryMethod.DocumentDemo().Run();
                    break;

                case 2:
                    new AbstractFactory.AnimalFoodChainDemo().Run();
                    break;

                case 3:
                    Console.WriteLine("Sorry, the pattern demo is not available yet");
                    break;

                case 4:
                    new Builder.VehicleProductionDemo().Run();
                    break;

                case 5:
                    new Facade.MortgageDemo().Run();
                    break;

                case 0:
                    break;

                default:
                    Console.WriteLine("Sorry, i don't get what you mean");
                    break;
            }

            AskExit();
        }

        private static void AskExit()
        {
            Console.WriteLine("Do you want to exit ? Y/N");
            OnExit();
        }

        private static void OnExit()
        {
            string key = Console.ReadLine().ToString().ToUpper();

            if (key.Equals("N"))
            {
                Console.Clear();
                ChoosePattern();
            }
            else if (key != "Y")
            {
                Console.WriteLine("Sorry, i don't get what you mean");
                AskExit();
            }
        }
    }
}
