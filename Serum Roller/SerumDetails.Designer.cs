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
            this.label1 = new System.Windows.Forms.Label();
            this.BlatantDescLabel = new System.Windows.Forms.Label();
            this.LatentEffectLabel = new System.Windows.Forms.Label();
            this.LatentDescLabel = new System.Windows.Forms.Label();
            this.CloseWindowButton = new System.Windows.Forms.Button();
            this.RemoveSerumButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serumIDlabel
            // 
            this.serumIDlabel.AutoSize = true;
            this.serumIDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.serumIDlabel.Location = new System.Drawing.Point(127, 9);
            this.serumIDlabel.Name = "serumIDlabel";
            this.serumIDlabel.Size = new System.Drawing.Size(60, 20);
            this.serumIDlabel.TabIndex = 0;
            this.serumIDlabel.Text = "XBBLL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Blatant Effect:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BlatantDescLabel
            // 
            this.BlatantDescLabel.AutoSize = true;
            this.BlatantDescLabel.Location = new System.Drawing.Point(131, 33);
            this.BlatantDescLabel.MaximumSize = new System.Drawing.Size(350, 0);
            this.BlatantDescLabel.Name = "BlatantDescLabel";
            this.BlatantDescLabel.Size = new System.Drawing.Size(127, 13);
            this.BlatantDescLabel.TabIndex = 2;
            this.BlatantDescLabel.Text = "Blatant Effect Description";
            // 
            // LatentEffectLabel
            // 
            this.LatentEffectLabel.AutoSize = true;
            this.LatentEffectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LatentEffectLabel.Location = new System.Drawing.Point(18, 163);
            this.LatentEffectLabel.Name = "LatentEffectLabel";
            this.LatentEffectLabel.Size = new System.Drawing.Size(106, 20);
            this.LatentEffectLabel.TabIndex = 3;
            this.LatentEffectLabel.Text = "Latent Effect:";
            // 
            // LatentDescLabel
            // 
            this.LatentDescLabel.AutoSize = true;
            this.LatentDescLabel.Location = new System.Drawing.Point(131, 163);
            this.LatentDescLabel.MaximumSize = new System.Drawing.Size(350, 0);
            this.LatentDescLabel.Name = "LatentDescLabel";
            this.LatentDescLabel.Size = new System.Drawing.Size(124, 13);
            this.LatentDescLabel.TabIndex = 4;
            this.LatentDescLabel.Text = "Latent Effect Description";
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
            // SerumDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.RemoveSerumButton);
            this.Controls.Add(this.CloseWindowButton);
            this.Controls.Add(this.LatentDescLabel);
            this.Controls.Add(this.LatentEffectLabel);
            this.Controls.Add(this.BlatantDescLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serumIDlabel);
            this.Name = "SerumDetails";
            this.Text = "SerumDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label serumIDlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BlatantDescLabel;
        private System.Windows.Forms.Label LatentEffectLabel;
        private System.Windows.Forms.Label LatentDescLabel;
        private System.Windows.Forms.Button CloseWindowButton;
        private System.Windows.Forms.Button RemoveSerumButton;
    }
}