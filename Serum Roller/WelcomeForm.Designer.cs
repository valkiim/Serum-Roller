namespace Serum_Roller
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.UsernameField = new System.Windows.Forms.TextBox();
            this.subjectspeciesbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.welcomeLabel.Location = new System.Drawing.Point(170, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(235, 20);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to Val\'s Serum Project";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.MaximumSize = new System.Drawing.Size(550, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 208);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // AcceptButton
            // 
            this.AcceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AcceptButton.Location = new System.Drawing.Point(398, 277);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(163, 59);
            this.AcceptButton.TabIndex = 2;
            this.AcceptButton.Text = "Accept";
            this.AcceptButton.UseVisualStyleBackColor = true;
            // 
            // UsernameField
            // 
            this.UsernameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UsernameField.Location = new System.Drawing.Point(15, 277);
            this.UsernameField.Name = "UsernameField";
            this.UsernameField.Size = new System.Drawing.Size(377, 26);
            this.UsernameField.TabIndex = 3;
            this.UsernameField.Text = "Your Name Here";
            // 
            // subjectspeciesbox
            // 
            this.subjectspeciesbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.subjectspeciesbox.Location = new System.Drawing.Point(15, 310);
            this.subjectspeciesbox.Name = "subjectspeciesbox";
            this.subjectspeciesbox.Size = new System.Drawing.Size(377, 26);
            this.subjectspeciesbox.TabIndex = 4;
            this.subjectspeciesbox.Text = "Subject Species Here";
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 348);
            this.Controls.Add(this.subjectspeciesbox);
            this.Controls.Add(this.UsernameField);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.welcomeLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WelcomeForm";
            this.Text = "WelcomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AcceptButton;
        public System.Windows.Forms.TextBox UsernameField;
        public System.Windows.Forms.TextBox subjectspeciesbox;
    }
}