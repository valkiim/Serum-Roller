namespace Serum_Roller
{
    partial class UserUi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserUi));
            this.rollSerumButton = new System.Windows.Forms.Button();
            this.SerumFamilySelect = new System.Windows.Forms.ComboBox();
            this.SerumIDField = new System.Windows.Forms.TextBox();
            this.TFLocationButton = new System.Windows.Forms.Button();
            this.SizeLocationButton = new System.Windows.Forms.Button();
            this.AddBlatantButton = new System.Windows.Forms.Button();
            this.AddLatentButton = new System.Windows.Forms.Button();
            this.Locationlabel = new System.Windows.Forms.Label();
            this.AdditionColourSelect = new System.Windows.Forms.ComboBox();
            this.LocationResultLabel = new System.Windows.Forms.Label();
            this.SerumArchive = new System.Windows.Forms.ListBox();
            this.historylabel = new System.Windows.Forms.Label();
            this.randomAspectButton = new System.Windows.Forms.Button();
            this.RandomAspectLabel = new System.Windows.Forms.Label();
            this.helpbutton = new System.Windows.Forms.Button();
            this.effectLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rollSerumButton
            // 
            this.rollSerumButton.Location = new System.Drawing.Point(12, 352);
            this.rollSerumButton.Name = "rollSerumButton";
            this.rollSerumButton.Size = new System.Drawing.Size(184, 58);
            this.rollSerumButton.TabIndex = 3;
            this.rollSerumButton.Text = "Drink New Serum";
            this.rollSerumButton.UseVisualStyleBackColor = true;
            this.rollSerumButton.Click += new System.EventHandler(this.RollSerumButton_Click);
            // 
            // SerumFamilySelect
            // 
            this.SerumFamilySelect.FormattingEnabled = true;
            this.SerumFamilySelect.Items.AddRange(new object[] {
            "Orange",
            "Green",
            "Blue",
            "Pink",
            "Purple",
            "By ID"});
            this.SerumFamilySelect.Location = new System.Drawing.Point(202, 384);
            this.SerumFamilySelect.Name = "SerumFamilySelect";
            this.SerumFamilySelect.Size = new System.Drawing.Size(91, 21);
            this.SerumFamilySelect.TabIndex = 4;
            // 
            // SerumIDField
            // 
            this.SerumIDField.Location = new System.Drawing.Point(202, 355);
            this.SerumIDField.MaxLength = 5;
            this.SerumIDField.Name = "SerumIDField";
            this.SerumIDField.Size = new System.Drawing.Size(121, 20);
            this.SerumIDField.TabIndex = 5;
            // 
            // TFLocationButton
            // 
            this.TFLocationButton.Location = new System.Drawing.Point(349, 382);
            this.TFLocationButton.Name = "TFLocationButton";
            this.TFLocationButton.Size = new System.Drawing.Size(75, 23);
            this.TFLocationButton.TabIndex = 6;
            this.TFLocationButton.Text = "Roll TF Location";
            this.TFLocationButton.UseVisualStyleBackColor = true;
            this.TFLocationButton.Click += new System.EventHandler(this.TFLocationButton_Click);
            // 
            // SizeLocationButton
            // 
            this.SizeLocationButton.Location = new System.Drawing.Point(430, 382);
            this.SizeLocationButton.Name = "SizeLocationButton";
            this.SizeLocationButton.Size = new System.Drawing.Size(75, 23);
            this.SizeLocationButton.TabIndex = 7;
            this.SizeLocationButton.Text = "Roll Size";
            this.SizeLocationButton.UseVisualStyleBackColor = true;
            this.SizeLocationButton.Click += new System.EventHandler(this.SizeLocationButton_Click);
            // 
            // AddBlatantButton
            // 
            this.AddBlatantButton.Location = new System.Drawing.Point(531, 382);
            this.AddBlatantButton.Name = "AddBlatantButton";
            this.AddBlatantButton.Size = new System.Drawing.Size(75, 23);
            this.AddBlatantButton.TabIndex = 8;
            this.AddBlatantButton.Text = "Add Blatant";
            this.AddBlatantButton.UseMnemonic = false;
            this.AddBlatantButton.UseVisualStyleBackColor = true;
            this.AddBlatantButton.Click += new System.EventHandler(this.AddBlatantButton_Click);
            // 
            // AddLatentButton
            // 
            this.AddLatentButton.Location = new System.Drawing.Point(612, 382);
            this.AddLatentButton.Name = "AddLatentButton";
            this.AddLatentButton.Size = new System.Drawing.Size(75, 23);
            this.AddLatentButton.TabIndex = 9;
            this.AddLatentButton.Text = "AddLatent";
            this.AddLatentButton.UseVisualStyleBackColor = true;
            this.AddLatentButton.Click += new System.EventHandler(this.AddLatentButton_Click);
            // 
            // Locationlabel
            // 
            this.Locationlabel.AutoSize = true;
            this.Locationlabel.Location = new System.Drawing.Point(346, 358);
            this.Locationlabel.Name = "Locationlabel";
            this.Locationlabel.Size = new System.Drawing.Size(94, 13);
            this.Locationlabel.TabIndex = 11;
            this.Locationlabel.Text = "Random Location:";
            // 
            // AdditionColourSelect
            // 
            this.AdditionColourSelect.FormattingEnabled = true;
            this.AdditionColourSelect.Items.AddRange(new object[] {
            "Blue",
            "Green",
            "Orange",
            "Pink",
            "Purple"});
            this.AdditionColourSelect.Location = new System.Drawing.Point(531, 349);
            this.AdditionColourSelect.Name = "AdditionColourSelect";
            this.AdditionColourSelect.Size = new System.Drawing.Size(156, 21);
            this.AdditionColourSelect.TabIndex = 12;
            // 
            // LocationResultLabel
            // 
            this.LocationResultLabel.AutoSize = true;
            this.LocationResultLabel.Location = new System.Drawing.Point(446, 358);
            this.LocationResultLabel.Name = "LocationResultLabel";
            this.LocationResultLabel.Size = new System.Drawing.Size(27, 13);
            this.LocationResultLabel.TabIndex = 13;
            this.LocationResultLabel.Text = "N/A";
            // 
            // SerumArchive
            // 
            this.SerumArchive.FormattingEnabled = true;
            this.SerumArchive.Location = new System.Drawing.Point(718, 51);
            this.SerumArchive.Name = "SerumArchive";
            this.SerumArchive.Size = new System.Drawing.Size(100, 290);
            this.SerumArchive.TabIndex = 14;
            this.SerumArchive.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SerumArchive_MouseDoubleClick);
            // 
            // historylabel
            // 
            this.historylabel.AutoSize = true;
            this.historylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.historylabel.Location = new System.Drawing.Point(718, 27);
            this.historylabel.Name = "historylabel";
            this.historylabel.Size = new System.Drawing.Size(100, 20);
            this.historylabel.TabIndex = 15;
            this.historylabel.Text = "Prior Serums";
            // 
            // randomAspectButton
            // 
            this.randomAspectButton.Location = new System.Drawing.Point(718, 355);
            this.randomAspectButton.Name = "randomAspectButton";
            this.randomAspectButton.Size = new System.Drawing.Size(96, 23);
            this.randomAspectButton.TabIndex = 16;
            this.randomAspectButton.Text = "Random Aspect";
            this.randomAspectButton.UseVisualStyleBackColor = true;
            this.randomAspectButton.Click += new System.EventHandler(this.RandomAspectButton_Click);
            // 
            // RandomAspectLabel
            // 
            this.RandomAspectLabel.AutoSize = true;
            this.RandomAspectLabel.Location = new System.Drawing.Point(719, 387);
            this.RandomAspectLabel.Name = "RandomAspectLabel";
            this.RandomAspectLabel.Size = new System.Drawing.Size(0, 13);
            this.RandomAspectLabel.TabIndex = 17;
            // 
            // helpbutton
            // 
            this.helpbutton.Location = new System.Drawing.Point(299, 384);
            this.helpbutton.Name = "helpbutton";
            this.helpbutton.Size = new System.Drawing.Size(24, 23);
            this.helpbutton.TabIndex = 18;
            this.helpbutton.Text = "?";
            this.helpbutton.UseVisualStyleBackColor = true;
            this.helpbutton.Click += new System.EventHandler(this.helpbutton_Click);
            // 
            // effectLabel
            // 
            this.effectLabel.AutoSize = true;
            this.effectLabel.Location = new System.Drawing.Point(13, 13);
            this.effectLabel.MaximumSize = new System.Drawing.Size(700, 0);
            this.effectLabel.Name = "effectLabel";
            this.effectLabel.Size = new System.Drawing.Size(686, 52);
            this.effectLabel.TabIndex = 19;
            this.effectLabel.Text = resources.GetString("effectLabel.Text");
            // 
            // UserUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 415);
            this.Controls.Add(this.effectLabel);
            this.Controls.Add(this.helpbutton);
            this.Controls.Add(this.RandomAspectLabel);
            this.Controls.Add(this.randomAspectButton);
            this.Controls.Add(this.historylabel);
            this.Controls.Add(this.SerumArchive);
            this.Controls.Add(this.LocationResultLabel);
            this.Controls.Add(this.AdditionColourSelect);
            this.Controls.Add(this.Locationlabel);
            this.Controls.Add(this.AddLatentButton);
            this.Controls.Add(this.AddBlatantButton);
            this.Controls.Add(this.SizeLocationButton);
            this.Controls.Add(this.TFLocationButton);
            this.Controls.Add(this.SerumIDField);
            this.Controls.Add(this.SerumFamilySelect);
            this.Controls.Add(this.rollSerumButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserUi";
            this.Text = "Val\'s Serum Roller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button rollSerumButton;
        private System.Windows.Forms.ComboBox SerumFamilySelect;
        private System.Windows.Forms.TextBox SerumIDField;
        private System.Windows.Forms.Button TFLocationButton;
        private System.Windows.Forms.Button SizeLocationButton;
        private System.Windows.Forms.Button AddBlatantButton;
        private System.Windows.Forms.Button AddLatentButton;
        private System.Windows.Forms.Label Locationlabel;
        private System.Windows.Forms.ComboBox AdditionColourSelect;
        private System.Windows.Forms.Label LocationResultLabel;
        private System.Windows.Forms.ListBox SerumArchive;
        private System.Windows.Forms.Label historylabel;
        private System.Windows.Forms.Button randomAspectButton;
        private System.Windows.Forms.Label RandomAspectLabel;
        private System.Windows.Forms.Button helpbutton;
        private System.Windows.Forms.Label effectLabel;
    }
}

