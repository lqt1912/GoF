using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class TurnLightOffCommand : LightCommand
    {
        public TurnLightOffCommand(Light light) : base(light)
        { }
        public override void Excute()
        {
            this.light.TurnOff();
        }
    }
}
