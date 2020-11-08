using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfReposility
{
    public abstract class Logger
    {

        protected LogLevel logLevel;

        protected Logger nextlogger; // The next Handler in the chain

        public Logger(LogLevel logLevel)
        {
            this.logLevel = logLevel;
        }

        // Set the next logger to make a list/chain of Handlers.
        public Logger setNext(Logger nextlogger)
        {
            this.nextlogger = nextlogger;
            return nextlogger;
        }

        public void log(LogLevel severity, String msg)
        {
            if (logLevel.getLevel() <= severity.getLevel())
            {
                writeMessage(msg);
            }
            if (nextlogger != null)
            {
                nextlogger.log(severity, msg);
            }
        }

        public abstract void writeMessage(String msg);
    }
    public class ConsoleLogger : Logger
    {
        public ConsoleLogger(LogLevel logLevel) : base(logLevel)
        {
        }

        public override void writeMessage(string msg)
        {
            Console.WriteLine("Console logger: " + msg);
        }
    }

    public class FileLogger : Logger
    {
        public FileLogger(LogLevel logLevel) : base(logLevel)
        {
        }

        public override void writeMessage(String msg)
        {
            Console.WriteLine("File logger: " + msg);
        }
    }

    public class EmailLogger : Logger
    {
        public EmailLogger(LogLevel logLevel) : base(logLevel)
        {
        }

        public override void writeMessage(String msg)
        {
            Console.WriteLine("Email logger: " + msg);
        }
    }
}
