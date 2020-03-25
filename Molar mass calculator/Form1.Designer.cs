namespace Molar_mass_calculator
{
    partial class MainForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.InputField = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // InputField
            // 
            resources.ApplyResources(this.InputField, "InputField");
            this.InputField.Name = "InputField";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.SubmitButton, "SubmitButton");
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // Label
            // 
            resources.ApplyResources(this.Label, "Label");
            this.Label.Name = "Label";
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.OutputTextBox, "OutputTextBox");
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.ShortcutsEnabled = false;
            // 
            // MainForm
            // 
            this.AcceptButton = this.SubmitButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.InputField);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputField;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.RichTextBox OutputTextBox;
    }
}

