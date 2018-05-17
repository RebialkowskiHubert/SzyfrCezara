using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cezar
{
    public partial class Form1 : Form
    {
        Logika l;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            l = new Cezar.Logika();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String tuser = textBox1.Text;
            String tprzes = textBox3.Text;
            int przesuniecie=0;
            bool num=int.TryParse(tprzes, out przesuniecie);

            if(num==true && przesuniecie>0)
            {
            	String szyfr = l.szyfruj(tuser, przesuniecie);
            	textBox5.Text = szyfr;
            }
            else
            	textBox5.Text="Przesunięcie musi być liczbą większą od zera.";
        }
        
		void Button2Click(object sender, EventArgs e)
		{
			String tuser = textBox2.Text;
            String tprzes = textBox4.Text;
            int przesuniecie=0;
            bool num=int.TryParse(tprzes, out przesuniecie);

            if(num==true && przesuniecie>0)
            {
            	String wiadomosc = l.deszyfruj(tuser, przesuniecie);
            	textBox6.Text = wiadomosc;
            }
            else
            	textBox6.Text="Przesunięcie musi być liczbą większą od zera.";
		}
    }
}
