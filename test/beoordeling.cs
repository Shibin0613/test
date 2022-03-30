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
    public partial class beoordeling : Form
    {
        private string projectName;

        public beoordeling(string name)
        {
            InitializeComponent();
            //Console.WriteLine(rating1 + " " + rating2 + " " + rating3 + " " + rating4 + " " + rating5 + " " + rating6 + " " + rating6);

            projectName = name;
        }

        int pagina = 1;
        
        String beöordelingspunt1 = "Klantgericht";
        String beöordelingspunt2 = "Proces";
        String beöordelingspunt3 = "Planning";
        String beöordelingspunt4 = "Standup";
        String beöordelingspunt5 = "Beroepscompetentie";
        String beöordelingspunt6 = "Samenwerken";
        String beöordelingspunt7 = "Beroepshouding";

        String Beöorderlingtext1 = "Hoe goed heb je op de klant gericht?";
        String Beöorderlingtext2 = "Hoe verliep het proces?";
        String Beöorderlingtext3 = "Hoe verliep de planning?";
        String Beöorderlingtext4 = "Hoe verliepen de standups?";
        String Beöorderlingtext5 = "Beroepscompetentie";
        String Beöorderlingtext6 = "Hoe is het samenwerken gegaan?";
        String Beöorderlingtext7 = "Beroepshouding";

        String Beöorderlinginfo1 = "Hoe goed was je afgelopen periode op de klant gericht? Hier beoordeel je hoe goed je samen hebt gewerkt met de klant. Heb je alles gedaan waar naar gevraagd werd? Heb je goed overlegt met de klant over wat er wordt verwacht?";
        String Beöorderlinginfo2 = "Hoe verliep het proces van de afgelopen periode? Beoordeel hier hoe jij vond dat het werk verliep. Verliep alles goed of ben je nog tegen enkele problemen aangelopen, en zo ja hoe heb je deze opgelost?";
        String Beöorderlinginfo3 = "Hoe verliep de planning van de afgelopen periode? Ben je op schema gebleven met alle taken of ben je ergens op blijven haken? Of misschien loop je zelfs voor op schema. Het is misschien handig om bij de opmerking te laten weten waar het goed of fout ging.";
        String Beöorderlinginfo4 = "Is er elke dag tijd gemaakt voor een standup met het team? Is er elke dag van de afgelopen periode een standup met het team geweest om te bespreken wat er vorige keer is gedaan en waar iedereen mee bezig gaat. Ben je ook tevreden met hoe de standups verliepen?";
        String Beöorderlinginfo5 = "Beroepscompetentie";
        String Beöorderlinginfo6 = "Hoe verliep de samenwerking met het team in de afgelopen periode? Ben je tevreden met de communicatie tussen ieder teamlid en wist je altijd waar elk lid aan toe was? Wilden de leden je helpen wanneer je vast zat op een probleem of wanneer je een vraag had?";
        String Beöorderlinginfo7 = "Beroepshouding";

        String Opmerking1 = "";
        String Opmerking2 = "";
        String Opmerking3 = "";
        String Opmerking4 = "";
        String Opmerking5 = "";
        String Opmerking6 = "";
        String Opmerking7 = "";

        //int rating1;
        //int rating2;
        //int rating3;
        //int rating4;
        //int rating5;
        //int rating6;
        //int rating7;

        int rating = 0;

        
        

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = Beöorderlinginfo1;
            Beöordelingspunt.Text = beöordelingspunt1;
            Puntinfo.Text = Beöorderlingtext1;
            Leesmeer.FlatStyle = FlatStyle.Flat;
            Leesmeer.FlatAppearance.BorderSize = 0;
            Leesmeer.BackColor = Color.White;
        }

        private void Sterrentonen(int ratings)
        {
            switch (ratings)
            {
                case 0:
                    {
                        ster(0);
                        break;
                    }
                case 1:
                    {
                        ster(1);
                        break;
                    }
                case 2:
                    {
                        ster(2);
                        break;
                    }
                case 3:
                    {
                        ster(3);
                        break;
                    }
                case 4:
                    {
                        ster(4);
                        break;
                    }
                case 5:
                    {
                        ster(5);
                        break;
                    }
            }
        }
        private void Sterrenopslaan(int ratingnumber)
        {
            switch (pagina)
            {
                case 1:
                    {
                        Beoordelingen.rating1 = ratingnumber;
                        break;
                    }
                case 2:
                    {
                        Beoordelingen.rating2 = ratingnumber;
                        break;
                    }
                case 3:
                    {
                        Beoordelingen.rating3 = ratingnumber;
                        break;
                    }
                case 4:
                    {
                        Beoordelingen.rating4 = ratingnumber;
                        break;
                    }
                case 5:
                    {
                        Beoordelingen.rating5 = ratingnumber;
                        break;
                    }
                case 6:
                    {
                        Beoordelingen.rating6 = ratingnumber;
                        break;
                    }
                case 7:
                    {
                        Beoordelingen.rating7 = ratingnumber;
                        break;
                    }
            }
        }
        private void Paginaopslaan()
        {
            switch (pagina)
            {
                case 1:
                    {
                        Opmerking1 = Opmerking.Text;
                        break;
                    }
                case 2:
                    {
                        Opmerking2 = Opmerking.Text;
                        break;
                    }
                case 3:
                    {
                        Opmerking3 = Opmerking.Text;
                        break;
                    }
                case 4:
                    {
                        Opmerking4 = Opmerking.Text;
                        break;
                    }
                case 5:
                    {
                        Opmerking5 = Opmerking.Text;
                        break;
                    }
                case 6:
                    {
                        Opmerking6 = Opmerking.Text;
                        break;
                    }
                case 7:
                    {
                        Opmerking7 = Opmerking.Text;
                        break;
                    }
                case 8:
                    {
                        break;
                    }
            }
        }
        private void Paginatonen()
        {
            switch (pagina)
            {
                case 1:
                    {
                        Opmerking.Text = Opmerking1;
                        textBox1.Text = Beöorderlinginfo1;
                        Beöordelingspunt.Text = beöordelingspunt1;
                        Puntinfo.Text = Beöorderlingtext1;
                        Sterrentonen(Beoordelingen.rating1);
                        break;
                    }
                case 2:
                    {
                        Opmerking.Text = Opmerking2;
                        textBox1.Text = Beöorderlinginfo2;
                        Beöordelingspunt.Text = beöordelingspunt2;
                        Puntinfo.Text = Beöorderlingtext2;
                        Sterrentonen(Beoordelingen.rating2);
                        break;
                    }
                case 3:
                    {
                        Opmerking.Text = Opmerking3;
                        textBox1.Text = Beöorderlinginfo3;
                        Beöordelingspunt.Text = beöordelingspunt3;
                        Puntinfo.Text = Beöorderlingtext3;
                        Sterrentonen(Beoordelingen.rating3);
                        break;
                    }
                case 4:
                    {
                        Opmerking.Text = Opmerking4;
                        textBox1.Text = Beöorderlinginfo4;
                        Beöordelingspunt.Text = beöordelingspunt4;
                        Puntinfo.Text = Beöorderlingtext4;
                        Sterrentonen(Beoordelingen.rating4);
                        break;
                    }
                case 5:
                    {
                        Opmerking.Text = Opmerking5;
                        textBox1.Text = Beöorderlinginfo5;
                        Beöordelingspunt.Text = beöordelingspunt5;
                        Puntinfo.Text = Beöorderlingtext5;
                        Sterrentonen(Beoordelingen.rating5);
                        break;
                    }
                case 6:
                    {
                        Opmerking.Text = Opmerking6;
                        textBox1.Text = Beöorderlinginfo6;
                        Beöordelingspunt.Text = beöordelingspunt6;
                        Puntinfo.Text = Beöorderlingtext6;
                        Sterrentonen(Beoordelingen.rating6);
                        Gaverder.Visible = true;
                        Opslaan2.Visible = false;
                        break;
                    }
                case 7:
                    {
                        Opmerking.Text = Opmerking7;
                        textBox1.Text = Beöorderlinginfo7;
                        Beöordelingspunt.Text = beöordelingspunt7;
                        Puntinfo.Text = Beöorderlingtext7;
                        Sterrentonen(Beoordelingen.rating7);
                        Gaverder.Visible = false;
                        Opslaan2.Visible = true;
                        break;
                    }
            }
        }
        private void ster(int rating)
        {
            ster1.Image = test.Properties.Resources.Leegster;
            ster2.Image = test.Properties.Resources.Leegster;
            ster3.Image = test.Properties.Resources.Leegster;
            ster4.Image = test.Properties.Resources.Leegster;
            ster5.Image = test.Properties.Resources.Leegster;

            for (int i = 1; i <= rating; i++)
            {
                switch (i)
                {
                    case 1:
                        {
                            ster1.Image = test.Properties.Resources.Volster;
                            break;
                        }
                    case 2:
                        {
                            ster2.Image = test.Properties.Resources.Volster;
                            break;
                        }
                    case 3:
                        {
                            ster3.Image = test.Properties.Resources.Volster;
                            break;
                        }
                    case 4:
                        {
                            ster4.Image = test.Properties.Resources.Volster;
                            break;
                        }
                    case 5:
                        {
                            ster5.Image = test.Properties.Resources.Volster;
                            break;
                        }
                }
            }
        }
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Paginaopslaan();
            pagina--;
            Paginatonen();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Location = new Point(150, 100);
            panel3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Paginaopslaan();
            pagina++;
            Paginatonen();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Opmerking.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ster1_Click(object sender, EventArgs e)
        {
            rating = 1;
            Sterrenopslaan(1);
            ster(rating);
        }
        private void ster2_Click(object sender, EventArgs e)
        {
            rating = 2;
            Sterrenopslaan(2);
            ster(rating);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            rating = 3;
            Sterrenopslaan(3);
            ster(rating);
        }
        private void ster4_Click(object sender, EventArgs e)
        {
            rating = 4;
            Sterrenopslaan(4);
            ster(rating);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            rating = 5;
            Sterrenopslaan(5);
            ster(rating);
        }


        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel6.Visible = true;
        }
 

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void OpslaanNee_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
        }
        private void ster1_MouseHover(object sender, EventArgs e)
        {
            rating = 1;
            ster(rating);
        }


        private void ster2_MouseHover(object sender, EventArgs e)
        {
            rating = 2;
            ster(rating);
        }

        private void ster3_MouseHover(object sender, EventArgs e)
        {
            rating = 3;
            ster(rating);
        }

        private void ster4_MouseHover(object sender, EventArgs e)
        {
            rating = 4;
            ster(rating);
        }

        private void ster5_MouseHover(object sender, EventArgs e)
        {
            rating = 5;
            ster(rating);
        }
        private void Opslaan_Click_1(object sender, EventArgs e)
        {
            string bestandsnaam = "BeoordelingData.txt";
            string pad = @"C:\Users\walsw\";
            string datum = DateTime.Now.ToString("dd/MM");
            System.IO.File.AppendAllText(pad + bestandsnaam, projectName + " | " + datum + " | " + Beoordelingen.rating1 + " | " + Beoordelingen.rating2 + " | " + Beoordelingen.rating3 + " | " + Beoordelingen.rating4 + " | " + Beoordelingen.rating5 + " | " + Beoordelingen.rating6 + " | " + Beoordelingen.rating7 + Environment.NewLine);
            panel6.Visible = false;

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void ster1_MouseLeave(object sender, EventArgs e)
        {
            Paginatonen();
        }

        private void ster2_MouseLeave(object sender, EventArgs e)
        {
            Paginatonen();
        }

        private void ster3_MouseLeave(object sender, EventArgs e)
        {
            Paginatonen();
        }

        private void ster4_MouseLeave(object sender, EventArgs e)
        {
            Paginatonen();
        }

        private void ster5_MouseLeave(object sender, EventArgs e)
        {
            Paginatonen();
        }

       
    }
    class Beoordelingen
    {
        public static int rating1;
        public static int rating2;
        public static int rating3;
        public static int rating4;
        public static int rating5;
        public static int rating6;
        public static int rating7;
    }
}
