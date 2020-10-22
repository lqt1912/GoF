using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            SalaryContext salaryContext = new SalaryContext();
            salaryContext.GetSalary();

            salaryContext.SetLevel(new JuniorLevel());
            salaryContext.GetSalary();

            salaryContext.SetLevel(new SeniorLevel());
            salaryContext.GetSalary();
        }
    }
}
