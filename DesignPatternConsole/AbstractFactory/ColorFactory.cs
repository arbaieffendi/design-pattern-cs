using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.AbstractFactory
{
    public class ColorFactory : AbstractFactory
    {

       public override IShape getShape(String shapeType)
        {
            return null;
        }
        
        public override Color getColor(String color)
        {

            if (color == null)
            {
                return null;
            }

            if (color.ToUpper().Equals("RED"))
            {
                return new Red();

            }
            else if (color.ToUpper().Equals("GREEN"))
            {
                return new Green();

            }
            else if (color.ToUpper().Equals("BLUE"))
            {
                return new Blue();
            }

            return null;
        }
    }
}
