using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Factory
{
    public class ShapeFactory
    {

        //use getShape method to get object of type shape 
        public IShape getShape(String shapeType)
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
    }
}
