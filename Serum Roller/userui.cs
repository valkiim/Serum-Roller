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
        Locationhandler Loc;
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
            Loc = new Locationhandler();
            AR = new AspectRoller();
            SerumIDField.Text = "SerumID";
            SerumFamilySelect.Text = "Choose Colour";
        }
        private void RollSerumButton_Click(object sender, EventArgs e)
        {
            string input = SerumFamilySelect.Text;
            string results;
            if (input.Equals("")||input.Equals("Choose Colour"))
            {
                return;
            }
            if (input.Equals("By ID"))
            {
                results = ParseID(SerumIDField.Text);
                if (results == null)
                {
                    return;
                }
                else
                {
                    ApplySerum(results[0], results[1]);
                }
            }
            else
            {
                
                int blatant = Die.roll();
                int latent = Die.roll();
                results = EH.RollResults(input, blatant, latent);
                SerumIDField.Text = createID(input, blatant, latent);
                SerumArchive.Items.Add(SerumIDField.Text);
                AdditionColourSelect.Text = input;
                //ApplySerum(results[0], results[1]);
            }
        }
        string createID(string colour, int blatant, int latent)
        {
            string newID = "";
            if (colour == "Blue")
            {
                newID = "L";
            } else if(colour == "Green"){
                newID = "G";
            } else if (colour == "Orange")
            {
                newID = "R";
            }else if (colour == "Pink")
            {
                newID = "P";
            }else if(colour == "Purple")
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
                newID=newID+ "0" + latent.ToString();
            }
            return newID;
        }
        sEffect[] ParseID(string ID)
        {
            string colour;
            int blatant;
            int latent;

            // colour parsing
            if (ID[0].Equals('L'))
            {
                colour = "Blue";
            } else if (ID[0].Equals('G'))
            {
                colour = "Green";
            } else if (ID[0].Equals('R'))
            {
                colour = "Orange";
            }else if (ID[0].Equals('P'))
            {
                colour = "Pink";
            }else if (ID[0].Equals('V'))
            {
                colour = "Purple";
            }
            else
            {
                colour = "Invalid";
                return null;
            }
            AdditionColourSelect.Text = colour;

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
                return EH.RollResults(colour, blatant, latent);
            }

        }
        void ApplySerum(string visualEffects)
        {
            // TODO: rewrite this to handle the new subject output

        }
        private void TFLocationButton_Click(object sender, EventArgs e)
        {
            LocationResultLabel.Text = Loc.TFLocation(Die.roll());
        }
        private void SizeLocationButton_Click(object sender, EventArgs e)
        {
            LocationResultLabel.Text = Loc.SizeLocation(Die.roll());
        }
        private void AddBlatantButton_Click(object sender, EventArgs e)
        {
            string colour = AdditionColourSelect.Text;
            if (colour.Equals("")){
                return;
            }
            sEffect Blatant = EH.RollResults(colour, Die.roll(), 12)[0];
            BlatantEffectList.Items.Add(Blatant.ToString());
        }
        private void AddLatentButton_Click(object sender, EventArgs e)
        {
            string colour = AdditionColourSelect.Text;
            if (colour.Equals(""))
            {
                return;
            }
            sEffect latent = EH.RollResults(colour, 12, Die.roll())[1];
            LatentEffectList.Items.Add(latent.ToString());
        }
        private void SerumArchive_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // When mouse double clicks, show details of selected serum. Nice and simple. 
            int sel = SerumArchive.SelectedIndex;
            sEffect[] output = ParseID(SerumArchive.Items[sel].ToString());
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
