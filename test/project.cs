﻿using System;
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
   
    public partial class project : Form
    {
      


        public project()
        {
            InitializeComponent();

          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Lijst.View = View.Details;
            Lijst.Columns.Add("Project");
            Lijst.Columns.Add("Datum");
            Lijst.Columns.Add("Klantgericht");
            Lijst.Columns.Add("Proces");
            Lijst.Columns.Add("Planning");
            Lijst.Columns.Add("Standup");
            Lijst.Columns.Add("Beroepscompetentie");
            Lijst.Columns.Add("Samenwerken");
            Lijst.Columns.Add("Beroepshouding");

            for (int i = 0; i < Lijst.Columns.Count; i++)
            {
                Lijst.Columns[i].Width = -2;
            }
        }

        private void LezenInLijst()
        {
            var fileLines = File.ReadAllLines(@"C:\Users\walsw\BeoordelingData.txt")
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            beoordeling beoordeling = new beoordeling(textBox1.Text);

            beoordeling.ShowDialog();

            Variabelen.ProjectNaam = textBox1.Text;
        }

        private void tutorial_Click(object sender, EventArgs e)
        {
            var tutorial = new tutorial();
            tutorial.Show();
            this.Hide();
        }

       

    }
    class Variabelen
    {
        public static string ProjectNaam = "";
    }
}