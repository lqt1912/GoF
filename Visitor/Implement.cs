using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class PhysicalPlayer : BasePlayer
    {
        public void Attack(BaseMonster monster)
        {
            Console.WriteLine("Physical weapon attacking!");
            monster.DamagedBy(this);
            Console.WriteLine();
        }
    }
    public class MagicalPlayer : BasePlayer
    {
        public void Attack(BaseMonster monster)
        {
            Console.WriteLine("Magical weapon attacking!");
            monster.DamagedBy(this);
            Console.WriteLine();
        }
    }

    public class Flea : BaseMonster
    {

        public override void DamagedBy(PhysicalPlayer physicalPlayer)
        {
            Console.WriteLine("Attacked by physical player! ");
            base.Damaged(100);
        }

        public override void DamagedBy(MagicalPlayer magicalPlayer)
        {
            Console.WriteLine("Attacked by magical player! ");
            base.Damaged(1000);
        }
    }

    public class Bat : BaseMonster
    {

        public override void DamagedBy(PhysicalPlayer physicalPlayer)
        {
            Console.WriteLine("Attacked by physical player! ");
            base.Damaged(1000);
        }

        public override void DamagedBy(MagicalPlayer magicalPlayer)
        {
            Console.WriteLine("Attacked by magical player! ");
            base.Damaged(100);
        }
    }
}
