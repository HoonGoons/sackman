using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace racman
{
    public partial class LBP2Form : Form
    {
        public lbp2 game;
        private AutosplitterHelper autosplitterHelper;
        public LBP2Form(lbp2 game)
        {
            this.game = game;
            
            InitializeComponent();
        }

        private void LBP2Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            game.api.Disconnect();
            func.api.Disconnect();
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                // Disable autosplitter.
                autosplitterHelper.Stop();
                autosplitterHelper = null;
            }
            else
            {
                // Enable autosplitter
                Console.WriteLine("Autosplitter starting!");
                autosplitterHelper = new AutosplitterHelper();
                autosplitterHelper.StartAutosplitterForGame(this.game);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MemoryForm memoryForm = new MemoryForm();
            memoryForm.Show();
        }
    }

    
}
