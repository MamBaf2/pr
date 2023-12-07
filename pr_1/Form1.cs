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

            int count;

            if (Step > 0)
            {
                count = (int)Math.Ceiling((Xmax - Xmin) / Step) + 1;
            }
            else if (Step < 0)
            {
                count = (int)Math.Ceiling((Xmin - Xmax) / Math.Abs(Step)) + 1;
                double temp = Xmax;
                Xmax = Xmin;
                Xmin = temp;
            }
            else
            {
                // Обработка случая, когда Step = 0, если это нужно
                return;
            }
            Step = Math.Abs(Step);

            double[] X = new double[count];
            double[] y1 = new double[count];
            double[] y2 = new double[count];
            double b = 12.6;

            for (int i = 0; i < count; i++)
            {
                X[i] = Xmin + Step * i;

                y1[i] = 15.28 * Math.Pow(Math.Abs(X[i]), -1.5) + Math.Cos(Math.Log(Math.Abs(X[i])) + b);
                y2[i] = (Math.Pow(X[i], 2) + 2 * X[i] - 7) / Math.Sqrt(X[i] + 100);
            }

            chart1.ChartAreas[0].AxisX.Minimum = Xmin;
            chart1.ChartAreas[0].AxisX.Maximum = Xmax;
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = Step;
            chart1.Series[0].Points.DataBindXY(X, y1);
            chart1.Series[1].Points.DataBindXY(X, y2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
