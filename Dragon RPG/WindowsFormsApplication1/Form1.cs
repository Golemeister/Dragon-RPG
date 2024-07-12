using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Zmaj prvi;
        Zmaj drugi;
        Zmaj treci;
        Zmaj cetvrti;
        public static Button dugme_pocetak;
        public static int brzm;
        public static int mrtvi_zmajevi = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            dugme_pocetak = button1;
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
          prvi.Primiudarac(100);
          prvi.Status();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
         drugi.Primiudarac(100);
         drugi.Status();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            treci.Primiudarac(100);
            treci.Status();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            cetvrti.Primiudarac(100);
            cetvrti.Status();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Random broj_zmajeva= new Random();
            brzm = broj_zmajeva.Next(1, 5);
            switch (brzm)
            {
                case 1:
                    prvi = new Zmaj(150, 500, "Kim", label2, progressBar1, pictureBox1, groupBox1, Properties.Resources.silver);
                    prvi.Status();
                    break;
                case 2:
                    prvi = new Zmaj(150, 500, "Kim", label2, progressBar1, pictureBox1, groupBox1, Properties.Resources.silver);
                    drugi = new Zmaj(200, 300, "Ceda", label4, progressBar2, pictureBox2, groupBox3, Properties.Resources.scarlet);
                    prvi.Status();
                    drugi.Status();
                    break;
                case 3:
                    prvi = new Zmaj(150, 500, "Kim", label2, progressBar1, pictureBox1, groupBox1, Properties.Resources.silver);
                    drugi = new Zmaj(200, 300, "Ceda", label4, progressBar2, pictureBox2, groupBox3, Properties.Resources.scarlet);
                    treci = new Zmaj(50, 1500, "Marko", label6, progressBar3, pictureBox3, groupBox5, Properties.Resources.shi_by_thebluestjay_d7yn0um);
                    prvi.Status();
                    drugi.Status();
                    treci.Status();
                    break;
                case 4:
                    prvi = new Zmaj(150, 500, "Kim", label2, progressBar1, pictureBox1, groupBox1, Properties.Resources.silver);
                    drugi = new Zmaj(200, 300, "Ceda", label4, progressBar2, pictureBox2, groupBox3, Properties.Resources.scarlet);
                    treci = new Zmaj(50, 1500, "Marko", label6, progressBar3, pictureBox3, groupBox5, Properties.Resources.shi_by_thebluestjay_d7yn0um);
                    cetvrti = new Zmaj(100, 700, "Nikola", label8, progressBar4, pictureBox4, groupBox7, Properties.Resources.king);
                    prvi.Status();
                    drugi.Status();
                    treci.Status();
                    cetvrti.Status();
                    break;
            }
        }

    }

}
