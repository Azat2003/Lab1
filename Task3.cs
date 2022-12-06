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
    public partial class Task3 : Form
    {
        public Task3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count > numericUpDown1.Value)
                dataGridView1.Columns.RemoveAt(Convert.ToInt32(numericUpDown1.Value));
            else
                dataGridView1.Columns.Add($"Column{numericUpDown1.Value}", $"Столбец {numericUpDown1.Value}");
        }
        private void numericUpDown2_ValueChanged_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > numericUpDown2.Value)
                dataGridView1.Rows.RemoveAt(Convert.ToInt32(numericUpDown2.Value));
            else if (dataGridView1.Columns.Count > 0)
                dataGridView1.Rows.Add();
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
            int[,] array;
            array = new int[dataGridView1.Rows.Count, dataGridView1.Columns.Count];
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (int.TryParse(dataGridView1.Rows[i].Cells[j].Value.ToString(), out int i1))
                            array[i, j] = int.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString());
                        else
                        {
                            MessageBox.Show("Введите числа!");
                            return;
                        }
                    else
                    {
                        MessageBox.Show("Введите числа!");
                        return;
                    }
                }
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                        textBox1.Text += $" {array[j, i]}";
                }
            }
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("№40 Записать элементов прямоугольной матрицы в одномерный массив в порядке следования столбцов.");
        }
    }
}
