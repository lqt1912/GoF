using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class MakingGrapesCake : MakingCakeTemplate
    {
        public override void GetIngredient()
        {
            Console.WriteLine("Getting Grapes Cake's ingredients. ");
        }

        public override void GrillIngredient()
        {
            Console.WriteLine("Grilling Grapes Cake's ingredients. ");
        }

        public override void MixIngedient()
        {
            Console.WriteLine("Mixing Grapes Cake's ingredients. ");
        }
    }
}
