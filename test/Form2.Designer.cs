﻿
namespace test
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Gaverder = new System.Windows.Forms.Button();
            this.Gaterug = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OpslaanPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ster2 = new System.Windows.Forms.PictureBox();
            this.ster4 = new System.Windows.Forms.PictureBox();
            this.ster3 = new System.Windows.Forms.PictureBox();
            this.ster5 = new System.Windows.Forms.PictureBox();
            this.ster1 = new System.Windows.Forms.PictureBox();
            this.Opmerking = new System.Windows.Forms.TextBox();
            this.Leesmeer = new System.Windows.Forms.Button();
            this.Puntinfo = new System.Windows.Forms.Label();
            this.Beöordelingspunt = new System.Windows.Forms.Label();
            this.Opmerkingtoevoegen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Opslaan2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Sluiten = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ster2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ster4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ster3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ster5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ster1)).BeginInit();
            this.panel1.SuspendLayout();
            ///this.OpslaanMelding.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gaverder
            // 
            this.Gaverder.Location = new System.Drawing.Point(566, 400);
            this.Gaverder.Margin = new System.Windows.Forms.Padding(4);
            this.Gaverder.Name = "Gaverder";
            this.Gaverder.Size = new System.Drawing.Size(100, 28);
            this.Gaverder.TabIndex = 2;
            this.Gaverder.Text = "Ga verder";
            this.Gaverder.UseVisualStyleBackColor = true;
            this.Gaverder.Click += new System.EventHandler(this.button2_Click);
            // 
            // Gaterug
            // 
            this.Gaterug.Location = new System.Drawing.Point(133, 400);
            this.Gaterug.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Gaterug.Name = "Gaterug";
            this.Gaterug.Size = new System.Drawing.Size(100, 31);
            this.Gaterug.TabIndex = 1;
            this.Gaterug.Text = "Ga terug\r\n";
            this.Gaterug.UseVisualStyleBackColor = true;
            this.Gaterug.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.Opmerking);
            this.panel2.Controls.Add(this.Leesmeer);
            this.panel2.Controls.Add(this.Puntinfo);
            this.panel2.Controls.Add(this.Beöordelingspunt);
            this.panel2.Controls.Add(this.Opmerkingtoevoegen);
            this.panel2.Location = new System.Drawing.Point(133, 146);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 246);
            this.panel2.TabIndex = 2;
            // 
            // OpslaanPanel
            // 
            this.OpslaanPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.OpslaanPanel.Controls.Add(this.Opslaan);
            this.OpslaanPanel.Controls.Add(this.OpslaanNee);
            this.OpslaanPanel.Controls.Add(this.label1);
            this.OpslaanPanel.Location = new System.Drawing.Point(76, 38);
            this.OpslaanPanel.Name = "OpslaanPanel";
            this.OpslaanPanel.Size = new System.Drawing.Size(391, 154);
            this.OpslaanPanel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weet u zeker dat u wilt oplsaan?";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ster2);
            this.panel4.Controls.Add(this.ster4);
            this.panel4.Controls.Add(this.ster3);
            this.panel4.Controls.Add(this.ster5);
            this.panel4.Controls.Add(this.ster1);
            this.panel4.Location = new System.Drawing.Point(33, 154);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 31);
            this.panel4.TabIndex = 4;
            // 
            // ster2
            // 
            System.Drawing.Bitmap leegster = global::test.Properties.Resources.Leegster;
            this.ster2.Image = leegster;
            this.ster2.Location = new System.Drawing.Point(43, 0);
            this.ster2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ster2.Name = "ster2";
            this.ster2.Size = new System.Drawing.Size(33, 31);
            this.ster2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ster2.TabIndex = 7;
            this.ster2.TabStop = false;
            this.ster2.Click += new System.EventHandler(this.ster2_Click);
            // 
            // ster4
            // 
            this.ster4.Image = global::test.Properties.Resources.Leegster;
            this.ster4.Location = new System.Drawing.Point(125, 0);
            this.ster4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ster4.Name = "ster4";
            this.ster4.Size = new System.Drawing.Size(33, 31);
            this.ster4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ster4.TabIndex = 6;
            this.ster4.TabStop = false;
            this.ster4.Click += new System.EventHandler(this.ster4_Click);
            // 
            // ster3
            // 
            this.ster3.Image = global::test.Properties.Resources.Leegster;
            this.ster3.Location = new System.Drawing.Point(84, 0);
            this.ster3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ster3.Name = "ster3";
            this.ster3.Size = new System.Drawing.Size(33, 31);
            this.ster3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ster3.TabIndex = 2;
            this.ster3.TabStop = false;
            this.ster3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // ster5
            // 
            this.ster5.Image = global::test.Properties.Resources.Leegster;
            this.ster5.Location = new System.Drawing.Point(167, 0);
            this.ster5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ster5.Name = "ster5";
            this.ster5.Size = new System.Drawing.Size(33, 31);
            this.ster5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ster5.TabIndex = 1;
            this.ster5.TabStop = false;
            this.ster5.Click += new System.EventHandler(this.pictureBox2_Click);
            this.ster5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            // 
            // ster1
            // 
            this.ster1.Image = global::test.Properties.Resources.Leegster;
            this.ster1.Location = new System.Drawing.Point(0, 0);
            this.ster1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ster1.Name = "ster1";
            this.ster1.Size = new System.Drawing.Size(33, 31);
            this.ster1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ster1.TabIndex = 0;
            this.ster1.TabStop = false;
            this.ster1.Click += new System.EventHandler(this.ster1_Click);
            // 
            // Opmerking
            // 
            this.Opmerking.Location = new System.Drawing.Point(300, 92);
            this.Opmerking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Opmerking.Multiline = true;
            this.Opmerking.Name = "Opmerking";
            this.Opmerking.Size = new System.Drawing.Size(199, 122);
            this.Opmerking.TabIndex = 5;
            this.Opmerking.Visible = false;
            // 
            // Leesmeer
            // 
            this.Leesmeer.BackColor = System.Drawing.Color.White;
            this.Leesmeer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Leesmeer.Location = new System.Drawing.Point(132, 81);
            this.Leesmeer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Leesmeer.Name = "Leesmeer";
            this.Leesmeer.Size = new System.Drawing.Size(100, 28);
            this.Leesmeer.TabIndex = 4;
            this.Leesmeer.Text = "Lees meer";
            this.Leesmeer.UseVisualStyleBackColor = false;
            this.Leesmeer.Click += new System.EventHandler(this.button4_Click);
            // 
            // Puntinfo
            // 
            this.Puntinfo.AutoSize = true;
            this.Puntinfo.BackColor = System.Drawing.Color.White;
            this.Puntinfo.Location = new System.Drawing.Point(33, 49);
            this.Puntinfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Puntinfo.MaximumSize = new System.Drawing.Size(200, 62);
            this.Puntinfo.MinimumSize = new System.Drawing.Size(200, 62);
            this.Puntinfo.Name = "Puntinfo";
            this.Puntinfo.Size = new System.Drawing.Size(200, 62);
            this.Puntinfo.TabIndex = 2;
            this.Puntinfo.Text = "uhasd sad  adhsuk askhha kuhdas hkuhku da\r\n\r\n";
            // 
            // Beöordelingspunt
            // 
            this.Beöordelingspunt.AutoSize = true;
            this.Beöordelingspunt.Location = new System.Drawing.Point(33, 18);
            this.Beöordelingspunt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Beöordelingspunt.Name = "Beöordelingspunt";
            this.Beöordelingspunt.Size = new System.Drawing.Size(70, 17);
            this.Beöordelingspunt.TabIndex = 1;
            this.Beöordelingspunt.Text = "Test tekst";
            this.Beöordelingspunt.Click += new System.EventHandler(this.label1_Click);
            // 
            // Opmerkingtoevoegen
            // 
            this.Opmerkingtoevoegen.Location = new System.Drawing.Point(300, 49);
            this.Opmerkingtoevoegen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Opmerkingtoevoegen.Name = "Opmerkingtoevoegen";
            this.Opmerkingtoevoegen.Size = new System.Drawing.Size(200, 31);
            this.Opmerkingtoevoegen.TabIndex = 0;
            this.Opmerkingtoevoegen.Text = "Opmerking toevoegen";
            this.Opmerkingtoevoegen.UseVisualStyleBackColor = true;
            this.Opmerkingtoevoegen.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.Gaverder);
            this.panel1.Controls.Add(this.Opslaan2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Gaterug);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 492);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Opslaan2
            // 
            this.Opslaan2.Location = new System.Drawing.Point(566, 400);
            this.Opslaan2.Margin = new System.Windows.Forms.Padding(4);
            this.Opslaan2.Name = "Opslaan2";
            this.Opslaan2.Size = new System.Drawing.Size(100, 28);
            this.Opslaan2.TabIndex = 4;
            this.Opslaan2.Text = "Opslaan";
            this.Opslaan2.UseVisualStyleBackColor = true;
            this.Opslaan2.Visible = false;
            this.Opslaan2.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.Sluiten);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(705, 28);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 308);
            this.panel3.TabIndex = 3;
            this.panel3.Visible = false;
            // 
            // Sluiten
            // 
            this.Sluiten.Location = new System.Drawing.Point(296, 276);
            this.Sluiten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Sluiten.Name = "Sluiten";
            this.Sluiten.Size = new System.Drawing.Size(100, 28);
            this.Sluiten.TabIndex = 1;
            this.Sluiten.Text = "Sluiten";
            this.Sluiten.UseVisualStyleBackColor = true;
            this.Sluiten.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(13, 12);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.MaximumSize = new System.Drawing.Size(372, 61);
            this.textBox1.MinimumSize = new System.Drawing.Size(372, 245);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(372, 245);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "vhggfghjknbvnhg";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.Gaverder);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ster2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ster4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ster3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ster5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ster1)).EndInit();
            this.panel1.ResumeLayout(false);
            //this.OpslaanMelding.ResumeLayout(false);
            //this.OpslaanMelding.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Gaverder;
        private System.Windows.Forms.Button Gaterug;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Leesmeer;
        private System.Windows.Forms.Label Puntinfo;
        private System.Windows.Forms.Label Beöordelingspunt;
        private System.Windows.Forms.Button Opmerkingtoevoegen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Sluiten;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Opmerking;
        private System.Windows.Forms.PictureBox ster1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox ster2;
        private System.Windows.Forms.PictureBox ster4;
        private System.Windows.Forms.PictureBox ster3;
        private System.Windows.Forms.PictureBox ster5;
        private System.Windows.Forms.Button Opslaan2;
        private System.Windows.Forms.Panel OpslaanPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Opslaan;
        private System.Windows.Forms.Button OpslaanNee;
        private System.Windows.Forms.Panel panel5;
    }
}