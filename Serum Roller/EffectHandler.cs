using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serum_Roller
{
    public class EffectHandler
    {
        BlueEffects blue;
        effects.GreenEffects green;
        OrangeEffects orange;
        PinkEffects pink;
        effects.PurpleEffects purple;
        public EffectHandler()
        {
            blue = new BlueEffects();
            green = new effects.GreenEffects();
            orange = new OrangeEffects();
            pink = new PinkEffects();
            purple = new effects.PurpleEffects();
        }
        public sEffect get(string colour, string effectType, int roll)
        {
            if (colour.Equals("Blue"))
            {
                if (effectType.Equals("Blatant"))
                {return GetBlueBlatant(roll);}
                else
                {return GetBlueLatent(roll);}
            }
            else if (colour.Equals("Green"))
            {
                if (effectType.Equals("Blatant"))
                {return GetGreenBlatant(roll);}
                else
                {return GetGreenLatent(roll);}
            }
            else if (colour.Equals("Orange"))
            {
                if (effectType.Equals("Blatant"))
                {return GetOrangeBlatant(roll);}
                else
                {return GetOrangeLatent(roll);}
            }
            else if (colour.Equals("Pink"))
            {
                if (effectType.Equals("Blatant"))
                {return GetPinkBlatant(roll);}
                else
                {return GetPinkLatent(roll);}
            }
            else
            {
                //(colour == purple, but a bit of a failsafe. 
                if (effectType.Equals("Blatant"))
                {return GetPurpleBlatant(roll);}
                else
                {return GetPurpleLatent(roll);}
            }
        }
        //all of these process the die roll
        public sEffect[] RollResults(string colour, int first, int second)
        {
            sEffect[] results = new sEffect[2];
            results[0] = get(colour, "Blatant", first);
            results[1] = get(colour, "Latent", second);
            return results;
        }
        sEffect GetBlueBlatant(int i)
        {
            return blue.GetBlatantSEffect(i);
        }
        sEffect GetGreenBlatant(int i)
        {
            return green.GetBlatantSEffect(i);
        }
        sEffect GetOrangeBlatant(int i)
        {
            return orange.GetBlatantSEffect(i);
        }
        sEffect GetPinkBlatant(int i)
        {
            return pink.GetBlatantSEffect(i);
        }
        sEffect GetPurpleBlatant(int i)
        {
            return purple.GetBlatantSEffect(i);
        }
        sEffect GetBlueLatent(int i)
        {
            return blue.GetLatentSEffect(i);
        }
        sEffect GetGreenLatent(int i)
        {
            return green.GetLatentSEffect(i);
        }
        sEffect GetOrangeLatent(int i)
        {
            return orange.GetLatentSEffect(i);
        }
        sEffect GetPinkLatent(int i)
        {
            return pink.GetLatentSEffect(i);
        }
        sEffect GetPurpleLatent(int i)
        {
            return purple.GetLatentSEffect(i);
        }
    }
}
