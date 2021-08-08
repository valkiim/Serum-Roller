namespace Serum_Roller
{
    partial class SerumDetails
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
            this.serumIDlabel = new System.Windows.Forms.Label();
            this.CloseWindowButton = new System.Windows.Forms.Button();
            this.RemoveSerumButton = new System.Windows.Forms.Button();
            this.observedLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // serumIDlabel
            // 
            this.serumIDlabel.AutoSize = true;
            this.serumIDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.serumIDlabel.Location = new System.Drawing.Point(12, 9);
            this.serumIDlabel.Name = "serumIDlabel";
            this.serumIDlabel.Size = new System.Drawing.Size(60, 20);
            this.serumIDlabel.TabIndex = 0;
            this.serumIDlabel.Text = "XBBLL";
            // 
            // CloseWindowButton
            // 
            this.CloseWindowButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseWindowButton.Location = new System.Drawing.Point(17, 326);
            this.CloseWindowButton.Name = "CloseWindowButton";
            this.CloseWindowButton.Size = new System.Drawing.Size(107, 23);
            this.CloseWindowButton.TabIndex = 5;
            this.CloseWindowButton.Text = "Close Details";
            this.CloseWindowButton.UseVisualStyleBackColor = true;
            // 
            // RemoveSerumButton
            // 
            this.RemoveSerumButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.RemoveSerumButton.Location = new System.Drawing.Point(17, 297);
            this.RemoveSerumButton.Name = "RemoveSerumButton";
            this.RemoveSerumButton.Size = new System.Drawing.Size(107, 23);
            this.RemoveSerumButton.TabIndex = 6;
            this.RemoveSerumButton.Text = "Remove Serum";
            this.RemoveSerumButton.UseVisualStyleBackColor = true;
            // 
            // observedLabel
            // 
            this.observedLabel.AutoSize = true;
            this.observedLabel.Location = new System.Drawing.Point(13, 33);
            this.observedLabel.Name = "observedLabel";
            this.observedLabel.Size = new System.Drawing.Size(92, 13);
            this.observedLabel.TabIndex = 7;
            this.observedLabel.Text = "Observed Effects:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // SerumDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.observedLabel);
            this.Controls.Add(this.RemoveSerumButton);
            this.Controls.Add(this.CloseWindowButton);
            this.Controls.Add(this.serumIDlabel);
            this.Name = "SerumDetails";
            this.Text = "SerumDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label serumIDlabel;
        private System.Windows.Forms.Button CloseWindowButton;
        private System.Windows.Forms.Button RemoveSerumButton;
        private System.Windows.Forms.Label observedLabel;
        private System.Windows.Forms.Label label1;
    }
}