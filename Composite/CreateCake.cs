using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class CreateCake:CompositeTask
    {
       public CreateCake(string taskName):base(taskName)
        {
            AddNewTask(new AddDryIngredientsTask("Thêm nguyên liệu"));
            AddNewTask(new MixTask("Trộn bột"));
            AddNewTask(new GrilledTask("Nướng bánh"));

        }
    }

    public class CreateBiggerCake : CompositeTask
    {
        public CreateBiggerCake(string taskName) : base(taskName)
        {
            AddNewTask(new AddDryIngredientsTask("Thêm nguyên liệu gấp đôi"));
            AddNewTask(new MixTask("Trộn bột"));
            AddNewTask(new MixTask("Trộn bột"));
            AddNewTask(new MixTask("Trộn bột"));
            AddNewTask(new GrilledTask("Nướng bánh gấp đôi "));
        }
    }
}
