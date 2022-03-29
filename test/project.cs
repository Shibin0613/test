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
