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
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
            // Инициализация объекта SaveFileDialog для сохранения файлов
            file2 = new SaveFileDialog();
            // Задание фильтра файлов для SaveFileDialog
            file2.Filter = "(*.jpg)|*.jpg";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Задаем фильтр для OpenFileDialog
            file1.Filter = "(*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            // создаем переменную fname строкового типа
            string fname;
            //открываем проводник
            file1.ShowDialog();
            //используем переменную для хранения имени выбранного файла
            fname = file1.FileName;
            // Загружаем изображение в PictureBox
            pct.Image = Image.FromFile(fname);
            //Вывод имени файла
            lblName.Text = fname;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Вызываем ShowDialog для SaveFileDialog
            if (file2.ShowDialog() == DialogResult.OK)
            {
                // Сохраняем изображение в выбранном пользователем файле
                pct.Image.Save(file2.FileName);
            }
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); // Создание экземпляра Form2
            form2.Show(); // Открыть Form2
        }
    }
}
