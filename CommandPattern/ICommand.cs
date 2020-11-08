using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
   public  interface ICommand
    {
        void Excute();
    }

    public abstract class LightCommand : ICommand
    {
        protected Light light;

        protected LightCommand(Light light)
        {
            this.light = light;
        }

        public abstract void Excute();
    }
}
