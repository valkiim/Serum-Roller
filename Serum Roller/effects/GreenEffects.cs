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
            string[] blatantlist = new string[11];
            blatantlist[0] = "Remove all aspects except for the subject's Natural and High Aspect. All bodyparts that do not adhere to these aspects are randomly transformed to match.";
            blatantlist[1] = "The subject gains the Vulpine Aspect and a second tail. If they already have two tails, transform a random location. One the subject is fully Vulpine, they gain 7 more tails, up to 9, and Vulpine becomes their natural.";
            blatantlist[2] = "The subject gains the kobold aspect, and transforms a random location. The subject shrinks 20%, and their tail grows by the size lost. The subject knows what Latent this serum causes.";
            blatantlist[3] = "The subject gains the Serpent Aspect. The subject's lower body becomes a naga style tail. If already present, transform a random location. If the subject is fully serpent, it becomes Natural.";
            blatantlist[4] = "The subject transforms a Location at random into their highest aspect. If they have nothing to transform, roll again. Once all locations adhere to that aspect, it becomes natural.";
            blatantlist[5] = "The subject gains a new, random aspect, which is applied to a random location.";
            blatantlist[6] = "The subject replaces their lowest aspect with one of their choosing. Transform a random location with this Aspect.";
            blatantlist[7] = "Roll Location, the subject gains an extra pair of that, aligned to their Highest Aspect. If arms or legs are rolled, the subject gains one for each side. If waist down is rolled, the subject gains a taur body. If genitals are rolled, roll for specifics. Whole Body will generate a duplicate.";
            blatantlist[8] = "The subject gains the Paven Aspect and feathery wings. If already present, Transform a random location. If the subject's body is fully paven, Increase production by 50%, and paven becomes Natural.";
            blatantlist[9] = "The subject gains the Giraffe Aspect, their tongue and penis grow 10%, and their face and neck transform to Giraffe, increasing the subject's height by 20%. If they are already girrafian, transform a random location.";
            blatantlist[10] = "The subject becomes either half their current height, or one inch tall. whichever is smaller. Unaffected by susceptibility.";
            string[] latentlist = new string[11];
            latentlist[0] = "The next green serum rolls on Pink instead";
            latentlist[1] = "In addition to the green effect, Roll a Blue Blatant";
            latentlist[2] = "The subject's natural becomes Goo Aspect. The subject can freely shift body parts between known aspects. The subject may know up to three aspects, not including goo. Each time this effect occurs, increase the number known.";
            latentlist[3] = "The subject's fluids proliferate their highest aspect, transforming an imbiber's location at random. The aspect of this latent is determined when this serum is consumed, and only replaced when another serum of this type is consumed.";
            latentlist[4] = "The subject's Hue shifts arbitrarily. Strong willed subjects may be able to direct this.";
            latentlist[5] = "The subject can choose either the Location or Aspect of this blatant, If the blatant does not have either value, no effect.";
            latentlist[6] = "The subject has the compulsion to consume another green serum. Defying this results in an additional blue blatant. Indulging this results in an additional Orange Blatant. This compulsion only lasts for one serum.";
            latentlist[7] = "Roll a Second Green Blatant Effect";
            latentlist[8] = "The subject's natural is modified to Synthetic-natural. The subject's humanity is not Val's problem. A synthetic receiving this latent may either embrace it, allowinf for self modification, or reject it, becoming biological.";
            latentlist[9] = "The next Green serum the subject consumes is a duplicate of this, with no latent effect. Lasts until used.";
            latentlist[10] = "The subject chooses up to two of their aspects. Apply both aspects to the entirety of the subject's body. The aspects are then removed, and the subject's natural becomes a hybrid of the two.";
            for (int i = 0; i <= 10; i++)
            {
                Blatants[i] = new sEffect((i + 2), blatantlist[i]);
                Latents[i] = new sEffect((i + 2), latentlist[i]);
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
