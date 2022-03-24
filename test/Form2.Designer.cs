
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
            this.Opmerkingtoevoegen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Leesmeer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Sluiten = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gaverder
            // 
            this.Gaverder.Location = new System.Drawing.Point(425, 325);
            this.Gaverder.Name = "Gaverder";
            this.Gaverder.Size = new System.Drawing.Size(75, 23);
            this.Gaverder.TabIndex = 2;
            this.Gaverder.Text = "Ga verder";
            this.Gaverder.UseVisualStyleBackColor = true;
            this.Gaverder.Click += new System.EventHandler(this.button2_Click);
            // 
            // Gaterug
            // 
            this.Gaterug.Location = new System.Drawing.Point(100, 325);
            this.Gaterug.Name = "Gaterug";
            this.Gaterug.Size = new System.Drawing.Size(75, 25);
            this.Gaterug.TabIndex = 1;
            this.Gaterug.Text = "Ga terug\r\n";
            this.Gaterug.UseVisualStyleBackColor = true;
            this.Gaterug.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.Leesmeer);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Opmerkingtoevoegen);
            this.panel2.Location = new System.Drawing.Point(100, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 200);
            this.panel2.TabIndex = 2;
            // 
            // Opmerkingtoevoegen
            // 
            this.Opmerkingtoevoegen.Location = new System.Drawing.Point(225, 40);
            this.Opmerkingtoevoegen.Name = "Opmerkingtoevoegen";
            this.Opmerkingtoevoegen.Size = new System.Drawing.Size(150, 25);
            this.Opmerkingtoevoegen.TabIndex = 0;
            this.Opmerkingtoevoegen.Text = "Opmerking toevoegen";
            this.Opmerkingtoevoegen.UseVisualStyleBackColor = true;
            this.Opmerkingtoevoegen.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Test tekst";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 40);
            this.label2.MaximumSize = new System.Drawing.Size(150, 50);
            this.label2.MinimumSize = new System.Drawing.Size(150, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "uhasd sad  adhsuk askhha kuhdas hkuhku da\r\n\r\n";
            // 
            // Leesmeer
            // 
            this.Leesmeer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Leesmeer.Location = new System.Drawing.Point(99, 66);
            this.Leesmeer.Name = "Leesmeer";
            this.Leesmeer.Size = new System.Drawing.Size(75, 23);
            this.Leesmeer.TabIndex = 4;
            this.Leesmeer.Text = "Lees meer";
            this.Leesmeer.UseVisualStyleBackColor = true;
            this.Leesmeer.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Gaterug);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 400);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.Sluiten);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(152, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 250);
            this.panel3.TabIndex = 3;
            this.panel3.Visible = false;
            // 
            // Sluiten
            // 
            this.Sluiten.Location = new System.Drawing.Point(222, 224);
            this.Sluiten.Name = "Sluiten";
            this.Sluiten.Size = new System.Drawing.Size(75, 23);
            this.Sluiten.TabIndex = 1;
            this.Sluiten.Text = "Sluiten";
            this.Sluiten.UseVisualStyleBackColor = true;
            this.Sluiten.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(10, 10);
            this.textBox1.MaximumSize = new System.Drawing.Size(280, 50);
            this.textBox1.MinimumSize = new System.Drawing.Size(280, 200);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 200);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "vhggfghjknbvnhg";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(225, 75);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 100);
            this.textBox2.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.Gaverder);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Gaverder;
        private System.Windows.Forms.Button Gaterug;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Leesmeer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Opmerkingtoevoegen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Sluiten;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}