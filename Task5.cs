using PR1;
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
    public partial class Task5 : Form
    {
        private Triangle firstTriangle = new Triangle();
        
        public Task5()
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
            double i;
            if (!double.TryParse(textBox1.Text, out i) || (!double.TryParse(textBox2.Text, out i)) || (!double.TryParse(textBox3.Text, out i)))
            {
                MessageBox.Show("Введите число!");
                return;
            }
            else
            {
                firstTriangle.a = Convert.ToDouble(textBox1.Text);
                firstTriangle.b = Convert.ToDouble(textBox2.Text);
                firstTriangle.c = Convert.ToDouble(textBox3.Text);
            }
            if (firstTriangle.IsTriangle())
            {   
                textBox4.Text = firstTriangle.Perimeter().ToString();

                textBox5.Text = firstTriangle.Square().ToString();

                textBox6.Text = firstTriangle.Height_a().ToString();
                textBox11.Text = firstTriangle.Height_b().ToString();
                textBox12.Text = firstTriangle.Height_c().ToString();

                textBox7.Text = firstTriangle.Angle_a().ToString();
                textBox8.Text = firstTriangle.Angle_c().ToString();
                textBox9.Text = firstTriangle.Angle_b().ToString();
                firstTriangle.Compare();
                textBox10.Text = firstTriangle.type.ToString();
            }
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
            MessageBox.Show("№70 Создать класс Triangle для представления треугольника. Поля данных должны включать углы и стороны. " +
                "Требуется реализовать операции: получения и изменения полей данных, вычисления площади, вычисления периметра, вычисления высот, " +
                "а также определения вида прямо-угольника (равносторонний, равнобедренный или прямоугольный).");
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            textBox10.Text = "".ToString();
        }

    }
}
