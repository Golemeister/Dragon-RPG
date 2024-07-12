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
        public Button dugme;
        public static int brzm;
        public static int mrtvi_zmajevi = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            Kontrole.glavna_forma = this;
            dugme = button1;
            Kontrole.glavni_igrac = new Igrac(1000, 100, "Zoran", label10, progressBar5);
            Kontrole.glavni_igrac.Status_igraca();
           
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
          prvi.Primiudarac(Kontrole.glavni_igrac.damage);
          prvi.Status();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            drugi.Primiudarac(Kontrole.glavni_igrac.damage);
         drugi.Status();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            treci.Primiudarac(Kontrole.glavni_igrac.damage);
            treci.Status();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            cetvrti.Primiudarac(Kontrole.glavni_igrac.damage);
            cetvrti.Status();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox9.Visible = true;
            button1.Enabled = false;
            groupBox1.Enabled = true;
            groupBox3.Enabled = true;
            groupBox5.Enabled = true;
            groupBox7.Enabled = true;
            Random broj_zmajeva= new Random();
            brzm = broj_zmajeva.Next(1, 5);
            switch (brzm)
            {
                case 1:
                    prvi = new Zmaj(150, 500, "Kim", label2, progressBar1, pictureBox1, groupBox1, Properties.Resources.silver,button2);
                    groupBox1.Visible = true;
                    groupBox3.Visible = false;
                    groupBox5.Visible = false;
                    groupBox7.Visible = false;
                    prvi.Status();
                    break;
                case 2:
                    prvi = new Zmaj(150, 500, "Kim", label2, progressBar1, pictureBox1, groupBox1, Properties.Resources.silver,button2);
                    drugi = new Zmaj(200, 300, "Ceda", label4, progressBar2, pictureBox2, groupBox3, Properties.Resources.scarlet,button3);
                    groupBox1.Visible = true;
                    groupBox3.Visible = true;
                    groupBox5.Visible = false;
                    groupBox7.Visible = false;
                    prvi.Status();
                    drugi.Status();
                    break;
                case 3:
                    prvi = new Zmaj(150, 500, "Kim", label2, progressBar1, pictureBox1, groupBox1, Properties.Resources.silver,button2);
                    drugi = new Zmaj(200, 300, "Ceda", label4, progressBar2, pictureBox2, groupBox3, Properties.Resources.scarlet,button3);
                    treci = new Zmaj(80, 1000, "Marko", label6, progressBar3, pictureBox3, groupBox5, Properties.Resources.shi_by_thebluestjay_d7yn0um,button4);
                    groupBox1.Visible = true;
                    groupBox3.Visible = true;
                    groupBox5.Visible = true;
                    groupBox7.Visible = false;
                    prvi.Status();
                    drugi.Status();
                    treci.Status();
                    break;
                case 4:
                    prvi = new Zmaj(150, 500, "Kim", label2, progressBar1, pictureBox1, groupBox1, Properties.Resources.silver,button2);
                    drugi = new Zmaj(200, 300, "Ceda", label4, progressBar2, pictureBox2, groupBox3, Properties.Resources.scarlet,button3);
                    treci = new Zmaj(80, 1000, "Marko", label6, progressBar3, pictureBox3, groupBox5, Properties.Resources.shi_by_thebluestjay_d7yn0um,button4);
                    cetvrti = new Zmaj(100, 700, "Nikola", label8, progressBar4, pictureBox4, groupBox7, Properties.Resources.king,button5);
                    groupBox1.Visible = true;
                    groupBox3.Visible = true;
                    groupBox5.Visible = true;
                    groupBox7.Visible = true;
                    prvi.Status();
                    drugi.Status();
                    treci.Status();
                    cetvrti.Status();
                    break;
            }
        }
            public void Omogucisledecinivo()
            {
                button1.Enabled = true;
                
  
            }

            private void button2_Click(object sender, EventArgs e)
            {
                if (Kontrole.glavni_igrac.exp + 100 >= Kontrole.glavni_igrac.Levelup)
                {
                    Kontrole.glavni_igrac.Level += 1;
                    Kontrole.glavni_igrac.exp = Kontrole.glavni_igrac.exp + 100 - Kontrole.glavni_igrac.Levelup;
                    Kontrole.glavni_igrac.Levelup += 100;
                    Kontrole.glavni_igrac.damage += 25;
                    Kontrole.glavni_igrac.maxhealth += 50;
                    Kontrole.glavni_igrac.health += 50;
                }
                else
                {
                    Kontrole.glavni_igrac.exp += 100;
                }
                
                    
                if (Kontrole.glavni_igrac.health > Kontrole.glavni_igrac.maxhealth - 200)
                {
                    Kontrole.glavni_igrac.health = Kontrole.glavni_igrac.maxhealth;
                }
                else
                {
                    Kontrole.glavni_igrac.health += 200;
                }

                Kontrole.glavni_igrac.Status_igraca();
                button2.Visible = false;
            }

            private void button3_Click(object sender, EventArgs e)
            {
                if (Kontrole.glavni_igrac.exp + 100 >= Kontrole.glavni_igrac.Levelup)
                {
                    Kontrole.glavni_igrac.Level += 1;
                    Kontrole.glavni_igrac.exp = Kontrole.glavni_igrac.exp + 100 - Kontrole.glavni_igrac.Levelup;
                    Kontrole.glavni_igrac.Levelup += 100;
                    Kontrole.glavni_igrac.damage += 25;
                    Kontrole.glavni_igrac.maxhealth += 50;
                    Kontrole.glavni_igrac.health += 50;
                }
                else
                {
                    Kontrole.glavni_igrac.exp += 100;
                }

                if (Kontrole.glavni_igrac.health > Kontrole.glavni_igrac.maxhealth - 200)
                {
                    Kontrole.glavni_igrac.health = Kontrole.glavni_igrac.maxhealth;
                }
                else
                {
                    Kontrole.glavni_igrac.health += 200;
                }
                 
                Kontrole.glavni_igrac.Status_igraca();
                button3.Visible = false;
            }

            private void button4_Click(object sender, EventArgs e)
            {
                if (Kontrole.glavni_igrac.exp + 100 >= Kontrole.glavni_igrac.Levelup)
                {
                    Kontrole.glavni_igrac.Level += 1;
                    Kontrole.glavni_igrac.exp = Kontrole.glavni_igrac.exp + 100 - Kontrole.glavni_igrac.Levelup;
                    Kontrole.glavni_igrac.Levelup += 100;
                    Kontrole.glavni_igrac.damage += 25;
                    Kontrole.glavni_igrac.maxhealth += 50;
                    Kontrole.glavni_igrac.health += 50;
                }
                else
                {
                    Kontrole.glavni_igrac.exp += 100;
                }
                
                if (Kontrole.glavni_igrac.health > Kontrole.glavni_igrac.maxhealth - 200)
                {
                    Kontrole.glavni_igrac.health = Kontrole.glavni_igrac.maxhealth;
                }
                else
                {
                    Kontrole.glavni_igrac.health += 200;
                }
                
    
                Kontrole.glavni_igrac.Status_igraca();
                button4.Visible = false;
            }

            private void button5_Click(object sender, EventArgs e)
            {
                if (Kontrole.glavni_igrac.exp + 100 >= Kontrole.glavni_igrac.Levelup)
                {
                    Kontrole.glavni_igrac.Level += 1;
                    Kontrole.glavni_igrac.exp = Kontrole.glavni_igrac.exp + 100 - Kontrole.glavni_igrac.Levelup;
                    Kontrole.glavni_igrac.Levelup += 100;
                    Kontrole.glavni_igrac.damage += 25;
                    Kontrole.glavni_igrac.maxhealth += 50;
                    Kontrole.glavni_igrac.health += 50;
                }
                else
                {
                    Kontrole.glavni_igrac.exp += 100;
                }

                if (Kontrole.glavni_igrac.health > Kontrole.glavni_igrac.maxhealth - 200)
                {
                    Kontrole.glavni_igrac.health = Kontrole.glavni_igrac.maxhealth;
                }
                else
                {
                    Kontrole.glavni_igrac.health += 200;
                }
                Kontrole.glavni_igrac.Status_igraca();
                button5.Visible = false;
            }
        

    }

}
