using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Remote myRemote = new Remote();
            Light light = new Light();

            ICommand turnOn = new TurnLightOnCommand(light);
            ICommand turnOff = new TurnLightOffCommand(light);
            ICommand breakLight = new BreakLightCommand(light);

            myRemote.AddFunction(new RemoteFunction(turnOff));
            myRemote.AddFunction(new RemoteFunction(turnOn));
            myRemote.AddFunction(new RemoteFunction(breakLight));

            myRemote.Excute();

        }
    }
}
