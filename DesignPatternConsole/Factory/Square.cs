using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole
{
    public class Square : IShape
    {
       public void draw()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }
}
