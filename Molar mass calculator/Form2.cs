using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Molar_mass_calculator
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void HelpButton1_Click(object sender, EventArgs e)
        {
            HelpDialogue helpDialogue = new HelpDialogue();
            helpDialogue.ShowDialog();
        }

        private void HelpButton2_Click(object sender, EventArgs e)
        {
            FeedbackDialogue feedbackDialogue = new FeedbackDialogue();
            feedbackDialogue.ShowDialog();
        }

        private void HelpButton3_Click(object sender, EventArgs e)
        {
            CreditsDialogue creditsDialogue = new CreditsDialogue();
            creditsDialogue.ShowDialog();
        }

        private void HelpButtonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
