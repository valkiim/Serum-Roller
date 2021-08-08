using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serum_Roller
{
    public static class SerumIDHandler
    {
        static public SerumID ParseID(string ID)
        {
            string colour;
            int blatant;
            int latent;

            // colour parsing
            if (ID[0].Equals('L'))
            {
                colour = "Blue";
            }
            else if (ID[0].Equals('G'))
            {
                colour = "Green";
            }
            else if (ID[0].Equals('R'))
            {
                colour = "Orange";
            }
            else if (ID[0].Equals('P'))
            {
                colour = "Pink";
            }
            else if (ID[0].Equals('V'))
            {
                colour = "Purple";
            }
            else
            {
                colour = "Invalid";
                return null;
            }

            // blatant parsing
            if (ID[1].Equals('0'))
            {
                blatant = int.Parse(ID[2].ToString());
            }
            else
            {
                blatant = 10 + int.Parse(ID[2].ToString());
            }

            // latent parsing
            if (ID[3].Equals('0'))
            {
                latent = int.Parse(ID[4].ToString());
            }
            else
            {
                latent = 10 + int.Parse(ID[4].ToString());
            }

            // Verify Validity

            if (colour.Equals("Invalid"))
            {
                MessageBox.Show("Invalid Serum code!\nInvalid colour code!");
                return null;
            }
            else if (blatant > 12)
            {
                MessageBox.Show("Invalid Serum code!\nInvalid Blatant Effect!");
                return null;
            }
            else if (latent > 12)
            {
                MessageBox.Show("Invalid Serum code!\nInvalid Latent Effect!");
                return null;
            }
            else
            {
                return new SerumID(colour, blatant, latent);
            }
        }
    }
}
