using System;
using System.ComponentModel;
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
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string formula = InputField.Text;
            string result = Calculator.CalculateM(formula);
            OutputTextBox.Text = result;
        }
    }
}
