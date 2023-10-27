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

        private void tmr_Tick(object sender, EventArgs e)
        {
            pct.Left = pct.Left + 20;
            if (pct.Left + pct.Width > this.Width)
            {
                tmr.Stop();
                btnStart.Text = "Старт";
                return;
            }
        }
        private bool animation = false;
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (animation)
            {
                //возвращает изображение в начальное положение
                //(устанавливает значение свойства Left изображения pct в 0 пикселей)
                tmr.Stop();
                btnStart.Text = "Старт";
                animation = false;
            }
            else
            {
                tmr.Start();
                btnStart.Text = "Стоп";
                //Устанавливает значение переменной(выполняется)
                animation = true;
            }
            if (tmr.Enabled)
            {
                pct.Left = 0;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
