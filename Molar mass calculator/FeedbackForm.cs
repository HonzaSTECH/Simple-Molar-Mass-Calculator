using System;
using System.Windows.Forms;

namespace Molar_mass_calculator
{
    public partial class FeedbackDialogue : Form
    {
        public FeedbackDialogue()
        {
            InitializeComponent();
        }

        private void FeedbackDialogueButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
