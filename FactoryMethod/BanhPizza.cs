using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class BanhPizza : Banh
    {
        //string season;

        public BanhPizza(/*string season*/)
        {
            //this.season = season;
            this.tenBanh = "Bánh pizza";
        }
        public override string GetTenBanh()
        {
            return this.tenBanh /*+ " vào mùa " + this.season*/;
        }
    }
}
