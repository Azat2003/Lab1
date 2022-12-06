using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR1
{
    public partial class Task4 : Form
    {
        public Task4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;
            string c = textBox3.Text;
            int i;
            if ((a != "" & b != "" & c != ""))
            {

                while (!int.TryParse(a, out i) || (!int.TryParse(b, out i)) || (!int.TryParse(c, out i)))
                {
                    MessageBox.Show("Введите число!");
                    return;
                }
                int a_1 = Convert.ToInt32(a);
                int b_1 = Convert.ToInt32(b);
                int c_1 = Convert.ToInt32(c);
                if (a_1 < 0 || b_1 < 0 || c_1 < 0)
                {
                    MessageBox.Show("Введите положительное число!");
                    textBox4.Text = null;
                    textBox5.Text = null;
                    return;
                }


                if (a_1 > b_1 & a_1 > c_1)
                {
                    textBox4.Text = a_1.ToString();
                }
                else if (b_1 > a_1 & b_1 > c_1)
                    textBox4.Text = b_1.ToString();
                else
                    textBox4.Text = c_1.ToString();
                int abc = a_1 * b_1 * c_1;
                textBox5.Text = abc.ToString();
            }
            else
                MessageBox.Show("Введите все числа!");
        }

        Point lastPoint;
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("№45 Написать программу для определения максимального из трех положительных чисел," +
                " введенных пользователем, а также их произведения.");
        }
    }
}
