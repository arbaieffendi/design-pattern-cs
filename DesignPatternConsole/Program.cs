using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            GetMenu();
            string inputString = Console.ReadLine();
            int key;

            if (!int.TryParse(inputString, out key))
            {
                return;
            }

            switch (key)
            { 

                case 1:
                    FactoryPatternDemo.run();
                    break;
                
                case 2:
                    AbstractFactory.Demo.run();
                    break;

                case 3:
                    Console.WriteLine("Sorry, the pattern demo is not available yet");
                    break;

                case 4:
                    Builder.Demo.run();
                    break;

                case 5:
                    new Facade.MortgageDemo().Run();
                    break;

                default:
                    break;
            }

            Console.WriteLine("Do you want to exit ? Y/N");
            if (Console.ReadKey().ToString().ToUpper().Equals('N'))
            {
                Console.Clear();
                GetMenu();
            }

        }

        static void GetMenu() {

            Console.WriteLine("---- Design Pattern ----");
            Console.WriteLine("1. Factory");
            Console.WriteLine("2. Abstract Factory");
            Console.WriteLine("3. Strategy");
            Console.WriteLine("4. Builder");
            Console.WriteLine("0. Exit");

            Console.WriteLine("Enter pattern : ");
        }
    }
}
