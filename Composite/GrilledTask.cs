using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class GrilledTask : Task
    {
        public GrilledTask(string taskName) : base(taskName)
        {

        }
        public override int GetTimeRequired()
        {
            return 200;
        }
    }
}
