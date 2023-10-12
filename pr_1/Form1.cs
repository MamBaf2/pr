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

        private void showButton_Click(object sender, EventArgs e)
        {
            //Отобразить диалоговое окно открытия файла. Если пользователь нажмет "ОК", загрузите
            //изображение, которое выбрал пользователь.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //очистите изображение
            pictureBox1.Image = null;
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            // Если пользователь выбрал цвет в диалоговом окне,
            // то устанавливаем этот цвет в качестве фона pictureBox1.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //Закрыть форму
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Если флажок checkBox1 не отмечен, то изменить свойство SizeMode объекта pictureBox1 на значение "Стретч"
            if (!checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            // В противном случае, установить свойство SizeMode объекта pictureBox1 на значение "Обычный"
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
