using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serum_Roller
{
    public partial class SerumDetails : Form
    {
        string serumID;
        sEffect[] Effects;
        public SerumDetails(string input, sEffect[] effectIn)
        {
            serumID = input;
            InitializeComponent();
            serumIDlabel.Text = input;
            Effects = effectIn;
            if (effectIn == null)
            {
                BlatantDescLabel.Text = "Invalid Serum Applied";
                LatentDescLabel.Text = "Invalid Serum Applied";
            } else
            {
                BlatantDescLabel.Text = Effects[0].ToString();
                LatentDescLabel.Text = Effects[1].ToString();
            }
            // dialog OK = Delete
            // Dialog Cx = just looking no del. 
        }
    }
}
