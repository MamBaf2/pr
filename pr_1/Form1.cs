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
            //Инициализация компонентов на форме
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //отключение таймера
            tmrSecundomer.Enabled = false;
            // Получите текущее время
            DateTime currentTime = DateTime.Now;

            // Отобразите текущее время в текстовом поле
            Date.Text = currentTime.ToString();
        }

        private void tmrSecundomer_Tick(object sender, EventArgs e)
        {
            // Получить текущее значение секунд из текстового поля
            int seconds = Int32.Parse(txtSeconds.Text);
            // Получить текущее значение минут из текстового поля
            int minutes = Int32.Parse(txtMinutes.Text);
            // Увеличить значение секунд на 1
            seconds += 1;
            // Проверить, если значение секунд достигло 60 (одной минуты)
            if (seconds >= 60)
            {
                // Сбросить секунды на 0
                seconds = 0;
                // Увеличить значение минут на 1
                minutes += 1;
            }
            // Обновить текстовое поле секунд новым значением
            txtSeconds.Text = seconds.ToString();
            // Обновить текстовое поле минут новым значением
            txtMinutes.Text = minutes.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Переключаем состояние таймера при нажатии на кнопку
            tmrSecundomer.Enabled = !tmrSecundomer.Enabled;

            // Изменяем надпись на кнопке в зависимости от состояния таймера
            if (tmrSecundomer.Enabled)
            {
                btnStart.Text = "Остановить";
            }
            else
            {
                btnStart.Text = "Запустить";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Установите значения секунд и минут в 0
            txtSeconds.Text = "0";
            txtMinutes.Text = "0";
        }

        private void Date_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
