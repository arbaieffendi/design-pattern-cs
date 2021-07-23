using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Factory
{
    public class Circle : IShape
    {
       public void draw()
        {
            Console.WriteLine("Inside Circle::draw() method.");
        }
    }
}
