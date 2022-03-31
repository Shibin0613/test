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


            string getDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string fileName = "BeoordelingData.txt";
            if(!File.Exists(getDirectory + "\\" + fileName))
            {
                TextWriter txt = new StreamWriter(getDirectory + "\\" + fileName);
                txt.Close();
            }
            

            List<string> data = File.ReadAllLines(getDirectory+"\\"+fileName).ToList();
            foreach (string d in data)
            {
                string[] items = d.Split(new char[] { '|' },
                       StringSplitOptions.RemoveEmptyEntries);
                Lijst.Items.Add(new ListViewItem(items));

                
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

        private void Lijst_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = Lijst.Columns[e.ColumnIndex].Width;
        }
    }
    class Variabelen
    {
        public static string ProjectNaam = "";
    }
}
