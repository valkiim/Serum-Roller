using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serum_Roller.effects
{
    public partial class conditionForm : Form
    {
        public conditionForm(string input)
        {
            InitializeComponent();
            conditionLabel.Text = input;
        }
    }
}
