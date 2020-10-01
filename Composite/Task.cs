using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public  class Task
    {
        protected string taskName;

        public  Task(string taskName)
        {
            this.taskName = taskName;
        }

        public  virtual int GetTimeRequired()
        {
            return 10;
        }

        public string GetTaskName => this.taskName;

    }
}
