using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract5
{
    public partial class Form1 : System.Windows.Forms.Form
    {

        People people = new People();
        string path = "data.txt";
        public void Show(DataGridView dg)
        {
            dg.Rows.Clear();
            foreach (Bagazh p in people.people)
            {
                dg.Rows.Add(p.PIIB, p.Count, p.Weight);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                var person = new Bagazh(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
                people.people.Add(person);
                dataGridView2.Rows.Add(people.people[people.people.Count - 1].PIIB,
                    people.people[people.people.Count - 1].Count,
                    people.people[people.people.Count - 1].Weight);
            }
            catch (Exception)
            {
                throw new Exception("Помилка у вхідних данних!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            people.people.Sort();
            dataGridView1.Rows.Clear();
            foreach (Bagazh p in people.people)
            {
                if (p.Weight > Convert.ToInt32(textBox4.Text))
                {
                    dataGridView1.Rows.Add(p.PIIB, p.Count, p.Weight);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            people.WriteFile(path);
            MessageBox.Show("Дані записані!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            people.ReadFile(path);
            Show(dataGridView2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var i = dataGridView2.CurrentRow.Index;
            people.Remove(i);
            Show(dataGridView2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            people.Sort();
            Show(dataGridView3);
        }
    }
}
