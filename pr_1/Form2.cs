using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace pr_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Объявление переменных для минимального значения X, максимального значения X и шага
            double Xmin = double.Parse(txtMin.Text);
            double Xmax = double.Parse(txtMax.Text);
            double Step = double.Parse(txtStep.Text);

            // Вычисление количества шагов по формуле (максимальное значение - минимальное значение) / шаг + 1
            int count = (int)Math.Ceiling((Xmax - Xmin) / Step) + 1;

            // Создание массивов для значений X-общий, y1 (синус) и y2 (косинус).
            double[] X = new double[count];
            double[] y1 = new double[count];
            double[] y2 = new double[count];
            // добавлено для использования в формулах
            double b = 12.6;

            // Цикл для заполнения массивов значениями
            for (int i = 0; i < count; i++)
            {
                // Вычисление каждого значения X, мы устанавливаем значение X[i] в Xmin, увеличивая его на Step с каждой итерацией
                X[i] = Xmin + Step * i;

                // Вычисляем значение функции y1 в точке X. Функция y1(X) = 15.28 * |X|^-1.5 + cos(ln(|X|) + b).
                y1[i] = 15.28 * Math.Pow(Math.Abs(X[i]), -1.5) + Math.Cos(Math.Log(Math.Abs(X[i])) + b);
                //Вычисляем значение функции y2 в точке X.  Функция y2(X) = (X^2 + 2X - 7) / sqrt(X + 100)
                y2[i] = (Math.Pow(X[i], 2) + 2 * X[i] - 7) / Math.Sqrt(X[i] + 100);
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
    }
}
