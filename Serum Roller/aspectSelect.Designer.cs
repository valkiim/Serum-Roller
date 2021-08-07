namespace Serum_Roller
{
    partial class aspectSelect
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
            this.aspectListCheckbox = new System.Windows.Forms.CheckedListBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aspectListCheckbox
            // 
            this.aspectListCheckbox.CheckOnClick = true;
            this.aspectListCheckbox.FormattingEnabled = true;
            this.aspectListCheckbox.Location = new System.Drawing.Point(16, 29);
            this.aspectListCheckbox.Name = "aspectListCheckbox";
            this.aspectListCheckbox.ScrollAlwaysVisible = true;
            this.aspectListCheckbox.Size = new System.Drawing.Size(163, 304);
            this.aspectListCheckbox.TabIndex = 1;
            this.aspectListCheckbox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.aspectListCheckbox_ItemCheck);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(13, 13);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(109, 13);
            this.instructionLabel.TabIndex = 2;
            this.instructionLabel.Text = "Select INPUT Aspect";
            // 
            // submit
            // 
            this.submit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.submit.Location = new System.Drawing.Point(16, 340);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 3;
            this.submit.Text = "Select Aspect";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // aspectSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 380);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.aspectListCheckbox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "aspectSelect";
            this.Text = "aspectSelect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckedListBox aspectListCheckbox;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Button submit;
    }
}