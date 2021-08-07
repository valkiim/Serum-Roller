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
    public partial class aspectSelect : Form
    {
        int numChek;
        public string[] selected;
        public aspectSelect(string input, string[] aspects, int inChek)
        {
            InitializeComponent();
            instructionLabel.Text = "Please select your " + input + ".";
            foreach (string s in aspects)
            {
                aspectListCheckbox.Items.Add(s);
            }
            numChek = inChek;
        }
        public aspectSelect(string input, string[] aspects)
        {
            InitializeComponent();
            instructionLabel.Text = "Please select your " + input + " aspect.";
            foreach (string s in aspects)
            {
                aspectListCheckbox.Items.Add(s);
            }
            numChek = 1;
        }

        private void aspectListCheckbox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (aspectListCheckbox.CheckedItems.Count>= numChek && e.CurrentValue!= CheckState.Checked)
            {
                e.NewValue = e.CurrentValue;
                System.Media.SystemSounds.Exclamation.Play();
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            selected = new string[aspectListCheckbox.CheckedItems.Count];
            for (int i = 0; i < aspectListCheckbox.CheckedItems.Count; i++)
            {
                selected[i] = aspectListCheckbox.CheckedItems[i].ToString();
            }
        }
    }
}
