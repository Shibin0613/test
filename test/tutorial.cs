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
        }

        private void tutorial1_Click(object sender, EventArgs e)
        {
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

        private void button2_Click_1(object sender, EventArgs e)
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

        private void button4_Click_1(object sender, EventArgs e)
        {
            button5.BringToFront();
            foto4.Hide();
            foto5.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            var vergelijking = new vergelijking();
            vergelijking.Show();
            this.Hide();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tekst1.MaxLength = 200;
        }

        private void opslaan_Click(object sender, EventArgs e)
        {
            string fileName = tekst1.Text;
            string docPath = "C:\\Users\\pansh\\Desktop\\text\\";
            string fullPath = Path.Combine(docPath, fileName);

            using (StreamWriter test = new StreamWriter(fullPath))
            {
                test.WriteLine(fileName);
            }

            StreamReader sr = new StreamReader("C:\\Users\\pansh\\Desktop\\text\\test.txt");
            string ouddata = sr.ReadToEnd();
            string data = tekst1.Text;
            sr.Close();
            StreamWriter sw = new StreamWriter("C:\\Users\\pansh\\Desktop\\text\\test.txt");
            sw.WriteLine(data + Environment.NewLine + ouddata);
            sw.Close();

            int count = 1;
            int X = 1;
            int Y = 1;

            for (int i = 1; i <= X; i++)
            {
                Button A = new Button();
                StreamReader er = new StreamReader("C:\\Users\\pansh\\Desktop\\text\\test.txt");
                A.Text = er.ReadLine();
                A.Name = er.ReadLine();
                er.Close();
                A.Size = new Size(100, 30);
                A.Location = new Point(25 * X, 25 * (i + 1));
                Controls.Add(A);
                count++;
                Y++;
                A.BringToFront();
            }
            

            MessageBox.Show("Gegevens opgeslagen");
        }

        private void tutorial_Load_1(object sender, EventArgs e)
        {
            int count = 1;
            int X = 5;
            int Y = 1;

            for (int i = 1; i <= X; i++)
            {
                Button A = new Button();
                StreamReader er = new StreamReader("C:\\Users\\pansh\\Desktop\\text\\test.txt");
                A.Text = er.ReadLine();
                A.Name = er.ReadLine();
                er.Close();
                A.Size = new Size(100, 30);
                A.Location = new Point(25 * X, 25 * (i + 1));
                Controls.Add(A);
                count++;
                Y++;
                A.BringToFront();
            }

        }
    }
}
