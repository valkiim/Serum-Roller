using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serum_Roller.effects
{
    class PurpleEffects : serumEffects
    {

        public PurpleEffects()
        {
            Blatants = new sEffect[11];
            Latents = new sEffect[11];

            List<string[]> BlatantEffects = new List<string[]>();
            List<string[]> LatentEffects = new List<string[]>();
            //Blatants
            BlatantEffects.Add(new string[] { "rawText", "The subject's Size theft aura is now 5 meters, or increases by 5 meters"});
            BlatantEffects.Add(new string[] { "growMax", "head", "3", "growMax", "tail", "3", "grow", "height", "0.15" });
            BlatantEffects.Add(new string[] { "applyNatural", "Synthetic", "modify" });
            BlatantEffects.Add(new string[] { "rawText", "If the subject has a penis, but does not have tailcocks, they gain 2 tail cocks. These special endowments are double the size of the subject's normal endowments.", "", "transform", "lower body", "Naga", "grow", "height", "0.1", "grow", "tail", "0.1", "grow", "genitals", "0.1" });
            BlatantEffects.Add(new string[] { "growMax", "wings", "2", "grow", "height", "0.1", "grow", "tail", "0.1", "grow", "genitals", "0.1", "grow", "production", "0.15" });
            BlatantEffects.Add(new string[] { "rightNow", "AddBlatant", "Purple", "nextSerum", "doubleDose", "" });
            BlatantEffects.Add(new string[] { "rawText", "The subject gains injection ports, which are not quite implemented yet", "", "increase", "growthEff", "0.5"});
            BlatantEffects.Add(new string[] { "grow", "fat", "0.1", "grow", "height", "0.1", "grow", "production", "0.2" });
            BlatantEffects.Add(new string[] { "growMax", "Arm", "4", "grow", "height", "0.15", "grow", "genitals", "0.15" });
            BlatantEffects.Add(new string[] { "growMax", "Bellymaw", "1", "rawText", "If the subject already had a bellymaw, they become a hexataur", "", "grow", "genitals", "0.1", "grow", "production", "0.1" });
            BlatantEffects.Add(new string[] { "growMax", "eyes", "4", "grow", "genitals", "0.2", "grow", "breasts", "0.2", "grow", "production", "0.1" });
            //Latents
            LatentEffects.Add(new string[] { "rawText", "A random person in sight shrinks by 10%", "", "grow", "random", "0.1" });
            LatentEffects.Add(new string[] { "rawText", "The subject's horns grow more magnificent", "" });
            LatentEffects.Add(new string[] { "nextSerum", "doubleDose", "" });
            LatentEffects.Add(new string[] { "grow", "breasts", "0.1" });
            LatentEffects.Add(new string[] { "grow", "genitals", "0.1" });
            LatentEffects.Add(new string[] { "increase", "growthEff", "0.2" });
            LatentEffects.Add(new string[] { "grow", "tail", "0.1" });
            LatentEffects.Add(new string[] { "grow", "height", "0.1", "grow", "genitals", "0.1", "grow", "production", "0.1" });
            LatentEffects.Add(new string[] { "grow", "production", "0.2" });
            LatentEffects.Add(new string[] { "grow", "all", "0.2" });
            LatentEffects.Add(new string[] { "multiply", "growthEff", "2" });
            
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
