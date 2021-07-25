using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCS.Builder
{

    /// <summary>
    /// A Director class
    /// </summary>
    internal class Shop
    {
        public void Construct(VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
        }
    }
}
