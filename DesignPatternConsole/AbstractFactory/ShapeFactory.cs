using DesignPatternConsole.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.AbstractFactory
{
    public class ShapeFactory : AbstractFactory
    {
       public override IShape GetShape(String shapeType)
        {

            if (shapeType == null)
            {
                return null;
            }

            if (shapeType.ToUpper().Equals("CIRCLE"))
            {
                return new Circle();

            }
            else if (shapeType.ToUpper().Equals("RECTANGLE"))
            {
                return new Rectangle();

            }
            else if (shapeType.ToUpper().Equals("SQUARE"))
            {
                return new Square();
            }

            return null;
        }

        public override Color GetColor(String color)
        {
            return null;
        }
    }
}
