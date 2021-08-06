namespace Serum_Roller.effects
{
    partial class conditionForm
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
            this.conditionLabel = new System.Windows.Forms.Label();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.DenyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // conditionLabel
            // 
            this.conditionLabel.AutoSize = true;
            this.conditionLabel.Location = new System.Drawing.Point(13, 13);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(76, 13);
            this.conditionLabel.TabIndex = 0;
            this.conditionLabel.Text = "conditionLabel";
            // 
            // AcceptButton
            // 
            this.AcceptButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.AcceptButton.Location = new System.Drawing.Point(12, 176);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(120, 23);
            this.AcceptButton.TabIndex = 1;
            this.AcceptButton.Text = "Yes / Condition Met";
            this.AcceptButton.UseVisualStyleBackColor = true;
            // 
            // DenyButton
            // 
            this.DenyButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.DenyButton.Location = new System.Drawing.Point(297, 176);
            this.DenyButton.Name = "DenyButton";
            this.DenyButton.Size = new System.Drawing.Size(125, 23);
            this.DenyButton.TabIndex = 2;
            this.DenyButton.Text = "No / Not Met";
            this.DenyButton.UseVisualStyleBackColor = true;
            // 
            // conditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 211);
            this.Controls.Add(this.DenyButton);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.conditionLabel);
            this.Name = "conditionForm";
            this.Text = "conditionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label conditionLabel;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button DenyButton;
    }
}