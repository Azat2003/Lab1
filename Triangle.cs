using PR1;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PR1
{
    enum Triangle_Type
    {
        Прямоугольный,
        Равносторонний,
        Равнобедренный,
        ne
    }
    internal class Triangle
    {
        public double a;
        public double A 
        {
            get { return a; }
            set { a = value;  }
        }
        public double b;
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public double c;
        public double C
        {
            get { return c; }
            set { c = value; }
        }
        public bool IsTriangle()
        {
            if (a >= b + c || b >= a + c || c >= a + b)
            {
                MessageBox.Show("Tакого треугольника не существует!");
                return false;
            }
            return true;
        }
        //Вычисляем периметр
        public double Perimeter()
        {
            return (a + b + c);
        }
        //Вычисляем площадь
        public double Square()
        {
            return Math.Sqrt(Perimeter()/2 * (Perimeter() / 2 - a) * (Perimeter() / 2 - b) * (Perimeter() / 2 - c));
        }
        //Вычисляем высоты
        public double Height_a()
        {
            return (2 * Square()) / a;
        }
        public double Height_b()
        {
            return (2 * Square()) / b;
        }
        public double Height_c()
        {
            return (2 * Square()) / c;
        }
        //Вычисляем косинусы
        public double Cos_a()
        {
            return (Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c);
        }
        public double Cos_b()
        {
            return (Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) / (2 * a * b);
        }
        public double Cos_c()
        {
            return (Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c);
        }
        //Вычисляем углы
        public double Angle_a()
        {
            return Math.Acos(Cos_a()) * 180 / Math.PI;
        }
        public double Angle_b()
        {
            return Math.Acos(Cos_b()) * 180 / Math.PI;
        }
        public double Angle_c()
        {
            return Math.Acos(Cos_c()) * 180 / Math.PI;
        }

        public Triangle_Type type;
        //определения вида
        public void Compare()
        {
            if (Angle_a() == 90.0 || Angle_b() == 90.0 || Angle_c() == 90.0)
                type = Triangle_Type.Прямоугольный;
            if (a == b && b == c)
                type = Triangle_Type.Равносторонний;
            if ((a == b & b != c) || (a == c & b != c) || (c == b & b != a))
                type = Triangle_Type.Равнобедренный;
        }
    }
}

