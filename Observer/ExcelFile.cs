using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
   public  class ExcelFile
    {
        List<Chart> charts = new List<Chart>();

        public void Attach(Chart observer)
        {
            charts.Add(observer);
        }
        public void detach(Chart observer)
        {
            charts.Remove(observer);
        }
        public void notifyChange()
        {
            foreach (var item in charts)
            {
                item.UpdateData($"Data of chart {charts.IndexOf(item)} changed!");
            }
        }
    }
}
