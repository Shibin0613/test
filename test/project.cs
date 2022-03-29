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
            var fileLines = File.ReadAllLines(@"C:\Users\walsw\BeoordelingData.txt"))
            
            for (int i = 0; i + 4 < fileLines.Length; i += 5)
            {
                Lijst.Items.Add(
                    new ListViewItem(new[]
                    {
                        fileLines[i],
                        fileLines[i + 1],
                        fileLines[i + 2],
                        fileLines[i + 3],
                        fileLines[i + 4],
                        fileLines[i + 5],
                        fileLines[i + 6],
                        fileLines[i + 7],
                        fileLines[i + 8]
                    }));
            }

            for (int i = 0; i < Lijst.Columns.Count; i++)
                {
                Lijst.Columns[i].Width = -2;
                }

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
