using System;
using System.IO;
using System.Windows.Forms;

namespace sackMAN
{
    public partial class SackmanScripting : Form
    {
        public SackmanScripting()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = $"{Directory.GetCurrentDirectory()}\\mods";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var lines = File.ReadAllLines(openFileDialog.FileName);
                    codeBox.Lines = lines;
                }
            }
        }

        public bool RunCurrentCode()
        {
            if (codeBox.Text == null || codeBox.Text == "") return true;
            var res = new LuaAutomation(codeBox.Text);
            return !res.failed;
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            RunCurrentCode();
        }
    }
}