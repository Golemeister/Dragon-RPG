using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    class Igrac
    {
        public int health;
        public int damage;
        public string ime;
        public Label ispis;
        public ProgressBar zivot;
        public int broj_napada = 0;
        public int maxhealth;
        public int exp = 0;
        public int Level = 1;
        public int Levelup = 200;
        public Igrac(int health, int damage, string name,Label ispis,ProgressBar zivot)
        {
            this.health = health;
            this.damage = damage;
            this.ime = name;
            this.ispis = ispis;
            this.zivot = zivot;
            this.maxhealth = health;
            zivot.Maximum = maxhealth;
            zivot.Value = health;
        }
        public void Status_igraca()
        {
            ispis.Text = ime + "\r\nhealth:" + health + "\r\ndamage:" + damage + "\r\nLevel:" +Level+"\r\nExp:" + exp+"/"+Levelup+ "exp";

            if (this.health > this.maxhealth)
            {
                this.health = this.maxhealth;
            }
            this.zivot.Maximum = this.maxhealth;
            this.zivot.Value = this.health;
        }

    }
}