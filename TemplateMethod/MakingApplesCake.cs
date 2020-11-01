using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class MakingApplesCake : MakingCakeTemplate
    {
        public override void GetIngredient()
        {
            Console.WriteLine("Getting Apples Cake's ingredients. ");
        }

        public override void GrillIngredient()
        {
            Console.WriteLine("Grilling Apples Cake's ingredients. ");
        }

        public override void MixIngedient()
        {
            Console.WriteLine("Mixing Apples Cake's ingredients. ");
        }
    }
}
