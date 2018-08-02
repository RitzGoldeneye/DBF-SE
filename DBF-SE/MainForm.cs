﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBF_SE
{
    public partial class MainForm : Form
    {
        private string FilePath { get; set; }
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
           CharactersForm form = new CharactersForm();
            form.Show();
        }

        private void outfitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutfitsForm form = new OutfitsForm();
             form.Show();
        }

        private void movesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovesForm form = new MovesForm();
            form.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Get The save file to be opened
            OpenFileDialog OpenDialog = new OpenFileDialog();
            OpenDialog.Filter = "All Files (*.*)|*.*";
            OpenDialog.FilterIndex = 1;

            if (OpenDialog.ShowDialog() != DialogResult.OK)
            {
                OpenDialog.Dispose();
                return;
            }
            FilePath = OpenDialog.FileName;
            MainForm.ActiveForm.Text = "DBF-SE - " +FilePath;
            //Show Open File in header

            //Load File into memory
            using (var saveFS = new FileStream(FilePath, FileMode.Open))
            {
                var saveMS = new MemoryStream();
                saveFS.CopyTo(saveMS);
            }
        }
    }
}
