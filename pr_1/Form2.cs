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
            int count;

            if (Step > 0)
            {
                // Если шаг (Step) положителен, вычисляем количество шагов между Xmin и Xmax
                count = (int)Math.Ceiling((Xmax - Xmin) / Step) + 1;
            }
            else if (Step < 0)
            {
                // Если шаг (Step) отрицателен, меняем местами Xmin и Xmax и вычисляем количество шагов
                count = (int)Math.Ceiling((Xmin - Xmax) / Math.Abs(Step)) + 1;
                double temp = Xmax;
                Xmax = Xmin;
                Xmin = temp;
            }
            else
            {
                // Если шаг равен 0, возвращаемся из метода
                return;
            }
            // Приводим шаг к положительному значению для дальнейших вычислений
            Step = Math.Abs(Step);
            // Создание массивов для значений X, y1 и y2
            double[] X = new double[count];
            double[] y1 = new double[count];
            double[] y2 = new double[count];
            double b = 12.6;
            // Цикл,  от 0 до  count (количество шагов), увеличивая значение i на каждой итерации. 
            for (int i = 0; i < count; i++)
            {
                // Изменение логики заполнения массива X при отрицательном шаге
                if (Step > 0)
                {
                    // Если шаг (Step) положителен, заполняем массив по возрастанию от Xmin с увеличением на Step с каждой итерацией
                    X[i] = Xmin + Step * i;
                }
                else if (Step < 0)
                {
                    // Если шаг (Step) отрицателен, заполняем массив по убыванию от Xmax с уменьшением на Step с каждой итерацией
                    X[i] = Xmax + Step * i;
                }
                // Вычисление значений функций y1 и y2 в зависимости от значений X. Функция y1(X) = 15.28 * |X|^-1.5 + cos(ln(|X|) + b).
                y1[i] = 15.28 * Math.Pow(Math.Abs(X[i]), -1.5) + Math.Cos(Math.Log(Math.Abs(X[i])) + b);
                //Функция y2(X) = (X ^ 2 + 2X - 7) / sqrt(X + 100)
                y2[i] = (Math.Pow(X[i], 2) + 2 * X[i] - 7) / Math.Sqrt(X[i] + 100);
            }

            // Устанавливаем минимальное значение по оси X для первой области диаграммы
            chart1.ChartAreas[0].AxisX.Minimum = Xmin < Xmax ? Xmin : Xmax;
            // Устанавливаем максимальное значение по оси X для первой области диаграммы
            chart1.ChartAreas[0].AxisX.Maximum = Xmin > Xmax ? Xmin : Xmax;
            // Устанавливаем интервал основной сетки по оси X для первой области диаграммы
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = Step;
            // Привязываем данные массива X и y1 к первой серии диаграммы
            chart1.Series[0].Points.DataBindXY(X, y1);
            // Привязываем данные массива X и y2 ко второй серии диаграммы
            chart1.Series[1].Points.DataBindXY(X, y2);
        }
    }
}
