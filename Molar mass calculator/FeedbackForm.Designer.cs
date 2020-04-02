namespace Molar_mass_calculator
{
    partial class FeedbackDialogue
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
            this.FeedbackDialogueButton = new System.Windows.Forms.Button();
            this.FeedbackText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // FeedbackDialogueButton
            // 
            this.FeedbackDialogueButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.FeedbackDialogueButton.Location = new System.Drawing.Point(162, 252);
            this.FeedbackDialogueButton.Margin = new System.Windows.Forms.Padding(6);
            this.FeedbackDialogueButton.Name = "FeedbackDialogueButton";
            this.FeedbackDialogueButton.Size = new System.Drawing.Size(150, 45);
            this.FeedbackDialogueButton.TabIndex = 2;
            this.FeedbackDialogueButton.Text = "Return";
            this.FeedbackDialogueButton.UseVisualStyleBackColor = true;
            this.FeedbackDialogueButton.Click += new System.EventHandler(this.FeedbackDialogueButton_Click);
            // 
            // FeedbackText
            // 
            this.FeedbackText.BackColor = System.Drawing.SystemColors.Menu;
            this.FeedbackText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FeedbackText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FeedbackText.Location = new System.Drawing.Point(15, 15);
            this.FeedbackText.Margin = new System.Windows.Forms.Padding(6);
            this.FeedbackText.Name = "FeedbackText";
            this.FeedbackText.ReadOnly = true;
            this.FeedbackText.Size = new System.Drawing.Size(445, 225);
            this.FeedbackText.TabIndex = 3;
            this.FeedbackText.Text = "Found a bug or have an idea about a new feature?\nPlease, submit it here:\nhttps://" +
    "github.com/HonzaSTECH/Simple-Molar-Mass-Calculator/issues/new\n\nI am looking forw" +
    "ard to your feedback ;-)";
            // 
            // FeedbackDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.FeedbackDialogueButton;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(475, 308);
            this.ControlBox = false;
            this.Controls.Add(this.FeedbackText);
            this.Controls.Add(this.FeedbackDialogueButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FeedbackDialogue";
            this.ShowInTaskbar = false;
            this.Text = "Feedback";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FeedbackDialogueButton;
        private System.Windows.Forms.RichTextBox FeedbackText;
    }
}