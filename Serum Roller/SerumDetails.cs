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
        string Effects;
        public SerumDetails(labeledString input)
        {
            serumID = input.ID;
            Effects = input.Effect;
            InitializeComponent();
            serumIDlabel.Text = serumID;
            if (input == null)
            {
                label1.Text= "Invalid Serum Applied";

            } else
            {
                label1.Text = Effects;
            }
            // dialog OK = Delete
            // Dialog Cx = just looking no del. 
        }
    }
}
