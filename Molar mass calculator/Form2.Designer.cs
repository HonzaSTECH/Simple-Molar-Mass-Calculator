namespace Molar_mass_calculator
{
    partial class HelpForm
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
            System.Windows.Forms.RichTextBox HelpText;
            this.HelpButton = new System.Windows.Forms.Button();
            HelpText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // HelpButton
            // 
            this.HelpButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.HelpButton.Location = new System.Drawing.Point(100, 162);
            this.HelpButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(83, 44);
            this.HelpButton.TabIndex = 0;
            this.HelpButton.Text = "OK";
            this.HelpButton.UseVisualStyleBackColor = true;
            // 
            // HelpText
            // 
            HelpText.BackColor = System.Drawing.SystemColors.MenuBar;
            HelpText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            HelpText.CausesValidation = false;
            HelpText.Cursor = System.Windows.Forms.Cursors.Arrow;
            HelpText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            HelpText.Location = new System.Drawing.Point(12, 12);
            HelpText.Name = "HelpText";
            HelpText.Size = new System.Drawing.Size(260, 141);
            HelpText.TabIndex = 2;
            HelpText.Text = "Help will come here\nBug report link will come here\nDeveloper\'s credit will come h" +
    "ere";
            // 
            // HelpForm
            // 
            this.AcceptButton = this.HelpButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.HelpButton;
            this.ClientSize = new System.Drawing.Size(284, 216);
            this.ControlBox = false;
            this.Controls.Add(HelpText);
            this.Controls.Add(this.HelpButton);
            this.Enabled = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "HelpForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Help";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HelpButton;
    }
}