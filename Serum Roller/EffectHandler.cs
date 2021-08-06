using Serum_Roller.effects;
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
        UserLog subject;
        List<string> futureEffects;
        Dieroller die;
        AspectRoller AR;
        public EffectHandler(string userNatural)
        {
            blue = new BlueEffects();
            green = new effects.GreenEffects();
            orange = new OrangeEffects();
            pink = new PinkEffects();
            purple = new effects.PurpleEffects();
            Aspect usrNat = new Aspect("UserInput", "UserInput", "UserInput", userNatural);
            subject = new UserLog(usrNat);
            die = new Dieroller();
            AR = AspectRoller.Instance;
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
        public string RollResults(string colour, int first, int second)
        {
            // this function passes the ball off to the recursive effect processor
            
            string[] LatentResults = get(colour, "Latent", second).ToStringArr();
            string[] BlatantResults = get(colour, "Blatant", first).ToStringArr();
            
            string result = ParseEffects(LatentResults, 0);
            result = result + " " + ParseEffects(BlatantResults, 0);

            return "notdoneyet";
        }
        private string pCondition(string[] Eff, int i)
        {
            conditionForm query = new conditionForm(Eff[i + 1]);
            if (query.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
            {
                return ParseEffects(Eff, i + 2);
            }
            else if (Eff.Length >= (i + 5) && Eff[i + 5].Equals("else"))
            {   // I+1 = condition message, I+2/3/4 =effect, I+5 = else, or next condition queue
                return ParseEffects(Eff, i + 6);
            }
            else
            {
                return ParseEffects(Eff, i + 5);
            }
        }
        private string pGrow(string[] Eff, int i)
        {   //growth effect, based off growthEff
            string location, percent;
            double numPercent;
            location = Eff[i + 1];
            numPercent = double.Parse(Eff[i + 2]);
            numPercent = subject.getAttribute("growthEff") * numPercent;
            percent = ToPercent(numPercent);
            return "The Subject's " + location + " grows by " + percent + "%.\n" + ParseEffects(Eff, i + 3);
        }
        private string pShrink(string[] Eff, int i)
        {   //shrink effect, based off shrinkEff
            string location, percent;
            double numPercent;
            location = Eff[i + 1];
            numPercent = double.Parse(Eff[i + 2]);
            numPercent = subject.getAttribute("shrinkEff") * numPercent;
            percent = ToPercent(numPercent);
            return "The Subject's " + location + " shrinks by " + percent + "%.\n" + ParseEffects(Eff, i + 3);
        }
        private string pIncrease(string[] Eff, int i)
        {   //increases a user attribute
            bool moddResolved = subject.ModifyAttAdd(Eff[i + 1], double.Parse(Eff[i + 2]));
            if (Eff[i + 1].Equals("growthEff"))
            {
                return "The Subject has a feeling that they could easily grow larger.\n" + ParseEffects(Eff, i + 3);
            }
            else if (Eff[i + 1].Equals("shrinkEff"))
            {
                return "The Subject has a feeling that they could easily shrink smaller.\n" + ParseEffects(Eff, i + 3);
            }
            else
            {
                if (moddResolved)
                {
                    return "there is not an automated message for " + Eff[i + 1] + " but the effect was modified successfully.\n" + ParseEffects(Eff, i + 3);
                }
                else
                {
                    return "there is not an automated message for " + Eff[i + 1] + " and the effect was not found.\n" + ParseEffects(Eff, i + 3);
                }
            }
        }
        private string pDecrease(string[] Eff, int i)
        {   //decrease a user attribute
            bool moddResolved = subject.ModifyAttAdd(Eff[i + 1], (-1.0 * double.Parse(Eff[i + 2])));
            if (Eff[i + 1].Equals("growthEff"))
            {
                return "The Subject has a feeling that it is harder to grow larger.\n" + ParseEffects(Eff, i + 3);
            }
            else if (Eff[i + 1].Equals("shrinkEff"))
            {
                return "The Subject has a feeling that they won't shrink smaller.\n" + ParseEffects(Eff, i + 3);
            }
            else
            {
                if (moddResolved)
                {
                    return "there is not an automated message for " + Eff[i + 1] + " but the effect was modified successfully.\n" + ParseEffects(Eff, i + 3);
                }
                else
                {
                    return "there is not an automated message for " + Eff[i + 1] + " and the effect was not found.\n" + ParseEffects(Eff, i + 3);
                }
            }
        }
        private string pNormalize(string[] Eff, int i)
        {
            string effect = Eff[i + 1];
            double sizeEff = subject.getAttribute(Eff[i+1]);
            double magnitude = double.Parse(Eff[i + 2]);
            bool success;
            if ((sizeEff <= (1.0+magnitude)) && (sizeEff >= (1.0-magnitude)))
            {
                success = subject.ModifyAttSet(effect, 1.0);
            }
            else if (sizeEff > (1.0 + magnitude))
            {
                success = subject.ModifyAttAdd(effect, -1.0*magnitude);
            }
            else
            {
                success = subject.ModifyAttAdd(effect, magnitude);
            }
            if (effect.Equals("growthEff"))
            {
                return "The subject's ability to grow has become slightly more normal" + ParseEffects(Eff, i + 3);
            }
            else if (effect.Equals("shrinkEff"))
            {
                return "The subject's ability to shrink has become slightly more normal" + ParseEffects(Eff, i + 3);
            }
            else
            {
                if (success)
                {
                    return "The subject attempted to normalize " + effect + ", which was not expected, but done.\n" + ParseEffects(Eff, i + 3);
                }
                else
                {
                    return "The subject attempted to normalize " + effect + ", which was not expected, and we did not know how to do.\n" + ParseEffects(Eff, i + 3);
                }

            }
        }
        private string pMultiply(string[] Eff, int i)
        {//increases a user attribute
            bool moddResolved = subject.ModifyAttMul(Eff[i + 1], double.Parse(Eff[i + 2]));
            if (double.Parse(Eff[i + 2]) > 1)
            {
                if (Eff[i + 1].Equals("growthEff"))
                {
                    return "The Subject has a feeling that they could easily grow larger.\n" + ParseEffects(Eff, i + 3);
                }
                else if (Eff[i + 1].Equals("shrinkEff"))
                {
                    return "The Subject has a feeling that they could easily shrink smaller.\n" + ParseEffects(Eff, i + 3);
                }
                else
                {
                    if (moddResolved)
                    {
                        return "There is not an automated message for " + Eff[i + 1] + " but the effect was modified successfully.\n" + ParseEffects(Eff, i + 3);
                    }
                    else
                    {
                        return "There is not an automated message for " + Eff[i + 1] + " and the effect was not found.\n" + ParseEffects(Eff, i + 3);
                    }
                }
            }
            else 
            {
                if (Eff[i + 1].Equals("growthEff"))
                {
                    return "The Subject has a feeling that it is harder to grow larger.\n" + ParseEffects(Eff, i + 3);
                }
                else if (Eff[i + 1].Equals("shrinkEff"))
                {
                    return "The Subject has a feeling that they won't shrink smaller.\n" + ParseEffects(Eff, i + 3);
                }
                else
                {
                    if (moddResolved)
                    {
                        return "There is not an automated message for " + Eff[i + 1] + " but the effect was modified successfully.\n" + ParseEffects(Eff, i + 3);
                    }
                    else
                    {
                        return "There is not an automated message for " + Eff[i + 1] + " and the effect was not found.\n" + ParseEffects(Eff, i + 3);
                    }
                }
            }
        }
        private string pTransform(string[] Eff, int i)
        {   // Eff[i]/Eff[i+1]/Eff[i+2] = transform/location/aspect
            string aspect = Eff[i + 1];
            string location = Eff[i + 2];
            if (aspect.Equals("random"))
            {
                aspect = AR.RollAspect().ToString();
            }
            if (location.Equals("random"))
            {
                location = Locationhandler.TFLocation(die.roll());
            }
            return "The Subject's " + location + " transforms into a(n) " + aspect + " " + location + "!\n" + ParseEffects(Eff, i + 3);
        }

        public string ParseEffects(string[] Eff, int i)
        {   //i = index, now delegated out!
            if (Eff.Length <= i) { return ""; } //preventing out of Range errors
            
            if (Eff[i].Equals("rawText"))
            {   // command is raw text
                return Eff[i + 1] + "\n" + ParseEffects(Eff, i + 3);
            }
            else if (Eff[i].Equals("condition"))
            {
                return pCondition(Eff, i);
            }
            else if (Eff[i].Equals("else"))
            {   //got here through invalid means, so like, dont worry about it. 
                return ParseEffects(Eff, i + 4);
            }
            else if (Eff[i].Equals("grow"))
            {
                return pGrow(Eff, i);
            }
            else if (Eff[i].Equals("shrink"))
            {
                return pShrink(Eff, i);
            }
            else if (Eff[i].Equals("increase"))
            {
                return pIncrease(Eff, i);
            }
            else if (Eff[i].Equals("decrease"))
            {
                return pDecrease(Eff, i);
            }
            else if (Eff[i].Equals("normalize"))
            {
                return pNormalize(Eff, i);
            }
            else if (Eff[i].Equals("multiply"))
            {
                return pMultiply(Eff, i);
            }
            else if (Eff[i].Equals("transform"))
            {
                return pTransform(Eff, i);
            }


            else return "";  //failsafe
        }
        string ToPercent(double AllegedDouble)
        {
            return AllegedDouble.ToString("P", System.Globalization.CultureInfo.InvariantCulture);
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
