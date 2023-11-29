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
            //считаем с формы требуемые значения
            double Xmin = double.Parse(txtMin.Text);
            double Xmax = double.Parse(txtMax.Text);
            double Step = double.Parse(txtStep.Text);

            //количество точек графика
            int count = (int)Math.Ceiling((Xmax - Xmin) / Step) + 1;

            //массив значений X - общий для обоих графиков
            double[] X = new double[count];
            double[] y1 = new double[count];
            double[] y2 = new double[count];
            double b = 12.6; // добавлено для использования в формулах

            //рассчитываем точки для графиков функции
            for (int i = 0; i < count; i++)
            {
                //вычисляем значение X
                X[i] = Xmin + Step * i;

                //вычисляем значение функций в точке X
                y1[i] = 15.28 * Math.Pow(Math.Abs(X[i]), 1.5) + Math.Cos(Math.Log(Math.Abs(X[i])) + b);
                y2[i] = (Math.Pow(X[i], 2) + 2 * X[i] - 7) / Math.Sqrt(X[i] + 100);
            }

            //настраиваем оси графика
            chart1.ChartAreas[0].AxisX.Minimum = Xmin;
            chart1.ChartAreas[0].AxisX.Maximum = Xmax;

            //определяем шаг сетки 
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = Step;

            //добавляем вычисленные значения в графики
            chart1.Series[0].Points.DataBindXY(X, y1);
            chart1.Series[1].Points.DataBindXY(X, y2);
        }
    }
}
