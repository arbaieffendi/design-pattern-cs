using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCS.Command
{
    public class Television : IElectronicDevice
    {
        public void Off()
        {
            Console.WriteLine("TV is Off");
        }

        public void On()
        {
            Console.WriteLine("TV is On");
        }
    }
}
