using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class vergelijking : Form
    {
        public vergelijking()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var tutorial = new tutorial();
            tutorial.Show();
            this.Hide();
        }

        private void logo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", "/c start https://www.instagram.com/Shibin0613/");
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (MessageBox.Show("Weet je zeker dat je deze applicatie wilt afsluiten?", "Applicatie afsluiten", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}


