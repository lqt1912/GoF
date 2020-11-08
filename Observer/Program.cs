using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelFile excelFile = new ExcelFile();
            excelFile.Attach(new Chart());
            excelFile.Attach(new Chart());
            excelFile.Attach(new Chart());
            excelFile.Attach(new Chart());

            excelFile.notifyChange();
        }
    }
}
