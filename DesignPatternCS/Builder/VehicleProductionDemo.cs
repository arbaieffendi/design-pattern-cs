using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCS.Builder
{
    class VehicleProductionDemo : DemoBase
    {
        public override void Run()
        {
            string description = "The Builder let us construct complex object step by step. It separates the construction of a complex object from its representation so that the same construction process can create different representations";
            description += "\n\nHere the builder pattern sample in a vehicle production";
            Console.WriteLine(description);

            VehicleBuilder builder;

            Shop shop = new Shop();
            
            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
        }
    }
}
