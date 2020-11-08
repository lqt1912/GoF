using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace CommandPattern
{
    public class RemoteFunction
    {
        ICommand command;

        public RemoteFunction(ICommand command)
        {
            SetCommand(command);
        }

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void ExcuteCommand()
        {
            this.command.Excute();
        }
    }
}
