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

        //all of these process the die roll
        public sEffect[] RollResults(string colour, int first, int second)
        {
            sEffect[] results = new sEffect[2];
            if (colour.Equals("Blue"))
            {
                results[0] = GetBlueBlatant(first);
                results[1] = GetBlueLatent(second);
            }
            else if (colour.Equals("Green"))
            {
                results[0] = GetGreenBlatant(first);
                results[1] = GetGreenLatent(second);
            }
            else if (colour.Equals("Orange"))
            {
                results[0] = GetOrangeBlatant(first);
                results[1] = GetOrangeLatent(second);
            }
            else if (colour.Equals("Pink"))
            {
                results[0] = GetPinkBlatant(first);
                results[1] = GetPinkLatent(second);
            }
            else
            {
                //(colour == purple, but a bit of a failsafe. 
                results[0] = GetPurpleBlatant(first);
                results[1] = GetPurpleLatent(second);
            }
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
