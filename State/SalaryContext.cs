using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class SalaryContext
    {
        private Level currentLevel;
        private int DateOfWork;
        public SalaryContext()
        {
            currentLevel = new InternshipLevel();
            DateOfWork = 0;
        }

        public void SetLevel(Level newLevel )
        {
            currentLevel = newLevel;
            DateOfWork += 100;
        }

        public void GetSalary()
        {
            currentLevel.GetSalary();
            Console.WriteLine($"Work: {DateOfWork} days. ");
            Console.WriteLine();
        }
    }
}
