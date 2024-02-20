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
    public partial class Form3 : Form
    {
        private Timer timer;
        private int rocketY;
        private const int rocketX = 200; // Фиксированное положение по оси X
        private const int rocketWidth = 40;
        private const int rocketHeight = 80;
        private const int launchSpeed = 5;
        private bool isFlying = false; // Флаг для контроля старта полета
        public Form3()
        {
            InitializeComponent();
            InitializeRocket();
            InitializeTimer();
        }
        private void InitializeRocket()
        {
            rocketY = ClientSize.Height - rocketHeight;
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 20; // Интервал в миллисекундах
            timer.Tick += tmr_Tick;
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            if (isFlying) // Проверяем, активен ли полет
            {
                rocketY -= launchSpeed; // Движение вверх
                if (rocketY <= 0)
                {
                    timer.Stop(); // Останавливаем таймер, если достигнута верхняя граница формы
                }
                Invalidate();
            }
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            DrawRocket(g);
        }
        private void DrawRocket(Graphics g)
        {
            // Рисуем корпус ракеты
            Rectangle rocketRect = new Rectangle(rocketX, rocketY, rocketWidth, rocketHeight);
            g.FillRectangle(Brushes.Gray, rocketRect);

            // Рисуем огонь (оранжевые линии)
            int flameWidth = rocketWidth / 2;
            int flameHeight = rocketWidth * 2;
            Rectangle flameRect = new Rectangle(rocketX + rocketWidth / 4, rocketY + rocketHeight, flameWidth, flameHeight);
            g.FillRectangle(Brushes.Orange, flameRect);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rocketY = ClientSize.Height; // Сброс позиции ракеты
            isFlying = true; // Активируем полет
            timer.Start(); // Запускаем таймер
        }
    }
}
