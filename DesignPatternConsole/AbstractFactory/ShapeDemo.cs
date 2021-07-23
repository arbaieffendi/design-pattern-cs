using DesignPatternConsole.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.AbstractFactory
{
    class ShapeDemo : DemoBase
    {
        public override void Run()
        {
            //get shape factory
            AbstractFactory shapeFactory = FactoryProducer.getFactory("SHAPE");

            //get an object of Shape Circle
            IShape shape1 = shapeFactory.GetShape("CIRCLE");

            //call draw method of Shape Circle
            shape1.Draw();

            //get an object of Shape Rectangle
            IShape shape2 = shapeFactory.GetShape("RECTANGLE");

            //call draw method of Shape Rectangle
            shape2.Draw();

            //get an object of Shape Square 
            IShape shape3 = shapeFactory.GetShape("SQUARE");

            //call draw method of Shape Square
            shape3.Draw();

            //get color factory
            AbstractFactory colorFactory = FactoryProducer.getFactory("COLOR");

            //get an object of Color Red
            Color color1 = colorFactory.GetColor("RED");

            //call fill method of Red
            color1.fill();

            //get an object of Color Green
            Color color2 = colorFactory.GetColor("Green");

            //call fill method of Green
            color2.fill();

            //get an object of Color Blue
            Color color3 = colorFactory.GetColor("BLUE");

            //call fill method of Color Blue
            color3.fill();
        }
    }
}
