using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inform2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Form2 main = Owner as Form2;
            for (int i = 0; i < main.dataGridView1.Rows.Count; i++)
            {
                comboBox1.Items.Add(main.dataGridView1[2, i].Value.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        public static void Find(DataGridView dataGridView1,string text)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Visible = true;
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1[2, i].Value.ToString()!=text)
                {
                    dataGridView1.Rows[i].Visible = false;
                }
            }
        }
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Form2 main = Owner as Form2;
            Find(main.dataGridView1, comboBox1.Text);
        }
    }
}
