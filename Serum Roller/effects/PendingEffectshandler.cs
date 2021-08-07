using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serum_Roller.effects
{
    public class PendingEffectsHandler
    {
        List<PendingEffect> PE;
        public PendingEffectsHandler()
        {
            PE = new List<PendingEffect>();
        }
        public void AddEffect(string timing, string effect, string parame)
        {
            PE.Add(new PendingEffect(timing, effect, parame));
        }
        List<PendingEffect> ExtractEffects(string trigger)
        {
            List<PendingEffect> output = new List<PendingEffect>();
            for (int i = PE.Count - 1; i >= 0; i--)
            {
                if (PE[i].Timing.Equals(trigger))
                {
                    output.Add(new PendingEffect(PE[i]));
                    PE.RemoveAt(i);
                }
            }
            return output;
        }
        public List<PendingEffect> TriggeredEffects(string colour)
        {
            List<PendingEffect> output = new List<PendingEffect>();
            // returns a list of triggered serum effects, based on serum injested
            // feeding this function "none" will check for and remove "right now" effects. 
            if (colour.Equals("none"))
            {
                output = ExtractEffects("rightNow");
                output.AddRange(ExtractEffects("thisAndNext"));
            }
            else if(colour.Equals("Blue"))
            {
                output = ExtractEffects("nextSerum");
                output.AddRange(ExtractEffects("nextTwo"));
                output.AddRange(ExtractEffects("nextBlue"));
                output.AddRange(ExtractEffects("nextSize"));
                output.AddRange(ExtractEffects("untilOrangeOrPink"));
            }
            else if (colour.Equals("Green"))
            {
                output = ExtractEffects("nextSerum");
                output.AddRange(ExtractEffects("nextTwo"));
                output.AddRange(ExtractEffects("nextGreen"));
                output.AddRange(ExtractEffects("untilOrangeOrPink"));
            }
            else if (colour.Equals("Orange"))
            {
                output = ExtractEffects("nextSerum");
                output.AddRange(ExtractEffects("nextTwo"));
                output.AddRange(ExtractEffects("nextOrange"));
                output.AddRange(ExtractEffects("nextSize"));
                output.AddRange(ExtractEffects("untilOrangeOrPink"));
            }
            else if (colour.Equals("Pink"))
            {
                output = ExtractEffects("nextSerum");
                output.AddRange(ExtractEffects("nextTwo"));
                output.AddRange(ExtractEffects("nextPink"));
                output.AddRange(ExtractEffects("untilOrangeOrPink"));
            }
            else if (colour.Equals("Purple"))
            {
                output = ExtractEffects("nextSerum");
                output.AddRange(ExtractEffects("nextTwo"));
                output.AddRange(ExtractEffects("nextPurple"));
                output.AddRange(ExtractEffects("untilOrangeOrPink"));
            }

            else
            {   // serum of unknown or otherwise game breaking colour
                output = ExtractEffects("nextSerum");
            }
            return output;
        }
    }
}
