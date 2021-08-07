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
    public partial class LocationSelect : Form
    {
        public LocationSelect(string loctable)
        {
            string[] buttonLabels;
            InitializeComponent();
            if (loctable.Equals("size"))
            {
                buttonLabels = new string[] { "Balls", "Penis", "Vagina", "Fat", "Ass", "Height", "Breasts", "Musculature", "Tails", "Tongues" };
            } else if (loctable.Equals("TF"))
            {
                buttonLabels = new string[] { "Eyes", "Head", "Lower Body", "Left Arm", "Left Leg", "Tail", "Right Leg", "Right Arm", "Torso", "Genitals" };
            } else if (loctable.Equals("growNew"))
            {
                buttonLabels = new string[] { "eyes", "heads", "taurBody", "armPairs", "legPairs", "tails", "bodies", "penises", "vaginas", "balls" };
            }
            else
            {
                return;
            }
            radioButton1.Text = buttonLabels[0];
            radioButton2.Text = buttonLabels[1];
            radioButton3.Text = buttonLabels[2];
            radioButton4.Text = buttonLabels[3];
            radioButton5.Text = buttonLabels[4];
            radioButton6.Text = buttonLabels[5];
            radioButton7.Text = buttonLabels[6];
            radioButton8.Text = buttonLabels[7];
            radioButton9.Text = buttonLabels[8];
            radioButton10.Text = buttonLabels[9];
        }
        public string GetChecked()
        {
            //returns the checked field. 
            if (radioButton1.Checked)
            {
                return radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                return radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                return radioButton3.Text;
            }
            else if (radioButton4.Checked)
            {
                return radioButton4.Text;
            }
            else if (radioButton5.Checked)
            {
                return radioButton5.Text;
            }
            else if (radioButton6.Checked)
            {
                return radioButton6.Text;
            }
            else if (radioButton7.Checked)
            {
                return radioButton7.Text;
            }
            else if (radioButton8.Checked)
            {
                return radioButton8.Text;
            }
            else if (radioButton9.Checked)
            {
                return radioButton9.Text;
            }
            else if (radioButton10.Checked)
            {
                return radioButton10.Text;
            }
            else
            {
                return "None";
            }
        }
    }
}
