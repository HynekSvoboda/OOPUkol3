using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPUkol3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            button2.Visible= false;
            button3.Visible= false;
            button6.Visible= false;
        }
        Auto auto;

        private void button1_Click(object sender, EventArgs e)
        {
            auto = new Auto(textBox1.Text, (double)numericUpDown1.Value);
            button2.Visible = true;
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            auto.Rozjed();
            button3.Visible = true;
            button2.Visible=false;
            button6.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            auto.Zastav((int)numericUpDown2.Value);
            button2.Visible = true;
            button3.Visible=false;
        }
        private void button6_Click(object sender, EventArgs e)
        {
           label1.Text= auto.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vytvořte třídu Auto, která bude obsahovat:\r\n\r\nSoukromý atribut znacka (Škoda Scala, Renault Megane, Ford Mondeo,…)\r\nSoukromý atribut spotreba na 100 km\r\nSoukromý atribut ujetoCelkem – celková ujetá vzdálenost během všech jednotlivých jízd (km)\r\nSoukromý atribut okamzikRozjezdu – čas rozjezdu\r\nSoukromý atribut dobaJizdyCelkem – celková doba všech jednotlivých jízd\r\nVlastnost Jede pouze pro čtení – uchovává informaci, zda auto jede či ne\r\n\r\n\r\nTřída bude mít jediný konstruktor, bude nastavovat značku a spotřebu na 100 km, celkovou ujetou vzdálenost a celkovou dobu jízdy nastaví na nulu a vlastnost Jede na hodnotu false.\r\n\r\n\r\nTřída bude mít následující metody:\r\nVratUjeteKm – která vrací celkové kilometry během všech jízd\r\nRozjed – rozjede auto a uloží čas rozjezdu.\r\nZastav – auto zastaví, zvýší celkovou ujetou vzdálenost o kilometry zadané jako parametr metody a zaktualizuje atribut dobaJizdyCelkem\r\nCelkovaSpotreba – vypočte spotřebované palivo za celou dobu jízdy, metoda nebere zřetel na to, zda auto jede čí stojí.\r\nPřepsanou metodu ToString – vrátí víceřádkový text se všemi údaji, včetně stavu auta (informace zda jede, či stojí)\r\n\r\nVytvořte instanci třídy Auto a vyzkoušejte v programu.");
        }
    }
}
