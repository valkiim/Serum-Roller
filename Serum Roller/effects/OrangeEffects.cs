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
            string[] blatantlist = new string[11];
            blatantlist[0] = "The subject's production increases by 20%, they gain the Rat Aspect. Transform a Location at random if already present";
            blatantlist[1] = "The subject shrinks 10%, their breasts and ass grow 20%";
            blatantlist[2] = "The subject's penis grows 10%. if longer than 30% of the subjects height/length,  it becomes equine. Increase production and height by 10%. The subject gains the Equine aspect. Transform a location at ranom if already present.";
            blatantlist[3] = "The subject's tail grows 15% longer";
            blatantlist[4] = "The subject's body grows 15% larger and more muscular";
            blatantlist[5] = "Roll Location, grow the result by 10%";
            blatantlist[6] = "The subject's tongue grows 15% longer";
            blatantlist[7] = "The subject's ass grows 15% larger";
            blatantlist[8] = "The Subject becomes 15% pudgier";
            blatantlist[9] = "If the subject has 1 penis, they gain a second. Any penises present grow 10%. The subject's tail and Height grow by 10%. The subject gains the Dragon Aspect, transform a Location at random if already present";
            blatantlist[10] = "The subject gains the Vessarian aspect, if absent. If the subject lacks penises 20% of their hight, they gain one of that size, otherwise, the subject's penises grow 15%. If the subject lacks testes, they gain up to four, otherwise, production increases by 10%. If the subject lacks a vagina, they gain one. Otherwise, production increases 10%. The subject's breasts grow 10%.";
            string[] latentlist = new string[11];
            latentlist[0] = "The next time the subject drinks an orange or blue serum, Roll from the opposite table for both Blatant and Latent effects";
            latentlist[1] = "the subject's shrinking susceptibility decreases by 10%.";
            latentlist[2] = "The Blatant effect occurs again after the next serum";
            latentlist[3] = "The subject's cock, balls, breasts, and ass all grow 10% larger";
            latentlist[4] = "The subject's growth susceptibility increases by 10%";
            latentlist[5] = "The subject grows 10% larger.";
            latentlist[6] = "The subject's growth susceptibility increases by 20%";
            latentlist[7] = "Roll an additional Green blatant effect, and apply it immediately";
            latentlist[8] = "The Blatant Effect occurs twice";
            latentlist[9] = "The Subject Doubles in height, and their growth suscepotibility increases by 100%";
            latentlist[10] = "The next orange is purple, Roll on purple for both Blatant and Latent Effects";
            for (int i = 0; i<=10; i++)
            {
                Blatants[i] = new sEffect((i + 2), blatantlist[i]);
                Latents[i] = new sEffect((i + 2), latentlist[i]);
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
