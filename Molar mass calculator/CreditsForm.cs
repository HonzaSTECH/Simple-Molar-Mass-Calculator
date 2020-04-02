using System;
using System.Windows.Forms;

namespace Molar_mass_calculator
{
    public partial class CreditsDialogue : Form
    {
        public CreditsDialogue()
        {
            InitializeComponent();
        }

        private void CreditsDialogueButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
