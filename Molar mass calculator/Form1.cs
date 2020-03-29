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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        static void HelpButton_Click(object sender, CancelEventArgs e)
        {
            //MessageBox.Show("Help will come here\nBug report link will come here\nDeveloper's credit will come here", "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string formula = InputField.Text;
            /*
             Do calculations
             */
            OutputTextBox.Text = formula+"\nDisplay result here...";
        }
    }
}
