using System;
using System.Windows.Forms;

namespace sackMAN
{
    public partial class SimpleInputDialogForm : Form
    {
        public SimpleInputDialogForm(string title = "Input", string defaultInput = "")
        {
            InitializeComponent();

            this.Text = title;
            inputTextBox.Text = defaultInput;

            this.DialogResult = DialogResult.Abort;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void inputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
