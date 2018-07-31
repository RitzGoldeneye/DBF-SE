using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBF_SE
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            {
                const string message = "Do you really want to exit?";
                const string caption = "Exit";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else if (result != DialogResult.Yes)
                {
                    //Close dialog and do nothing
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                const string message = "Do you really want to exit?";
                const string caption = "Exit";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else if (result != DialogResult.Yes)
                {
                    //Close dialog and do nothing
                }
            }
        }

        private void charactersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CharactersForm();        
        }
    }
}
