using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
   public abstract class MakingCakeTemplate
    {
        public  void CreateCake()
        {
            GetIngredient();
            MixIngedient();
            GrillIngredient();
        }

        public void GetChefInformation()
        {
            Console.WriteLine("This cake is created by AAA Co.Ltd");
        }
        public abstract  void GetIngredient();
        public abstract void MixIngedient();
        public abstract void GrillIngredient();

    }
}
