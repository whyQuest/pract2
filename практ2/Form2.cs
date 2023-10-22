using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace практ2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            try
            {
                string inputText = textBox1.Text;
                string[] inputValues = inputText.Split(',');

                int[] numbers = inputValues
                    .Select(s => int.Parse(s))
                    .ToArray();

                mass1 massive = new mass1(numbers);

                for(int i = 0; i < massive.Length; i++)
                {
                    dataGridView1.Rows.Add(massive[i].ToString());
                }

                double sol = massive.CalcMs(massive.Getter());

                label3.Text = sol.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
