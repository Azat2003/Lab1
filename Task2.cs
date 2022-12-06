using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PR1
{
    public partial class Task2 : Form
    {
        public Task2()
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
            string abcd = textBox1.Text;
            int i;

            if (abcd != "" & abcd.Length == 4 )
            {
                if (abcd != "0000")
                {
                    while (!int.TryParse(abcd, out i))
                    {
                        MessageBox.Show("Введите число!");
                        return;
                    }
                    int abcd_1 = Convert.ToInt32(abcd);
                    int sum1 = (abcd_1 % 10 + (abcd_1 / 10) % 10);
                    int sum2 = ((abcd_1 / 100) % 10 + (abcd_1 / 1000) % 10);
                    if (sum1 == sum2)
                    {   
                        pictureBox1.Image = Image.FromFile("C:\\Users\\chc20\\source\\repos\\PR1\\images\\6872344b_resizedScaled_1020to574.jpg");
                        MessageBox.Show("Вы обладатель счастливого билета!!!");
                    }
                    else
                    {
                        MessageBox.Show("Увы, может повезет в другой раз(");
                    }
                }
                else MessageBox.Show("Такого билета не существует!");
            }
            else
                MessageBox.Show("Введите четырехзначное число!");
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
            MessageBox.Show("№20 По четырехзначному номеру трамвайного билета определить, " +
                "является ли он счастливым (билет считается счастливым, " +
                "если сумма первых двух цифр номера совпадает с суммой двух его последних цифр).");
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\chc20\\source\\repos\\PR1\\images\\кондукторы.jpg");
        }
    }
}
