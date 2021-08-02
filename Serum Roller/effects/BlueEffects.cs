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
            string[] blatantlist = new string[11];
            blatantlist[0] = "The subject's growth susceptibility decreases by 100%";
            blatantlist[1] = "The subject chooses an genical, That genital is nolonger present. If the subject has no genitals, or wants to prevent this, they shrink 25%";
            blatantlist[2] = "The subject shrinks by 15%, if this makes them less than 12 inches tall, their natural becomes synthetic.";
            blatantlist[3] = "The subject's body becomes unstable, any pressure causes 10% shrinkage. This effect ends after the next serum";
            blatantlist[4] = "The subjects penis and production, if any, shrinks by 20%. If they are absent, the subject shrinks by 20% instead";
            blatantlist[5] = "Roll Location, It wshrinks by 10%";
            blatantlist[6] = "The subject shrinks by 25% of their current height and gains the Kobold aspect. if already present, Transform a random location. If the subject is completely kobold, their natural becomes kobold";
            blatantlist[7] = "The subject loses 10% of their pudge, and becomes 10% more muscular";
            blatantlist[8] = "The subject shrinks 25% and gains the Mouse aspect. If already present, transform a random location";
            blatantlist[9] = "This serum was calibrated for someone of a different size. Roll again, and apply the blatant twice";
            blatantlist[10] ="The subject becomes either half their current height, or one inch tall. whichever is smaller. Unaffected by susceptibility.";
            string[] latentlist = new string[11];
            latentlist[0] = "The next two serums are double doses, applying all effects twice.";
            latentlist[1] = "The subject's growth susceptibility decreases by 20%";
            latentlist[2] = "The subject's shrinking susceptibility increases by 40%";
            latentlist[3] = "Transform a location at random, using a random aspect taken from the attendant or environment.";
            latentlist[4] = "Until the subject drinks a Blue or Pink serum, roll Blue Blatant instead. Do not roll Latent.";
            latentlist[5] = "The subject's shrinking susceptibility increases by 20%";
            latentlist[6] = "This blatant will occur again immdiately after the next serum";
            latentlist[7] = "Roll an additional latent, It will affect this serum, and the next.";
            latentlist[8] = "This serum also causes an Orange blatant, with 50% effectiveness. This is unaffected by the subject's susceptibility.";
            latentlist[9] = "The Subject can store up to 10% of their size in an extra dimensional battery, retrievable at will. Increases by 10% each time this latent is afflicted, capping at 100%";
            latentlist[10] = "Any further shrinking will apply growth to the attendant/researcher";
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
