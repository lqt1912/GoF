using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class TurnLightOnCommand : LightCommand
    {

        public TurnLightOnCommand(Light light) : base(light)
        {

        }
        public override void Excute()
        {
            this.light.TurnOn();
        }
    }
}
