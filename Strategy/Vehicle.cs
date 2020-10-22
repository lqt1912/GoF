using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public abstract class Vehicle
    {
        private IGoInterface go;

        public void SetVehicle(IGoInterface goInterface)
        {
            go = goInterface;
        }

        public void GoWithVehicle()
        {
            go.Go();
        }
    }
}
