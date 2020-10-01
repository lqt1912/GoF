using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class MixTask : Task
    {
        public MixTask(string taskName):base(taskName)
        {

        }
        public override int GetTimeRequired()
        {
            return 200;
        }
    }
}
