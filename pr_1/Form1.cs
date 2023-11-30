using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Объявление переменных для минимального значения X, максимального значения X и шага
            double Xmin = double.Parse(txtMin.Text);
            double Xmax = double.Parse(txtMax.Text);
            double Step = double.Parse(txtStep.Text);
            // Вычисление количества шагов по формуле (максимальное значение - минимальное значение) / шаг + 1.
            int count = (int)Math.Ceiling((Xmax - Xmin) / Step)
                + 1;
            // Создание массивов для значений X-общий, y1 (синус) и y2 (косинус).
            double[] X = new double[count];
            double[] y1 = new double[count];
            double[] y2 = new double[count];
            // Цикл для заполнения массивов значениями
            for (int i = 0; i < count; i++)
            {
               // Вычисление каждого значения X в соответствии с шагом.
                X[i] = Xmin + Step * i;
                // Заполнение массивов значениями синуса и косинуса для соответствующих X.
                y1[i] = Math.Sin(X[i]);
                y2[i] = Math.Cos(X[i]);
            }
            // Устанавливаем минимальное значение по оси X для первой области диаграммы
            chart1.ChartAreas[0].AxisX.Minimum = Xmin;
            // Устанавливаем максимальное значение по оси X для первой области диаграммы
            chart1.ChartAreas[0].AxisX.Maximum = Xmax;
            // Устанавливаем интервал основной сетки по оси X для первой области диаграммы
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = Step;
            // Привязываем данные массива X и y1 к первой серии диаграммы
            chart1.Series[0].Points.DataBindXY(X, y1);
            // Привязываем данные массива X и y2 ко второй серии диаграммы
            chart1.Series[1].Points.DataBindXY(X, y2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
