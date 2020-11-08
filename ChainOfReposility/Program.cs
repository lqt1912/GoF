using System;

namespace ChainOfReposility
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = AppLogger.getLogger();

            Console.WriteLine("Handled by ConsoleLogger since the console has a LogLevel of DEBUG"); 
            logger.log(new LogLevel(Level.INFO), "Info message");
            logger.log(new LogLevel(Level.DEBUG), "Debug message");

            Console.WriteLine();

            // 
            Console.WriteLine("Handled by ConsoleLogger and FileLogger");
            logger.log(new LogLevel(Level.ERROR), "Error message");
            Console.WriteLine();

            Console.WriteLine(" Handled by ConsoleLogger, FileLogger, EmailLogger");
            //
            logger.log(new LogLevel(Level.FATAL), "Factal message");

        }
    }
}
