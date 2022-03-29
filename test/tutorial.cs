using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace test
{
    public partial class tutorial : Form
    {
        public tutorial()
        {
            InitializeComponent();
            foto1.Show();
            button1.BringToFront();
        }

        private void slaover_Click(object sender, EventArgs e)
        {
            var vergelijking = new vergelijking();
            vergelijking.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.BringToFront();
            foto1.Hide();
            foto2.Show();
        }

        private void foto4_Click(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (MessageBox.Show("Weet je zeker dat je deze applicatie wilt afsluiten?", "Applicatie afsluiten", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.BringToFront();
            foto2.Hide();
            foto3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.BringToFront();
            foto3.Hide();
            foto4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button5.BringToFront();
            foto4.Hide();
            foto5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var vergelijking = new vergelijking();
            vergelijking.Show();
            this.Hide();
        }
    }
}
