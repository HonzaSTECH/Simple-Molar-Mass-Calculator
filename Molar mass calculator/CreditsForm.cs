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
