namespace Molar_mass_calculator
{
    partial class CreditsDialogue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditsDialogue));
            this.CreditsDialogueButton = new System.Windows.Forms.Button();
            this.CreditsText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // CreditsDialogueButton
            // 
            this.CreditsDialogueButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CreditsDialogueButton.Location = new System.Drawing.Point(162, 252);
            this.CreditsDialogueButton.Margin = new System.Windows.Forms.Padding(6);
            this.CreditsDialogueButton.Name = "CreditsDialogueButton";
            this.CreditsDialogueButton.Size = new System.Drawing.Size(150, 45);
            this.CreditsDialogueButton.TabIndex = 3;
            this.CreditsDialogueButton.Text = "Return";
            this.CreditsDialogueButton.UseVisualStyleBackColor = true;
            this.CreditsDialogueButton.Click += new System.EventHandler(this.CreditsDialogueButton_Click);
            // 
            // CreditsText
            // 
            this.CreditsText.BackColor = System.Drawing.SystemColors.Menu;
            this.CreditsText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CreditsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreditsText.Location = new System.Drawing.Point(15, 15);
            this.CreditsText.Margin = new System.Windows.Forms.Padding(6);
            this.CreditsText.Name = "CreditsText";
            this.CreditsText.ReadOnly = true;
            this.CreditsText.Size = new System.Drawing.Size(445, 225);
            this.CreditsText.TabIndex = 4;
            this.CreditsText.Text = resources.GetString("CreditsText.Text");
            // 
            // CreditsDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CreditsDialogueButton;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(475, 308);
            this.ControlBox = false;
            this.Controls.Add(this.CreditsText);
            this.Controls.Add(this.CreditsDialogueButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreditsDialogue";
            this.ShowInTaskbar = false;
            this.Text = "Credits";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreditsDialogueButton;
        private System.Windows.Forms.RichTextBox CreditsText;
    }
}