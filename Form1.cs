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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
//1 Задание
        private void посмотретьЗаданиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("№15 Даны три действительные числа. Если все числа положительны," +
                " найти среднее арифметическое, иначе произведение.");
        }

        private void перейтиКЗаданиюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Task1 task1 = new Task1();
            task1.Show();
        }
//2 Задание
        private void посмотретьЗаданиеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("№20 По четырехзначному номеру трамвайного билета определить," +
                " является ли он счастливым (билет считается счастливым, если сумма первых двух цифр номера совпадает с суммой двух его последних цифр).");
        }

        private void перейтиКЗаданиюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Task2 task2 = new Task2();
            task2.Show();
        }
//3 Задание
        private void посмотретьЗаданиеToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("№40 Записать элементов прямоугольной матрицы в одномерный массив в порядке следования столбцов.");
        }

        private void перейтиКЗаданиюToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Task3 task3 = new Task3();
            task3.Show();
        }
//4 Задание
        private void посмотретьЗаданиеToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("№45 Написать программу для определения максимального из трех положительных чисел, введенных пользователем, а также их произведения.");
        }

        private void перейтиКЗаданиюToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Task4 task4 = new Task4();
            task4.Show();
        }
//5 Задание
        private void посмотретьЗаданиеToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("№70 Создать класс Triangle для представления треугольника." +
                " Поля данных должны включать углы и стороны. Требуется реализовать операции:" +
                " получения и изменения полей данных, вычисления площади, вычисления периметра," +
                " вычисления высот, а также определения вида прямо-угольника (равносторонний, равнобедренный или прямоугольный).");
        }

        private void перейтиКЗаданиюToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Task5 task5 = new Task5();
            task5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Green;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }
        Point lastPoint;
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
