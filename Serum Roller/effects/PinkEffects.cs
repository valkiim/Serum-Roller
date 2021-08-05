using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serum_Roller
{
    class PinkEffects : serumEffects
    {

        public PinkEffects()
        {
            Blatants = new sEffect[11];
            Latents = new sEffect[11];

            List<string[]> BlatantEffects = new List<string[]>();
            List<string[]> LatentEffects = new List<string[]>();
            //blatants
            BlatantEffects.Add(new string[] { "rawText", "All body parts become the highest aspect. The subject's natural is replaced with their Highest Aspect.", "" });
            BlatantEffects.Add(new string[] { "rawText", "The subject becomes a physical copy of the Attendant/Researcher!", "" });
            BlatantEffects.Add(new string[] { "rawText", "The subject is offered a selection of generic but attractive bodies to transfer their consciousness into. Their existing body is forfeit to Val for further study.", "" });
            BlatantEffects.Add(new string[] { "transform", "random", "Natural", "condition", "Was there anything left to transform?", "rightNow", "chaosSerum", "" });
            BlatantEffects.Add(new string[] { "condition", "Is the subject larger than their natural size?", "shrink", "height", "0.1", "else", "grow", "height", "0.1" });
            BlatantEffects.Add(new string[] { "rightNow", "removeAspect", "lowest" });
            BlatantEffects.Add(new string[] { "transform", "random", "highest" });
            BlatantEffects.Add(new string[] { "normalize", "growthEff", "0.5", "normalize", "shrinkEff", "0.5" });
            BlatantEffects.Add(new string[] { "rightNow", "removeAspect", "All", "grow", "height", "0.5" });
            BlatantEffects.Add(new string[] { "applyNatural", "Random", "Y" });
            BlatantEffects.Add(new string[] { "rawText", "The subject's body is returned to the state it was in before this process", "", "nextSerum", "doubleDose", "", "nextSerum", "doubleDose", "" });
            //Latents
            LatentEffects.Add(new string[] { "rawText", "Lost aspects cannot be re-attained.", "" });
            LatentEffects.Add(new string[] { "rightNow", "repeatBlatant", "" });
            LatentEffects.Add(new string[] { "nextSerum", "onlyPinkOr", "Orange" });
            LatentEffects.Add(new string[] { "nextSize", "invertSerum", "" });
            LatentEffects.Add(new string[] { "rightNow", "removeAspect", "lowest" });
            LatentEffects.Add(new string[] { "rightNow", "addBlatant", "Pink" });
            LatentEffects.Add(new string[] { "addAspect", "random", "n"});
            LatentEffects.Add(new string[] { "rawText", "The subject's genitals' natural size is increased by 50%. This does not affect their current size. Val is still working on a clever implementation of this, sorry!"});
            LatentEffects.Add(new string[] { "nextSerum", "onlyPinkOr", "Blue" });
            LatentEffects.Add(new string[] { "nextSerum", "onlyPinkOr", "Green" });
            LatentEffects.Add(new string[] { "nextSerum", "extremeAdvantage", "" });
            
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
