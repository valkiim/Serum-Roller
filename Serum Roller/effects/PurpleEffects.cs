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
            string[] blatantlist = new string[11];
            blatantlist[0] = "The subject's Size theft aura is now 5 meters, or increases by 5 meters";
            blatantlist[1] = "If not present, the subject gains 2 more heads and tails, for a total of three. If the subject already has suck, they grow 15% taller. This effect tends towards scales.";
            blatantlist[2] = "The subject is not synthetic, The subject can overpower this with later effects if desires, but natively allows for modularity. Transform a location at random. This effect tends towards smooth plating.";
            blatantlist[3] = "If the subject has a penis, but does not have tailcocks, they gain 2 tail cocks. These special endowments are double the size of the subject's normal endowments. If that consition is already met or invalid, the subject instead shifts to a naga body. The subject, their tail, and genitals all grow 10%";
            blatantlist[4] = "If not present, the subject gains wings. If the subject already has wings, instead their height, tail and endowments grow 10%, and their production increases 15%.";
            blatantlist[5] = "Roll again with doubled effects";
            blatantlist[6] = "If not present, the subject gains injection ports, allowing for quadruple strength serums. The subject's growth susceptibility increases by 50%. This effect tends towards fur and furless limbs.";
            blatantlist[7] = "The subject's Pudge and height increase by 10%. The subject's production increases by 20%. This effect tends towards fur.";
            blatantlist[8] = "The subject gains up to 2 arms/forelimbs, up to a maximum of four. If the subject has four, they shift to a Feral bodystyle. The subject and their endowments grow 15% larger.";
            blatantlist[9] = "The subject gains a bellymaw. If the subject already has a bellymaw, they instead become a Hexataur. The subject's enbdowments and production increase 10%";
            blatantlist[10] = "The subject gains up to 2 eyes, to a maximum of four. The subject's endowments and breasts grow 20%, the subject's production increases 10%";
            string[] latentlist = new string[11];
            latentlist[0] = "Roll Location. A random person in sight shrinks by 10%, and the subject grows 10%.";
            latentlist[1] = "The subject's horns grow more magnificent.";
            latentlist[2] = "The next serum effect is applied twice.";
            latentlist[3] = "The subject's breasts grow 10% larger.";
            latentlist[4] = "The subject's endowments grow 10% larger.";
            latentlist[5] = "The subject's growth susceptibility increases by 20%.";
            latentlist[6] = "The subject's tail grows 10% longer.";
            latentlist[7] = "The subject's height, endowments, and production grow by 10%.";
            latentlist[8] = "The Subject's production increases by 20%";
            latentlist[9] = "The subject grows 20% larger in all respects.";
            latentlist[10] = "The subject's growth susceptibility doubles.";
            for (int i = 0; i <= 10; i++)
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
