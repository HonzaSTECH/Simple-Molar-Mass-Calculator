using System;
using System.Windows.Forms;

namespace Molar_mass_calculator
{
    public partial class HelpDialogue : Form
    {
        public HelpDialogue()
        {
            InitializeComponent();
        }

        private void HelpDialogueButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
