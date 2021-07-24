using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.AbstractFactory
{
    class AnimalFoodChainDemo : DemoBase
    {
        public override void Run()
        {
            string description = "Abstract Factory is a creational pattern. It provides an interface for creating families of related or dependent objects without specifying their concrete classes";

            description += "\n\n Here we have example cases, animal food chain. The creation of different animal world for a computer game using different factories. Although the animals created by the continent factories are different, the interactions among the animals remain the same";
            Console.WriteLine($"{ description} \n\n");

            // Abstract Factory #1
            ContinentFactory afrika = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(afrika);
            world.RunFoodChain();

            // Abstract Factory #2
            ContinentFactory amerika = new AmericaFactory();
            world = new AnimalWorld(amerika);
            world.RunFoodChain();
        }
    }
}
