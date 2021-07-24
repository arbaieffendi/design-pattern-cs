using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCS.AbstractFactory
{
    /// <summary>
    /// An Abstract Factory
    /// declares an interface for operations that create abstract products
    /// </summary>
    abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }

    /// <summary>
    /// A concrete factory
    /// Implements the operations to create concrete product objects
    /// </summary>
    class AfricaFactory : ContinentFactory
    {
        /// <summary>
        /// A Concrete Factory
        /// return animal from africa
        /// </summary>
        /// <returns></returns>
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }
    }

    /// <summary>
    /// A concrete factory
    /// Implements the operations to create concrete product objects
    /// </summary>
    class AmericaFactory : ContinentFactory
    {
        /// <summary>
        /// A concrete factory class
        /// return animal from america
        /// </summary>
        /// <returns></returns>
        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }
    }

}
