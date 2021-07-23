using DesignPatternConsole.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.AbstractFactory
{

    public abstract class AbstractFactory
    {
        public abstract Color GetColor(String color);
        public abstract IShape GetShape(String shape);
    }
}
