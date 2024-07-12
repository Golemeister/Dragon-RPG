using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace WindowsFormsApplication1
{
    class Zmaj
    {
        int health;
        int damage;
        string ime = "";
        Label ispis;
        ProgressBar healthbar;
        PictureBox ikona;
        GroupBox grupbox;
        Image slika;
        Button loot;
        
        
        public Zmaj(int damage, int health, string ime,Label ispis,ProgressBar healthbar,PictureBox ikona,GroupBox grupbox,Image slika,Button loot)
        {
            this.damage = damage;
            this.health = health;
            if (ime != "")
            {
                this.ime = ime;
            }
            else
            {
                this.ime = "Zmajko";
            }
            this.ispis = ispis;
            
            this.healthbar = healthbar;
            this.healthbar.Maximum = health;
            this.healthbar.Value = health;
            
            
            this.grupbox = grupbox;

            this.slika = slika;

            this.ikona = ikona;
            this.ikona.Image = slika;
            this.loot = loot;
        }
        
        public void Primiudarac(int jacinaudarca)
        {
            Kontrole.glavni_igrac.broj_napada ++;
            if (Kontrole.glavni_igrac.broj_napada == 3)
            {
                Kontrole.glavni_igrac.health += 200;
                Kontrole.glavni_igrac.broj_napada = 0;
            }
            
            this.health -= jacinaudarca;
            Kontrole.glavni_igrac.health -= this.damage;
            
            if (health <= 0)
            {
                health = 0;
                ikona.Image = Properties.Resources.Dead_Dragon3;
                grupbox.Enabled = false;
                Form1.mrtvi_zmajevi ++;
                loot.Visible = true;
                
            }
            
            if (Kontrole.glavni_igrac.health <= 0)
            {
                Kontrole.glavni_igrac.health = 0;
                MessageBox.Show("Izgubio si!");
                Application.Exit();
            }
            
            if (Form1.mrtvi_zmajevi == Form1.brzm)
            {
                Kontrole.glavna_forma.dugme.Enabled = true;
                Form1.mrtvi_zmajevi = 0;
                
            }
                
            this.healthbar.Value = health;
            Status();

            if (Kontrole.glavni_igrac.health > Kontrole.glavni_igrac.maxhealth)
            {
                Kontrole.glavni_igrac.health = Kontrole.glavni_igrac.maxhealth;
            }
            Kontrole.glavni_igrac.zivot.Value = Kontrole.glavni_igrac.health;
            Kontrole.glavni_igrac.Status_igraca();
        }
        public void Status()
        {
            ispis.Text =  ime + "\r\nhealth:" + health + "\r\ndamage:" + damage;
            
        }

    }
}
