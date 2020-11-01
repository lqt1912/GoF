using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public interface  BasePlayer
    {
        void Attack(BaseMonster monster);
    }


    public abstract class BaseMonster
    {
       public abstract void DamagedBy(PhysicalPlayer physicalPlayer);
        public abstract void DamagedBy(MagicalPlayer magicalPlayer);
      
        public void Damaged(int hp)
        {
            Console.WriteLine($"Damaged {hp} hp!  ");
        }
    }
}
