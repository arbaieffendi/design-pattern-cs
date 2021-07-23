﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Factory
{
    public class Square : IShape
    {
       public void Draw()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }
}
