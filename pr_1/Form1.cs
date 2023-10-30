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
        //пустая форма никому не нужная
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Присваиваем переменной animation значение false
        private bool animation = false;
        //timer
        private void tmr_Tick(object sender, EventArgs e)
        {
            // Увеличиваем позицию изображения на 20 пикселей вправо
            pct.Left = pct.Left + 20;
            // Проверяем, достигло ли изображение правого края формы.
            if (pct.Left + pct.Width > this.Width)
            {
                // Если достигло, останавливаем таймер.
                tmr.Stop();
                // Меняем текст кнопки на "Старт".
                btnStart.Text = "Старт";
                // Выходим из этого метода.
                return;
            }
        }
        //кнопка старт/стоп
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (animation)
            {
                // Если анимация выполняется, останавливаем таймер и меняем текст кнопки на "Старт"
                tmr.Stop();
                btnStart.Text = "Старт";
                // Устанавливаем значение анимации в false
                animation = false;
            }
            // Если изображение достигло правого края, возвращаем его в начальную позицию
            else if (pct.Left + pct.Width > this.Width)
            {
                pct.Left = 0;
                // Устанавливаем значение анимации в false
                animation = false;
            }
            else
            {
                /* Если анимация не выполняется и изображение не на правом краю,
                запускаем таймер, меняем текст кнопки на "Стоп" и устанавливаем значение анимации в true*/
                tmr.Start();
                btnStart.Text = "Стоп";
                animation = true;
                tmr.Interval = 50;
            }
        
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Закрытие формы
            this.Close();
        }
    }
}
