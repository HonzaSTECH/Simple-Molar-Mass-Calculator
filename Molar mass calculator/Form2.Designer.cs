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
            this.HelpButton2 = new System.Windows.Forms.Button();
            this.HelpButton3 = new System.Windows.Forms.Button();
            this.HelpButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HelpButton2
            // 
            this.HelpButton2.Location = new System.Drawing.Point(61, 59);
            this.HelpButton2.Name = "HelpButton2";
            this.HelpButton2.Size = new System.Drawing.Size(161, 41);
            this.HelpButton2.TabIndex = 2;
            this.HelpButton2.Text = "Feedback";
            this.HelpButton2.UseVisualStyleBackColor = true;
            this.HelpButton2.Click += new System.EventHandler(this.HelpButton2_Click);
            // 
            // HelpButton3
            // 
            this.HelpButton3.Location = new System.Drawing.Point(61, 106);
            this.HelpButton3.Name = "HelpButton3";
            this.HelpButton3.Size = new System.Drawing.Size(161, 41);
            this.HelpButton3.TabIndex = 3;
            this.HelpButton3.Text = "Credits";
            this.HelpButton3.UseVisualStyleBackColor = true;
            this.HelpButton3.Click += new System.EventHandler(this.HelpButton3_Click);
            // 
            // HelpButton1
            // 
            this.HelpButton1.Location = new System.Drawing.Point(61, 12);
            this.HelpButton1.Name = "HelpButton1";
            this.HelpButton1.Size = new System.Drawing.Size(161, 41);
            this.HelpButton1.TabIndex = 1;
            this.HelpButton1.Text = "Help";
            this.HelpButton1.UseVisualStyleBackColor = true;
            this.HelpButton1.Click += new System.EventHandler(this.HelpButton1_Click);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 159);
            this.Controls.Add(this.HelpButton1);
            this.Controls.Add(this.HelpButton3);
            this.Controls.Add(this.HelpButton2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Information";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HelpButton2;
        private System.Windows.Forms.Button HelpButton3;
        private System.Windows.Forms.Button HelpButton1;
    }
}