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
        GreenEffects green;
        OrangeEffects orange;
        PinkEffects pink;
        PurpleEffects purple;
        UserLog subject;
        List<string> fuEff;
        Dieroller die;
        AspectRoller AR;
        PendingEffectsHandler PEH;
        string currentSerum;
        int blRoll;
        int laRoll;

        public EffectHandler(string userNatural)
        {

            blue = new BlueEffects();
            green = new GreenEffects();
            orange = new OrangeEffects();
            pink = new PinkEffects();
            purple = new PurpleEffects();
            Aspect usrNat = new Aspect(userNatural);
            subject = new UserLog(usrNat);
            die = new Dieroller();
            AR = AspectRoller.Instance;
            PEH = new PendingEffectsHandler();  // metaserum effects
            fuEff = new List<string>();         // queueing up effects
            currentSerum = "none";
            blRoll = 0;
            laRoll = 0;
        }
        public string[] get(string colour, string effectType, int roll)
        {
            sEffect temp;
            if (colour.Equals("Blue"))
            {
                if (effectType.Equals("Blatant"))
                { temp = GetBlueBlatant(roll); }
                else
                { temp = GetBlueLatent(roll); }
            }
            else if (colour.Equals("Green"))
            {
                if (effectType.Equals("Blatant"))
                { temp = GetGreenBlatant(roll); }
                else
                { temp = GetGreenLatent(roll); }
            }
            else if (colour.Equals("Orange"))
            {
                if (effectType.Equals("Blatant"))
                { temp = GetOrangeBlatant(roll); }
                else
                { temp = GetOrangeLatent(roll); }
            }
            else if (colour.Equals("Pink"))
            {
                if (effectType.Equals("Blatant"))
                { temp = GetPinkBlatant(roll); }
                else
                { temp = GetPinkLatent(roll); }
            }
            else
            {
                //(colour == purple, but a bit of a failsafe. 
                if (effectType.Equals("Blatant"))
                { temp = GetPurpleBlatant(roll); }
                else
                { temp = GetPurpleLatent(roll); }
            }
            return temp.ToStringArr();
        }
        //all of these process the die roll
        public string RollResults(SerumID input)
        {
            return RollResults(input.colour, input.blatant, input.latent);
        }
        private string RollResults(string colour, int first, int second)
        {
            blRoll = first;
            laRoll = second;
            // this function passes the ball off to the recursive effect 
            // process serum-colour triggers(caused by prior serums, removing them)
            string serumBlatantColour = colour;
            int serumBlatantDose = 1;
            string serumLatentColour = colour;
            int serumLatentDose = 1;

            List<string> blatantColours = new List<string>();// these keep track of what serum is to be rolled. 
            List<string> latentColours = new List<string>();
            List<int> blatantDoses = new List<int>();
            List<int> latentDoses = new List<int>();
            List<PendingEffect> ActiveEffects = PEH.TriggeredEffects(colour);
            foreach (PendingEffect PE in ActiveEffects)
            {
                // these catch "do it more than once" actions
                if (PE.Timing.Equals("nextTwo"))
                {
                    PEH.AddEffect("nextSerum", PE.Effect, PE.Parame);
                }
                else if (PE.Timing.Equals("untilOrangeOrPink") && (currentSerum.Equals("Orange") || currentSerum.Equals("Pink")))
                {
                    PEH.AddEffect(PE.Timing, PE.Effect, PE.Parame);
                }

                if (PE.Effect.Equals("addBlatant"))
                {
                    blatantColours.Add(PE.Parame);
                    blatantDoses.Add(1);
                }
                else if (PE.Effect.Equals("addLatent"))
                {
                    latentColours.Add(PE.Parame);
                    latentDoses.Add(1);
                }
                else if (PE.Effect.Equals("repeatBlatant"))
                {
                    foreach (string s in get(colour, "Blatant", first))
                    {
                        fuEff.Add(s);
                    }
                }
                else if (PE.Effect.Equals("replaceBothwith"))
                {
                    serumBlatantColour = PE.Parame;
                    serumLatentColour = PE.Parame;
                }
                else if (PE.Effect.Equals("greenAddiction"))
                {
                    if (currentSerum.Equals("Green"))
                    {
                        blatantColours.Add("Orange");
                        blatantDoses.Add(1);
                    }
                    else
                    {
                        blatantColours.Add("Blue");
                        blatantDoses.Add(1);
                    }
                }
                else if (PE.Effect.Equals("doubleDose"))
                {
                    serumBlatantDose = 2;
                    serumLatentDose = 2;
                }
                else if (PE.Effect.Equals("noLatent"))
                {
                    serumLatentDose = 0;
                }
                else if (PE.Effect.Equals("onlyPinkOr"))
                {
                    if (currentSerum.Equals("Pink") || currentSerum.Equals(PE.Parame))
                    {
                        // the serum is allowed to exist and the curse is broken!
                    }
                    else
                    {
                        PEH.AddEffect(PE.Timing, PE.Effect, PE.Parame);
                        serumBlatantDose = 0;
                        serumLatentDose = 0;
                    }
                }
                else if (PE.Effect.Equals("invertSerum"))
                {
                    if (currentSerum.Equals("Orange"))
                    {
                        serumBlatantColour = "Blue";
                        serumLatentColour = "Blue";
                    }
                    else
                    {
                        serumBlatantColour = "Orange";
                        serumLatentColour = "Orange";
                    }
                }
                else if (PE.Effect.Equals("chaosSerum"))
                {
                    blatantColours.Add("Blue");
                    blatantColours.Add("Green");
                    blatantColours.Add("Orange");
                    blatantDoses.Add(1);
                    blatantDoses.Add(1);
                    blatantDoses.Add(1);
                }
                else if (PE.Effect.Equals("removeAspect"))
                {
                    // kludgey, but make sure the right one is selected-
                    bool remSuccess = false;
                    Aspect target;
                    if (PE.Parame.Equals("highest"))
                    {
                        subject.SelectHighest();
                        target = subject.GetHighest();
                    }
                    else if (PE.Parame.Equals("lowest"))
                    {
                        subject.SelectLowest();
                        target = subject.GetLowest();
                    }
                    else
                    {
                        target = AR.Find(PE.Parame);
                    }
                    remSuccess = subject.RemoveAspect(target);
                    fuEff.Add("rawText");
                    fuEff.Add("The subject loses all trace of " + target.ToString() + ", becoming more " + subject.GetNatural().ToString() + " in it's place.");
                    fuEff.Add("");
                }
                else if (PE.Effect.Equals("extremeAdvantage"))
                {
                    // roll 3 pairs, select 1 B 1 L the player wants
                }
                else if (PE.Effect.Equals("greenWillpower"))
                {
                    // player selects aspect & location for roll, if valid
                }
                else if (PE.Effect.Equals("hybridize"))
                {
                    aspectSelect AS = new aspectSelect("two highest aspects", subject.getUserAspects(), 2);
                    Aspect hybrid = new Aspect(AS.selected[0] + "-" + AS.selected[1]);
                    subject.RemoveAllAspects();
                    subject.setNatural(hybrid);
                    fuEff.Add("rawText");
                    fuEff.Add("The subject becomes a hybrid " + subject.GetNatural().ToString() + ", replacing all other features with their new form.");
                    fuEff.Add("");
                }
            }

            List<string> serumBlatant = processRolls(serumBlatantColour, "Blatant", serumBlatantDose, first);
            List<string> serumLatent = processRolls(serumLatentColour, "Latent", serumLatentDose, second);
            List<string> LatentResults = processRolls(latentColours, "Latent", latentDoses);
            List<string> BlatantResults = processRolls(blatantColours, "Blatant", blatantDoses);
            List<string> longEff = fuEff;   // process the future effects
            fuEff = new List<string>();     // clear the log
            string result = ParseEffects(longEff, 0);
            result = result + ParseEffects(LatentResults, 0);
            result = result + ParseEffects(serumLatent, 0);
            result = result + ParseEffects(BlatantResults, 0);
            result = result + ParseEffects(serumBlatant, 0);
            // process RIGHT NOW triggers (caused by this serum, removing them) (also thisandnext...)
            ActiveEffects = PEH.TriggeredEffects("none");
            foreach (PendingEffect PE in ActiveEffects)
            {
                // these catch "do it more than once" actions
                if (PE.Timing.Equals("nextTwo"))
                {
                    PEH.AddEffect("nextSerum", PE.Effect, PE.Parame);
                }
                else if (PE.Timing.Equals("untilOrangeOrPink") && (currentSerum.Equals("Orange") || currentSerum.Equals("Pink")))
                {
                    PEH.AddEffect(PE.Timing, PE.Effect, PE.Parame);
                }

                if (PE.Effect.Equals("addBlatant"))
                {
                    blatantColours.Add(PE.Parame);
                    blatantDoses.Add(1);
                }
                else if (PE.Effect.Equals("addLatent"))
                {
                    latentColours.Add(PE.Parame);
                    latentDoses.Add(1);
                }
                else if (PE.Effect.Equals("repeatBlatant"))
                {
                    foreach (string s in get(colour, "Blatant", first))
                    {
                        fuEff.Add(s);
                    }
                }
                else if (PE.Effect.Equals("replaceBothwith"))
                {
                    serumBlatantColour = PE.Parame;
                    serumLatentColour = PE.Parame;
                }
                else if (PE.Effect.Equals("greenAddiction"))
                {
                    if (currentSerum.Equals("Green"))
                    {
                        blatantColours.Add("Orange");
                        blatantDoses.Add(1);
                    }
                    else
                    {
                        blatantColours.Add("Blue");
                        blatantDoses.Add(1);
                    }
                }
                else if (PE.Effect.Equals("doubleDose"))
                {
                    serumBlatantDose = 2;
                    serumLatentDose = 2;
                }
                else if (PE.Effect.Equals("noLatent"))
                {
                    serumLatentDose = 0;
                }
                else if (PE.Effect.Equals("onlyPinkOr"))
                {
                    if (currentSerum.Equals("Pink") || currentSerum.Equals(PE.Parame))
                    {
                        // the serum is allowed to exist and the curse is broken!
                    }
                    else
                    {
                        PEH.AddEffect(PE.Timing, PE.Effect, PE.Parame);
                        serumBlatantDose = 0;
                        serumLatentDose = 0;
                    }
                }
                else if (PE.Effect.Equals("invertSerum"))
                {
                    if (currentSerum.Equals("Orange"))
                    {
                        serumBlatantColour = "Blue";
                        serumLatentColour = "Blue";
                    }
                    else
                    {
                        serumBlatantColour = "Orange";
                        serumLatentColour = "Orange";
                    }
                }
                else if (PE.Effect.Equals("chaosSerum"))
                {
                    blatantColours.Add("Blue");
                    blatantColours.Add("Green");
                    blatantColours.Add("Orange");
                    blatantDoses.Add(1);
                    blatantDoses.Add(1);
                    blatantDoses.Add(1);
                }
                else if (PE.Effect.Equals("removeAspect"))
                {
                    // kludgey, but make sure the right one is selected-
                    bool remSuccess = false;
                    Aspect target;
                    if (PE.Parame.Equals("highest"))
                    {
                        subject.SelectHighest();
                        target = subject.GetHighest();
                    }
                    else if (PE.Parame.Equals("lowest"))
                    {
                        subject.SelectLowest();
                        target = subject.GetLowest();
                    }
                    else
                    {
                        target = AR.Find(PE.Parame);
                    }
                    remSuccess = subject.RemoveAspect(target);
                    fuEff.Add("rawText");
                    fuEff.Add("The subject loses all trace of " + target.ToString() + ", becoming more " + subject.GetNatural().ToString() + " in it's place.");
                    fuEff.Add("");
                }
                else if (PE.Effect.Equals("extremeAdvantage"))
                {
                    // roll 3 pairs, select 1 B 1 L the player wants
                }
                else if (PE.Effect.Equals("greenWillpower"))
                {
                    // player selects aspect & location for roll, if valid
                }
                else if (PE.Effect.Equals("hybridize"))
                {
                    aspectSelect AS = new aspectSelect("two highest aspects", subject.getUserAspects(), 2);
                    Aspect hybrid = new Aspect(AS.selected[0] + "-" + AS.selected[1]);
                    subject.RemoveAllAspects();
                    subject.setNatural(hybrid);
                    fuEff.Add("rawText");
                    fuEff.Add("The subject becomes a hybrid " + subject.GetNatural().ToString() + ", replacing all other features with their new form.");
                    fuEff.Add("");
                }
            }
            return result;
        }

        private List<string> processRolls(string colour, string effect, int doses, int roll)
        {
            // for the serum itself
            List<string> results = new List<string>();
            for (int i = 0; i<doses; i++)
            {
                string[] temp = get(colour, effect, roll);
                foreach (string s in temp)
                {
                    results.Add(s);
                    // place temp into result list
                }
            }
            return results;
        }
        private List<string> processRolls(List<string> colours, string effect, List<int> rolls)
        {
            // for weird rider effects
            int totalrolls=0;
            foreach(int i in rolls)
            {
                totalrolls += i;
            }
            // thus, total rolls = total number of rolls to process
            List<string> results = new List<string>();

            for (int col = 0; col < colours.Count; col++)
            {
                for (int roll =0; roll < rolls[col]; roll++)
                {
                    string[] temp = get(colours[col], effect, die.roll());
                    foreach (string s in temp)
                    {
                        results.Add(s);
                        // place temp into result list
                    }
                }
            }
            return results;
        }
        private string pCondition(string[] Eff, int i)
        {
            conditionForm query = new conditionForm(Eff[i + 1]);
            if (query.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
            {
                return ParseEffects(Eff, i + 2);
            }
            else if (Eff.Length >= (i + 6) && Eff[i + 5].Equals("else"))
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
            if (location.Equals("random"))
            {
                location = Locationhandler.SizeLocation(die.r1d6());
            }
            numPercent = double.Parse(Eff[i + 2]);
            numPercent = subject.getAttribute("growthEff") * numPercent;
            percent = ToPercent(numPercent);
            return "The Subject's " + location + " grows by " + percent + ".\n" + ParseEffects(Eff, i + 3);
        }
        private string pShrink(string[] Eff, int i)
        {   //shrink effect, based off shrinkEff
            string location, percent;
            double numPercent;
            location = Eff[i + 1];
            if (location.Equals("random"))
            {
                location = Locationhandler.SizeLocation(die.r1d6());
            }
            numPercent = double.Parse(Eff[i + 2]);
            numPercent = subject.getAttribute("shrinkEff") * numPercent;
            percent = ToPercent(numPercent);
            return "The Subject's " + location + " shrinks by " + percent + ".\n" + ParseEffects(Eff, i + 3);
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
            string location = Eff[i + 1];
            string aspect = Eff[i + 2];
            if (aspect.Equals("random"))
            {
                aspect = AR.RollAspect().ToString();
            }
            else if (aspect.Equals("highest"))
            {
                aspect = subject.GetHighest().ToString();
            }
            if (location.Equals("random"))
            {
                location = Locationhandler.TFLocation(die.roll());
            }
            return "The Subject's " + location + " transforms into a(n) " + aspect + " " + location + "!\n" + ParseEffects(Eff, i + 3);
        }
        private string pApplyAspect(string[] Eff, int i)
        {   // apply aspect, if EF2 = y, force tf now, otherwise, force if dup aspect. 
            bool tfTrigger = Eff[i + 2].Equals("Y");
            if (!(subject.AddAspect(AR.Find(Eff[i + 1]))))
            {   // aspect not added, force tf
                tfTrigger = true;
            }
            if (tfTrigger)
            {
                return ParseEffects(new string[] { "transform", "random", Eff[i + 1] }, 0) + ParseEffects(Eff, i + 3);
            }
            else
            {
                return ParseEffects(Eff, i + 3);
            }
        }
        private string pApplyNatural(string[] Eff, int i)
        {
            Aspect Nat;
            if (Eff[i + 2].Equals("modify"))
            {
                Nat = AR.Find(Eff[i + 1] + "-" + subject.GetNatural().ToString());
            }
            else
            {
                Nat = AR.Find(Eff[i + 1]);
            }
            subject.setNatural(Nat);
            return "The subject's entire body has become " + Nat.ToString() + "!\n" + ParseEffects(Eff, i + 3);
        }
        private string pGrowNew(string[] Eff, int i)
        {
            string SAspect = Eff[i + 1];
            Aspect AAspect;
            if (SAspect.Equals("random"))
            {
                AAspect = AR.RollAspect();
            }
            else if(SAspect.Equals("natural"))
            {
                AAspect = subject.GetNatural();
            }
            else if (SAspect.Equals("highest"))
            {
                AAspect= subject.GetHighest();
            }
            else
            {
                AAspect = AR.Find(Eff[i + 1]);
            }
            SAspect = AAspect.ToString();

            string SLocation = Eff[i + 2];  // location as used by the locationhandler
            string PLocation;               // location as used by Userlog
            if (SLocation.Equals("random"))
            {
                SLocation = Locationhandler.TFLocation(die.roll());
            }
            if (SLocation.Equals("Subject's Choice"))
            {
                LocationSelect LSoc = new LocationSelect("growNew");
                LSoc.ShowDialog();
                SLocation = LSoc.GetChecked();
                LSoc.Dispose();
            }
            PLocation = SLocationToPLocation(SLocation);
            string output = growNewLocationText(PLocation, 1, AAspect);
            subject.ModifyAttAdd(PLocation, 1.0);
            return output + ParseEffects(Eff, i+3);
        }
        private string pGrowMax(string[] Eff, int i)
        {
            Aspect AAspect = subject.GetNatural();
            string SLocation = Eff[i + 1];
            if (SLocation.Equals("Subject's Choice"))
            {
                LocationSelect LSoc = new LocationSelect("growNew");
                LSoc.ShowDialog();
                SLocation = LSoc.GetChecked();
                LSoc.Dispose();
            }
            string PLocation = SLocationToPLocation(SLocation);
            int number = int.Parse(Eff[i + 2]);
            string output = growNewLocationText(PLocation, number, AAspect);
            subject.ModifyAttAdd(PLocation, number);
            return output + ParseEffects(Eff, i + 3);
        }
        private string pTimingTrigger(string[]  Eff, int i)
        {
            if (Eff[i + 1].Equals("repeatBlatant"))
            {
                string output = "";
                if (currentSerum.Equals("Blue"))
                {
                    output = "L";
                }
                else if (currentSerum.Equals("Green"))
                {
                    output = "G";
                }
                else if (currentSerum.Equals("Orange"))
                {
                    output = "R";
                }
                else if (currentSerum.Equals("Pink"))
                {
                    output = "P";
                }
                else if (currentSerum.Equals("Purple"))
                {
                    output = "V";
                }
                PEH.AddEffect(Eff[i], Eff[i + 1], output + blRoll.ToString());
            } else if (Eff[i + 1].Equals("repeatLatent")){
                string output = "";
                if (currentSerum.Equals("Blue"))
                {
                    output = "L";
                }
                else if (currentSerum.Equals("Green"))
                {
                    output = "G";
                }
                else if (currentSerum.Equals("Orange"))
                {
                    output = "R";
                }
                else if (currentSerum.Equals("Pink"))
                {
                    output = "P";
                }
                else if (currentSerum.Equals("Purple"))
                {
                    output = "V";
                }
                PEH.AddEffect(Eff[i], Eff[i + 1], output + laRoll.ToString());
            } else {
                PEH.AddEffect(Eff[i], Eff[i + 1], Eff[i + 2]);
            }
            return ParseEffects(Eff, i+3);
        }
        private string growNewLocationText(string PLocation, int number, Aspect LAspect)
        {
            string SAspect = LAspect.ToString();
            string outText = "The Subject grows ";
            if (PLocation.Equals("eyes"))
            {
                if (number > 1)
                {
                    outText += number.ToString() + " new " + SAspect + " eyes!\n";
                }
                else
                {
                    outText += "one new " + SAspect + " eye!\n";
                }
            }
            else if (PLocation.Equals("heads"))
            {
                if (number > 1)
                {
                    outText += number.ToString() + " new " + SAspect + " heads!\n";
                }
                else
                {
                    outText += "one new " + SAspect + " head!\n";
                }
            }
            else if (PLocation.Equals("taurBody"))
            {
                if (number > 1)
                {
                    outText += number.ToString() + " new " + SAspect + "-taur bodies!\n";
                }
                else
                {
                    outText += "a new " + SAspect + "-taur body!\n";
                }
            }
            else if (PLocation.Equals("armPairs"))
            {
                if (number > 1)
                {
                    outText += number.ToString() + " new pairs of " + SAspect + " arms!\n";
                }
                else
                {
                    outText += "a new pair of " + SAspect + " arms!\n";
                }
            }
            else if (PLocation.Equals("legPairs"))
            {
                if (number > 1)
                {
                    outText += number.ToString() + " new pairs of " + SAspect + " legs!\n";
                }
                else
                {
                    outText += "a new pair of " + SAspect + " legs!\n";
                }
            }
            else if (PLocation.Equals("tails"))
            {
                if (number > 1)
                {
                    outText += number.ToString() + " new " + SAspect + " tails!\n";
                }
                else
                {
                    outText += "a new " + SAspect + " tail!\n";
                }
            }
            else if (PLocation.Equals("bodies"))
            {
                if (number > 1)
                {
                    outText += number.ToString() + " " + SAspect + " bodies under their control!\n";
                }
                else
                {
                    outText += "a new " + SAspect + " body under their control!\n";
                }
            }
            else if (PLocation.Equals("penises"))
            {
                if (subject.getAttribute("penises")==0 && subject.getAttribute("balls") > 0)
                {
                    if (number > 1)
                    {
                        outText += number.ToString() + " new " + SAspect + " cocks, finally putting their balls to use!\n";
                    }
                    else
                    {
                        outText += "a new " + SAspect + " cock, finally putting their balls to use!\n";
                    }
                }
                if (number > 1)
                {
                    outText += number.ToString() + " new, needy " + SAspect + " cocks!\n";
                }
                else
                {
                    outText += "a new, needy " + SAspect + " cock!\n";
                }
            }
            else if (PLocation.Equals("vaginas"))
            {
                if (number > 1)
                {
                    outText += number.ToString() + " plush " + SAspect + " pussies!\n";
                }
                else
                {
                    if (subject.getAttribute("vaginas") > 0)
                    {
                        outText += "another plush " + SAspect + " pussy!\n";
                    }
                    else
                    {
                        outText += "a brand new " + SAspect + " pussy!\n";
                    }
                }
            }
            else if (PLocation.Equals("balls"))
            { 
                if (subject.getAttribute("penises") == 0)
                {
                    if (number > 1)
                    {
                        outText += number.ToString() + " new " + SAspect + " balls, but what are they for?!\n";
                    }
                    else
                    {
                        outText += "a single new " + SAspect + " testicle... why?\n";
                    }
                }
                else
                {
                    if (number > 1)
                    {
                        outText += number.ToString() + " additional, heavy " + SAspect + " balls!\n";
                    }
                    else
                    {
                        outText += "a single " + SAspect + " ball.\n";
                    }
                }
            }
            else
            {
                outText += "something that val did not consider, called " + PLocation + ".\n";
            }
            return outText;
        }
        string SLocationToPLocation(string SLocation)
        {
            if (SLocation.Equals("Eyes"))           { return "eyes"; }
            else if (SLocation.Equals("Head"))      { return "heads"; }
            else if (SLocation.Equals("Lower Body"))      { return "taurBody"; }
            else if (SLocation.Equals("Left Arm")||SLocation.Equals("Right Arm")) { return "armPairs"; }
            else if (SLocation.Equals("Left Leg")||SLocation.Equals("Right Leg")) { return "legpairs"; }
            else if (SLocation.Equals("Tail"))      { return "tails"; }
            else if (SLocation.Equals("Torso"))     { return "bodies"; }
            else if (SLocation.Equals("Genitals"))
            {
                int res = die.r1d6();
                if (res <= 2)
                {
                    return "penises";
                }
                else if (res >= 5)
                {
                    return "vaginas";
                }
                else
                {
                    return "balls";
                }
            }
            else
            {
                return "Subject's Choice";
            }
        }

        public string ParseEffects(List<string> Eff, int index)
        {
            string[] newEff = new string[Eff.Count];
            for (int i=0; i<Eff.Count; i++)
            {
                newEff[i] = Eff[i];
            }
            return ParseEffects(newEff, index);
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
            else if (Eff[i].Equals("applyAspect"))
            {
                return pApplyAspect(Eff, i);
            }
           else if (Eff[i].Equals("applyNatural"))
            {
                return pApplyNatural(Eff, i);
            }
            else if (Eff[i].Equals("growNew"))
            {
                return pGrowNew(Eff, i);
            }
            else
            {
                return pTimingTrigger(Eff, i);  //else, timing trigger
            }
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
