namespace Molar_mass_calculator
{
    partial class HelpDialogue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpDialogue));
            this.HelpDialogueButton = new System.Windows.Forms.Button();
            this.HelpText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // HelpDialogueButton
            // 
            this.HelpDialogueButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.HelpDialogueButton.Location = new System.Drawing.Point(162, 252);
            this.HelpDialogueButton.Margin = new System.Windows.Forms.Padding(6);
            this.HelpDialogueButton.Name = "HelpDialogueButton";
            this.HelpDialogueButton.Size = new System.Drawing.Size(150, 45);
            this.HelpDialogueButton.TabIndex = 0;
            this.HelpDialogueButton.Text = "Return";
            this.HelpDialogueButton.UseVisualStyleBackColor = true;
            this.HelpDialogueButton.Click += new System.EventHandler(this.HelpDialogueButton_Click);
            // 
            // HelpText
            // 
            this.HelpText.BackColor = System.Drawing.SystemColors.Menu;
            this.HelpText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.HelpText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HelpText.Location = new System.Drawing.Point(15, 15);
            this.HelpText.Margin = new System.Windows.Forms.Padding(6);
            this.HelpText.Name = "HelpText";
            this.HelpText.ReadOnly = true;
            this.HelpText.Size = new System.Drawing.Size(445, 225);
            this.HelpText.TabIndex = 1;
            this.HelpText.Text = resources.GetString("HelpText.Text");
            // 
            // HelpDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.HelpDialogueButton;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(475, 308);
            this.ControlBox = false;
            this.Controls.Add(this.HelpText);
            this.Controls.Add(this.HelpDialogueButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "HelpDialogue";
            this.ShowInTaskbar = false;
            this.Text = "Help";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HelpDialogueButton;
        private System.Windows.Forms.RichTextBox HelpText;
    }
}