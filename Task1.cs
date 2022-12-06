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
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {
            double i;
            string a1 = textBox1.Text;
            string a2 = textBox2.Text;
            string a3 = textBox3.Text;

            if ((a1 != "" & a2 != "" & a3 != ""))
            {
                while (!double.TryParse(a1, out i) || (!double.TryParse(a2, out i)) || (!double.TryParse(a3, out i)))
                {
                    MessageBox.Show("Введите число!");
                    return;
                }
                double a1_1 = Convert.ToDouble(a1);
                double a2_1 = Convert.ToDouble(a2);
                double a3_1 = Convert.ToDouble(a3);

                if (a1_1 > 0 & a2_1 > 0 & a3_1 > 0)
                {
                    double b = (a1_1 + a2_1 + a3_1) / 3;
                    textBox4.Text = b.ToString();
                }
                else
                {
                    double c = a1_1 * a2_1 * a3_1;
                    textBox4.Text = c.ToString();
                }
            }
            else
                MessageBox.Show("Введите все числа!");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("№15 Даны три действительные числа. Если все числа положительны, найти среднее арифметическое, иначе произведение.");
        }
    }
}
