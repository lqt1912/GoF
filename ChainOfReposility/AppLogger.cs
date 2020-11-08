using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfReposility
{
    public class AppLogger
    {
        public static Logger getLogger()
        {
            Logger consoleLogger = new ConsoleLogger(new LogLevel( Level.DEBUG));
            Logger fileLogger = consoleLogger.setNext(new FileLogger(new LogLevel(Level.ERROR)));
            fileLogger.setNext(new EmailLogger(new LogLevel(Level.FATAL)));
            return consoleLogger;
        }
    }
}
