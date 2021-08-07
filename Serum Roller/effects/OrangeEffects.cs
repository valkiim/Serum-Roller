using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serum_Roller;

namespace Serum_Roller
{
    class OrangeEffects : serumEffects
    {
        public OrangeEffects()
        {
            Blatants = new sEffect[11];
            Latents = new sEffect[11];

            List<string[]> BlatantEffects = new List<string[]>();
            List<string[]> LatentEffects = new List<string[]>();
            // blatants
            BlatantEffects.Add(new string[] { "grow", "production", "0.2", "applyAspect", "Grey Rat", "N" });
            BlatantEffects.Add(new string[] { "shrink", "height", "0.1", "grow", "breasts", "0.2", "grow", "ass", "0.2" });
            BlatantEffects.Add(new string[] { "grow", "penis", "0.1", "grow", "production", "0.1", "grow", "height", "0.1", "applyAspect", "Horse", "N", "condition", "Is the Penis longer than 30% of the subject's height?", "transform", "Penis", "Horse" });
            BlatantEffects.Add(new string[] { "grow", "tail", "0.15" });
            BlatantEffects.Add(new string[] { "grow", "height", "0.15", "grow", "muscles", "0.15" });
            BlatantEffects.Add(new string[] { "grow", "random", "0.10" });
            BlatantEffects.Add(new string[] { "grow", "tongue", "0.15" });
            BlatantEffects.Add(new string[] { "grow", "ass", "0.15" });
            BlatantEffects.Add(new string[] { "grow", "fat", "0.15" });
            BlatantEffects.Add(new string[] { "grow", "penis", "0.1", "grow", "tail", "0.1", "grow", "height", "0.1", "applyAspect", "Dragon", "N", "rawText", "If the subject has exactly one penis, they grow a second." });
            BlatantEffects.Add(new string[] { "growMax", "penis", "1", "growMax", "balls", "4", "growMax", "vagina", "1", "grow", "penis", "0.15", "grow", "production", "0.15", "grow", "breasts", "0.15" });
            // latents
            LatentEffects.Add(new string[] { "nextSize", "invertSerum", "" });
            LatentEffects.Add(new string[] { "decrease", "shrinkEff", "0.1" });
            LatentEffects.Add(new string[] { "nextSerum", "repeatBlatant", "" });
            LatentEffects.Add(new string[] { "grow", "Penis", "0.10", "grow", "Balls", "0.10", "grow", "Breasts", "0.10", "grow", "Ass", "0.10" });
            LatentEffects.Add(new string[] { "increase", "growthEff", "0.1" });
            LatentEffects.Add(new string[] { "grow", "height", "0.1" });
            LatentEffects.Add(new string[] { "increase", "growthEff", "0.2" });
            LatentEffects.Add(new string[] { "rightNow", "addBlatant", "Green" });
            LatentEffects.Add(new string[] { "rightNow", "repeatBlatant", "" });
            LatentEffects.Add(new string[] { "grow", "height", "1", "increase", "growthEff", "1" });
            LatentEffects.Add(new string[] { "nextOrange", "replaceBothWith", "Purple" });
            
            for (int i = 0; i<=10; i++)
            {
                Blatants[i] = new sEffect((i + 2), BlatantEffects[i]);
                Latents[i] = new sEffect((i + 2), LatentEffects[i]);
            }
        }

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
