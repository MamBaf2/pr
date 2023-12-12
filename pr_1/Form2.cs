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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            //создание объекта graphics
            Graphics g = e.Graphics;
            //Создание пера для рисования линий
            Pen blackPen = new Pen(Color.Black, 2);
            //Создание переменных для объектов заливки
            SolidBrush solidBrown = new SolidBrush(Color.Brown);
            SolidBrush solidGreen = new SolidBrush(Color.Green);
            SolidBrush solidBlack = new SolidBrush(Color.Black);
            SolidBrush solidRed = new SolidBrush(Color.Red);
            SolidBrush solidBlue = new SolidBrush(Color.Blue);
            SolidBrush solidYellow = new SolidBrush(Color.Yellow);
            // Рисуем корпус машины
            g.FillRectangle(solidRed, 100, 200, 200, 50);

            // Рисуем верхнюю часть машины пером
            Point[] roofPoints =
            {
                 new Point(100, 200),
                 new Point(150, 150),
                 new Point(220, 150),
                 new Point(300, 200)
            };
            g.DrawLines(blackPen, roofPoints);

            // Рисуем окна
            g.FillRectangle(solidBlue, 147, 151, 40, 49);
            g.FillRectangle(solidBlue, 185, 151, 35, 49);

            // Рисуем колеса
            g.FillEllipse(solidBlack, 120, 250, 50, 50);
            g.FillEllipse(solidBlack, 230, 250, 50, 50);
            g.FillEllipse(solidYellow, 500, 30, 70, 50);

            //Рисуем верхнюю и нижнюю часть дороги
            g.DrawLine(blackPen, 0, 250, 800, 250);
            g.DrawLine(blackPen, 0, 310, 800, 310);

            //цикл для заполнения деревьев
            for (int i = 0; i < 10; i++)
            {
                // Рисуем ствол дерева
                g.FillRectangle(solidBrown, 20+i*80, 350, 20, 80);
                // Рисуем листву дерева
                g.FillEllipse(solidGreen, 0+i*80, 300, 60, 60);
            }
        }
    }
}
