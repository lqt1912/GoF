using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Car : Vehicle
    {
        public Car() 
        {
            this.SetVehicle(new GoDriving());
        }
    }
}
