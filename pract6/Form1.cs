using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double t = Convert.ToDouble(textBox1.Text);
            Bazarov ivan = new Bazarov(t);
            Fedusenko olena = new Fedusenko(t);
            Lisnevsky rostyslave = new Lisnevsky(t);
            Kuchansky alex = new Kuchansky(t);
            Zayava zayava = new Zayava();

            zayava.help += new Zayavlenie(ivan.Bazarov_Massage);
            zayava.help += new Zayavlenie(olena.Fedusenko_Message);
            zayava.help += new Zayavlenie(rostyslave.lisnevsky_Message);
            zayava.help += new Zayavlenie(alex.Kuchansky_Message);
            zayava.helping(t);
            MessageBox.Show("Доля Базарова вирішена");
        }
    }
}
