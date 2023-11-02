using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract4
{
    public partial class pract4 : Form
    {
        public pract4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayAB a = new ArrayAB(100);
            FileWrite f = new FileWrite();
            FileRead f2 = new FileRead();
            ShowArray show = new ShowArray();
            string patch = "C:\\Users\\админ\\source\\repos\\практ2\\1.txt";
            string patch1 = "C:\\Users\\админ\\source\\repos\\практ2\\2.txt";
            f2.read(patch, a);
            a.Calc();
            f.write(patch1, a);
            label2.Text = show.showArray(a.a);
            label4.Text = show.showArray(a.b);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
