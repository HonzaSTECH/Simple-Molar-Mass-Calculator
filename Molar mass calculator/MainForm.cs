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

        private void InputField_TextChanged(object sender, EventArgs e)
        {
            if (InputField.TextLength > 0)
            {
                //Enabling the submit button
                SubmitButton.Enabled = true;
            }
            else
            {
                //Disabling the submit button
                SubmitButton.Enabled = false;
            }
        }

        private void OutputTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ContextMenu contextMenu = new System.Windows.Forms.ContextMenu();
                MenuItem menuItem = new MenuItem("Copy");
                menuItem.Click += new EventHandler(CopyAction);
                contextMenu.MenuItems.Add(menuItem);

                OutputTextBox.ContextMenu = contextMenu;
            }
        }

        void CopyAction(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(OutputTextBox.SelectedText);
            }
            catch (ArgumentNullException)
            {
                //No text is selected --> copy everything
                Clipboard.SetText(OutputTextBox.Text);
            }
        }
    }
}
