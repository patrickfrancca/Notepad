using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        bool changed;
        public Form1()
        {
            InitializeComponent();
        }

        private void viweToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changed = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saveAssToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            changed = true;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!changed)
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Put the file name as the title
                    this.Text = openFileDialog.FileName;
                    using (StreamReader reader = new StreamReader(openFileDialog.OpenFile()))
                    {
                        richTextBox.Text = reader.ReadToEnd();
                        changed = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Your file has been changed, do you want to save it?", "Notepad",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
        }
    }
}