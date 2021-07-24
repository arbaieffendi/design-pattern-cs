using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCS.Command
{
    class TurnTVOff : ICommand
    {
        IElectronicDevice iDevice;

        public TurnTVOff(IElectronicDevice newDevice)
        {
            iDevice = newDevice;
        }

        public void Execute()
        {
            iDevice.Off();
        }
    }
}
