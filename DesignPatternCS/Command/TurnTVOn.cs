using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCS.Command
{
    class TurnTVOn : ICommand
    {
        IElectronicDevice iDevice;

        public TurnTVOn(IElectronicDevice newDevice)
        {
            iDevice = newDevice;
        }

        public void Execute()
        {
            iDevice.On();
        }
    }
}
