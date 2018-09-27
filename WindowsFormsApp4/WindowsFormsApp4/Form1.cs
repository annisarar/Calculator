using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private int penjumlahan(int a, int b)
        {
            return a + b;
        }

        private int pengurangan(int a, int b)
        {
            return a - b;
        }

        private int perkalian(int a, int b)
        {
            return a * b;
        }

        private int pembagian(int a, int b)
        {
            return a / b;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            var b = Convert.ToInt32(textBox2.Text);

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    textBox3.Text = Convert.ToString(penjumlahan(a, b));
                    break;

                case 1:
                    textBox3.Text = Convert.ToString(pengurangan(a, b));
                    break;

                case 2:
                    textBox3.Text = Convert.ToString(perkalian(a, b));
                    break;

                case 3:
                    textBox3.Text = Convert.ToString(pembagian(a, b));
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
