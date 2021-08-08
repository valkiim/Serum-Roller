using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Serum_Roller
{
    public partial class UserUi : Form
    {
        EffectHandler EH;
        Dieroller Die;

        AspectRoller AR;
        public UserUi()
        {
            WelcomeForm welc = new WelcomeForm();
            InitializeComponent();
            welc.ShowDialog();
            string user = welc.UsernameField.Text;
            string usrNat = welc.subjectspeciesbox.Text;
            SerumArchive.Items.Add("User: " + user);
            EH = new EffectHandler(usrNat);
            Die = new Dieroller();

            AR = AspectRoller.Instance;
            SerumIDField.Text = "SerumID";
            SerumFamilySelect.Text = "Choose Colour";
            welc.Dispose();
        }
        private void RollSerumButton_Click(object sender, EventArgs e)
        {
            string input = SerumFamilySelect.Text;
            SerumID ParsedID;
            if (input.Equals("")||input.Equals("Choose Colour"))
            {
                return;
            }
            if (input.Equals("By ID"))
            {
                ParsedID = new SerumID(SerumIDField.Text);
                if (ParsedID == null)
                {
                    return;
                }
                else
                {
                    string output = EH.RollResults(ParsedID);

                    ApplySerum(output);
                }
            }
            else
            {
                
                int blatant = Die.roll();
                int latent = Die.roll();
                string output = EH.RollResults(new SerumID(input, blatant, latent))+" roll processed!";
                SerumIDField.Text = SerumID.GenerateID(input, blatant, latent);
                SerumArchive.Items.Add(SerumIDField.Text);
                ApplySerum(output);
            }
        }
        
        void ApplySerum(string visualEffects)
        {
            effectLabel.Text = visualEffects;
        }
        private void TFLocationButton_Click(object sender, EventArgs e)
        {
            LocationResultLabel.Text = Locationhandler.TFLocation(Die.roll());
        }
        private void SizeLocationButton_Click(object sender, EventArgs e)
        {
            LocationResultLabel.Text = Locationhandler.SizeLocation(Die.roll());
        }

        private void SerumArchive_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // When mouse double clicks, show details of selected serum. Nice and simple. 
            int sel = SerumArchive.SelectedIndex;
            sEffect[] output = null;// todo fix log
            SerumDetails details = new SerumDetails(SerumArchive.Items[sel].ToString(), output);
            DialogResult deletserum = details.ShowDialog();
            if (deletserum == DialogResult.OK)
            {
                SerumArchive.Items.RemoveAt(sel);
            }
            //else, live a long and happy life
        }

        private void RandomAspectButton_Click(object sender, EventArgs e)
        {
            RandomAspectLabel.Text = AR.RollAspect().ToString();
        }

        private void helpbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Double Click serums in the history to check effects\nOrange Causes Growth\nGreen Causes Transformation\nBlue Causes Shrinking\nPink helps Revert you!");
        }
    }
}
