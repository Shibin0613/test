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
    public partial class Form1 : Form
    {
        public Form1()
        

        {
            InitializeComponent();
        }
        

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Run(new Form1());
        }

        private void Opslaan_Click(object sender, EventArgs e)
        {
             OpslaanPanel.Visible = true;
        }

        private void OpslaanJA_Click(object sender, EventArgs e)
        {


            string ProjectNaam = textBox2.Text;
            string bestandsnaam = "Data.txt";
            string pad = @"C:\Users\walsw\source\repos\test\";
            string datum = DateTime.Now.ToString("dd/MM");
            System.IO.File.AppendAllText(pad + bestandsnaam, " | " + ProjectNaam + " | " + datum + " | " + Environment.NewLine);
            OpslaanPanel.Visible = false;
            OpslaanMelding.Visible = true;
        }

        private void OpslaanNEE_Click(object sender, EventArgs e)
        {
            OpslaanPanel.Visible = false;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
           
        }

        private void label12_Click(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void Opslaan_Click_1(object sender, EventArgs e)
        {
            OpslaanPanel.Visible = true;
        }

        private void OpslaanJA_Click_1(object sender, EventArgs e)
        {
            string ProjectNaam = textBox2.Text;
            string bestandsnaam = "Data.txt";
            string pad = @"C:\Users\walsw\source\repos\test\";
            string datum = DateTime.Now.ToString("dd/MM");
            System.IO.File.AppendAllText(pad + bestandsnaam, " | " + ProjectNaam + " | " + datum + " | " + Environment.NewLine);
            OpslaanPanel.Visible = false;
            OpslaanMelding.Visible = true;
        }

        private void OpslaanNEE_Click_1(object sender, EventArgs e)
        {
            OpslaanPanel.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
