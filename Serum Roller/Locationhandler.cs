using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serum_Roller
{
    static class Locationhandler
    {
        public static string SizeLocation(int roll)
        {
            switch (roll)
            {
                case 2: return "Balls";
                case 3: return "Penis";
                case 4: return "Vagina";
                case 5: return "Pudge";
                case 6: return "Ass";
                case 7: return "Height";
                case 8: return "Breasts";
                case 9: return "Musculature";
                case 10: return "Tails";
                case 11: return "Tongues";
                case 12: return "Subject's Choice";
                default: return "Unknown";
            }
        }
        public static string TFLocation(int roll)
        {
            switch (roll)
            {
                case 2: return "Eyes";
                case 3: return "Head";
                case 4: return "Lower Body";
                case 5: return "Left Arm";
                case 6: return "Left Leg";
                case 7: return "Tail";
                case 8: return "Right Leg";
                case 9: return "Right Arm";
                case 10: return "Torso";
                case 11: return "Genitals";
                case 12: return "Subject's Choice";
                default: return "Unknown";
            }
        }
    }
}
