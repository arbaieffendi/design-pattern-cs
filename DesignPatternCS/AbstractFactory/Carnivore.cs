namespace DesignPatternCS.AbstractFactory
{
    // A Product Abstract Class
    abstract class Carnivore
    {
        public abstract void Eat(Herbivore herbivore);
    }

    // A Product Class
    class Wolf : Carnivore
    {
        public override void Eat(Herbivore herbivore)
        {
            // wolf eats herbivore
            System.Console.WriteLine(this.GetType().Name + " eats " + herbivore.GetType().Name);
        }
    }

    // A Product Class
    class Lion : Carnivore
    {
        public override void Eat(Herbivore herbivore)
        {
            // Lion eats herbivore
            System.Console.WriteLine(this.GetType().Name + " eats " + herbivore.GetType().Name);
        }
    }
}