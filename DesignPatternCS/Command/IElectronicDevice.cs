using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCS.Command
{
    public interface IElectronicDevice
    {
        void On();
        void Off();
    }
}
