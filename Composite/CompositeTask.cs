using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class CompositeTask : Task
    {
        List<Task> tasks = new List<Task>();

        public CompositeTask(string taskName) : base(taskName)
        {

        }
        public void AddNewTask(Task task)
        {
            tasks.Add(task);
        }

        public override int GetTimeRequired()
        {
            var res = 0;
            foreach (var item in tasks)
            {
                res = res + item.GetTimeRequired();
            }
            return res;
        }

        public void ShowHowTo()
        {
            foreach (var item in tasks)
            {
                Console.WriteLine(item.GetTaskName);
            }
            Console.WriteLine();
            Console.WriteLine("--------Làm xong bánh--------");
            Console.WriteLine();
        }
    }
}
