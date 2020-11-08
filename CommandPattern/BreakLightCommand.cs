using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class BreakLightCommand : LightCommand
    {
        public BreakLightCommand(Light light) : base(light)
        {

        }

        public override void Excute()
        {
            this.light.BreakLight();
        }
    }
}
