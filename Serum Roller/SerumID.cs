using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serum_Roller
{
    public class SerumID
    {
        public string colour;
        public int blatant;
        public int latent;
        public SerumID(string co, int bl, int la)
        {
            colour = co;
            blatant = bl;
            latent = la;
        }
        public SerumID(string serumID)
        {
            SerumID temp = SerumIDHandler.ParseID(serumID);
            colour = temp.colour;
            blatant = temp.blatant;
            latent = temp.latent;
        }
        public static string GenerateID(string col, int bla, int lat)
        {
            string newID = "";
            if (col.Equals("Blue"))
            {
                newID = "L";
            }
            else if (col.Equals("Green"))
            {
                newID = "G";
            }
            else if (col.Equals("Orange"))
            {
                newID = "R";
            }
            else if (col.Equals("Pink"))
            {
                newID = "P";
            }
            else if (col.Equals("Purple"))
            {
                newID = "V";
            }
            if (bla >= 10)
            {
                newID = newID + bla.ToString();
            }
            else
            {
                newID = newID + "0" + bla.ToString();
            }

            if (lat >= 10)
            {
                newID = newID + lat.ToString();
            }
            else
            {
                newID = newID + "0" + lat.ToString();
            }
            return newID;
        }
        public override string ToString()
        {
            string newID = "";
            if (colour.Equals("Blue"))
            {
                newID = "L";
            }
            else if (colour.Equals("Green"))
            {
                newID = "G";
            }
            else if (colour.Equals("Orange"))
            {
                newID = "R";
            }
            else if (colour.Equals("Pink"))
            {
                newID = "P";
            }
            else if (colour.Equals("Purple"))
            {
                newID = "V";
            }
            if (blatant >= 10)
            {
                newID = newID + blatant.ToString();
            }
            else
            {
                newID = newID + "0" + blatant.ToString();
            }

            if (latent >= 10)
            {
                newID = newID + latent.ToString();
            }
            else
            {
                newID = newID + "0" + latent.ToString();
            }
            return newID;
        }
        
    }
}
