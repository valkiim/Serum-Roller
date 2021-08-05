using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serum_Roller.effects
{
    class GreenEffects : serumEffects
    {
        public GreenEffects()
        {
            Blatants = new sEffect[11];
            Latents = new sEffect[11];

            List<string[]> BlatantEffects = new List<string[]>();
            List<string[]> LatentEffects = new List<string[]>();
            //Blatants
            BlatantEffects.Add(new string[] { "rightNow", "removeAspect", "notNatHighest" });
            BlatantEffects.Add(new string[] { "addAspect", "Red Fox", "N", "growNew", "Red Fox", "Tail" });
            BlatantEffects.Add(new string[] { "addAspect", "Kobold", "Y" });
            BlatantEffects.Add(new string[] { "addAspect", "Green Anaconda", "Y" });
            BlatantEffects.Add(new string[] { "transform", "random", "highest" });
            BlatantEffects.Add(new string[] { "addAspect", "random", "random" });
            BlatantEffects.Add(new string[] { "rightNow", "removeAspect", "lowest", "addAspect", "highest", "Y" });
            BlatantEffects.Add(new string[] { "growNew", "natural", "random" });
            BlatantEffects.Add(new string[] { "transform", "Paven", "wings", "addAspect", "Paven", "N" });
            BlatantEffects.Add(new string[] { "transform", "Giraffe", "head", "addAspect", "Giraffe", "N" });
            BlatantEffects.Add(new string[] { "addAspect", "Dragon", "N", "transform", "Dragon", "wings" });
            //Latents
            string[] latentlist = new string[11];
            LatentEffects.Add(new string[] { "nextGreen", "replaceBothWith", "Pink" });
            LatentEffects.Add(new string[] { "nextSerum", "addBlatant", "Blue" });
            LatentEffects.Add(new string[] { "applyNatural", "Goo", "N" });
            LatentEffects.Add(new string[] { "rawText", "The subjects fluids now proliferate their presently-highest aspect.", "" });
            LatentEffects.Add(new string[] { "rawText", "The subject's Hue shifts arbitrarily. Strong willed subjects may be able to direct this.", "" });
            LatentEffects.Add(new string[] { "rightNow", "greenWillpower", "" });
            LatentEffects.Add(new string[] { "rightNow", "greenAddiction", "" });
            LatentEffects.Add(new string[] { "rightNow", "addBlatant", "Green" });
            LatentEffects.Add(new string[] { "applyNatural", "Synthetic", "" });
            LatentEffects.Add(new string[] { "nextGreen", "repeatBlatant", "", "nextGreen", "noLatent", "" });
            LatentEffects.Add(new string[] { "rightNow", "hybridize", "" });
            for (int i = 0; i <= 10; i++)
            {
                Blatants[i] = new sEffect((i + 2), BlatantEffects[i]);
                Latents[i] = new sEffect((i + 2), LatentEffects[i]);
            }
        }

        // These take a die roll, and are expected to adjust it to their data format. 
        public override sEffect GetBlatantSEffect(int roll)
        {
            return Blatants[roll - 2];
        }

        public override sEffect GetLatentSEffect(int roll)
        {
            return Latents[roll - 2];
        }
    }
}
