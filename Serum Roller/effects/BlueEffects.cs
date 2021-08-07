using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serum_Roller
{
    class BlueEffects : serumEffects
    {
        public BlueEffects()
        {
            Blatants = new sEffect[11];
            Latents = new sEffect[11];
            
            List<string[]> BlatantEffects = new List<string[]>();
            List<string[]> LatentEffects = new List<string[]>();
            //Blatants
            BlatantEffects.Add(new string[] { "decrease", "growthEff", "1" });
            BlatantEffects.Add(new string[] { "condition", "Does the subject willingly nullify a genital?", "shrink", "genital", "1", "else", "shrink", "height", "0.25" });
            BlatantEffects.Add(new string[] { "decrease", "height", "0.15", "condition", "Does this reduce height below 12in?", "applyAspect", "Figurine", "N" });
            BlatantEffects.Add(new string[] { "condition", "Any pressure applied to the subject will cause Shrinking!", "shrink", "height", "0.1"});
            BlatantEffects.Add(new string[] { "shrink", "penis", "0.2", "shrink", "penis", "0.2", "alternative", "shrink", "height", "0.2" });
            BlatantEffects.Add(new string[] { "shrink", "random", "0.1" });
            BlatantEffects.Add(new string[] { "shrink", "height", "0.15", "applyAspect", "Kobold", "N"});
            BlatantEffects.Add(new string[] { "shrink", "fat", "0.1", "grow", "muscle", "0.1" });
            BlatantEffects.Add(new string[] { "shrink", "height", "0.15", "applyAspect", "Mouse", "N" });
            BlatantEffects.Add(new string[] { "rightNow", "addBlatant", "Blue", "rightNow", "repeatBlatant", "" });
            BlatantEffects.Add(new string[] { "shrink", "height", "0.5" });
            // Latents
            LatentEffects.Add(new string[] { "nextTwo", "doubleDose", "" });
            LatentEffects.Add(new string[] { "decrease", "growthEff", "0.2" });
            LatentEffects.Add(new string[] { "increase", "shrinkEff", "0.4" });
            LatentEffects.Add(new string[] { "transform", "random", "random" });
            LatentEffects.Add(new string[] { "untilOrangeOrPink", "replaceBothWith", "Blue", "untilOrangeOrPink", "noLatent", "" });
            LatentEffects.Add(new string[] { "increase", "shrinkEff", "0.2" });
            LatentEffects.Add(new string[] { "nextSerum", "repeatBlatant", ""});
            LatentEffects.Add(new string[] { "thisAndNext", "addLatent", "Blue" });
            LatentEffects.Add(new string[] { "rightNow", "add50Blat", "Orange"});
            LatentEffects.Add(new string[] { "RawText", "The Subject can store up to 10% of their size in an extra dimensional battery, retrievable at will. Increases by 10% each time this latent is afflicted, capping at 100%", "" });
            LatentEffects.Add(new string[] { "RawText", "Any further shrinking will apply growth to the attendant/researcher.", "" });
            
            for (int i = 0; i <= 10; i++)
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
