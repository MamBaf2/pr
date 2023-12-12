using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // Цвета
            Color yellow = Color.Yellow;
            Color purple = Color.Purple;
            Color black = Color.Black;

            // Перья для различных стилей линий
            Pen solidPen = new Pen(black, 2);
            Pen dashedPen = new Pen(yellow, 8) { DashStyle = DashStyle.Dash };
            Pen dottedPen = new Pen(purple, 4) { DashStyle = DashStyle.Dot };

            // Заливка
            SolidBrush solidBrush = new SolidBrush(purple);

            // Рисуем линии различных стилей
            g.DrawLine(solidPen, 70, 30, 200,30);
            g.DrawLine(dashedPen, 70, 20, 200, 20);
            g.DrawLine(dottedPen, 70, 80, 200, 80);

            // Рисуем круг
            g.DrawEllipse(solidPen, 50, 120, 100, 100);
            g.FillEllipse(solidBrush, 450, 30, 100, 100);

            // Рисуем прямоугольники
            g.DrawRectangle(solidPen, 400, 140, 160, 80);
            g.FillRectangle(solidBrush, 400, 250, 160, 80);
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
