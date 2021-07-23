using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Factory
{
    public class Rectangle : IShape
    {
       public void draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }
}
