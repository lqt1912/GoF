using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfReposility
{
    public enum Level
    {
        NONE, INFO, DEBUG, WARNING, ERROR,FATAL, ALL
    }

    public class LogLevel
    {
        private Level level;

        public LogLevel(Level level)
        {
            this.level = level;
        }

        public int getLevel()
        {
            return (int)level;
        }
    }

}
