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
            string[] blatantlist = new string[11];
            blatantlist[0] = "All body parts become the highest aspect. The subject's natural is replaced with their Highest Aspect.";
            blatantlist[1] = "The subject becomes a physical copy of the Attendant/Researcher.";
            blatantlist[2] = "The subject is offered a selection of generic but attractive bodies to transfer their consciousness into. Their existing body is forfeit to Val for further study.";
            blatantlist[3] = "A random Location returns to Natural (shape and Size), If that location is already natural, it spreads like normal. If a subject's entire body is already natural, It roll once on the Orange, Blue, and Green Blatant tables.";
            blatantlist[4] = "The subject's size shifts towards their original size by 10%";
            blatantlist[5] = "Remove the subject's lowest aspect, and remove all traits affiliated with it. Said bodyparts shift to the subject's Highest Aspect. Should the subject lack a non-highest aspect, Shift their size 10% closer to natural.";
            blatantlist[6] = "Roll Location, The subject's location returns to their High Aspect's type with Natural size, shape, and number.";
            blatantlist[7] = "Growth and shrinking effectiveness both move 50%, towards 100%. If this would shift a value past 100%, set it to 100% instead.";
            blatantlist[8] = "The subject's entire body is returned to their original shape, but 50% taller than normal.";
            blatantlist[9] = "Randomly select an aspect the subject lacks. The Subject's natural becomes that, and all bodyparts transform to match";
            blatantlist[10] = "The subject's body is returned to the state it was in before this process. The next serum has Quadruple effecty (blatant and Latent).";
            string[] latentlist = new string[11];
            latentlist[0] = "Lost aspects cannot be re-attained.";
            latentlist[1] = "If applicable, The blatant effects 1 additional location, or twice as much size.";
            latentlist[2] = "The next serum chosen must be either Pink or Orange. Green and Blue serums have no effect until this is satisfied.";
            latentlist[3] = "Blue and Orange serums are inverted until one is chosen. Blue serums roll on Orange, and Vice Versa.";
            latentlist[4] = "The subject loses an additional, unwanted aspect.";
            latentlist[5] = "Roll an additional blatant";
            latentlist[6] = "The subject gains an additional aspect at random. This does not result in any immediate changes.";
            latentlist[7] = "The subject's genitals' natural size is increased by 50%. This does not affect their current size.";
            latentlist[8] = "The next serum chosen must be either Pink or Blue. Green and orange serums have no effect until this is satisfied.";
            latentlist[9] = "The next serum chosen must be either Pink or Green. Blue and orange serums have no effect until this is satisfied.";
            latentlist[10] = "The subject rolls 3 times for Blatant and Latent on their next serum, and may choose whichever results they desire. The subject is Quite aware of this latent.";
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
