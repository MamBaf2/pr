using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pr_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lst.Items.Add(txt1.Text);
            txt1.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fileName = txt2.Text; // пуmь к файлу
            if (File.Exists(fileName))
            {
                File.Delete(fileName); // если файл существуеm - удаляем его
            }
            using (FileStream fs = File.Create(fileName, 1024)) // класс для работы с файлами
                                                                // класс для работы с данными файла в двоичной виде
            using (BinaryWriter bw = new BinaryWriter(fs))
            {
                for (var i = 0; i < lst.Items.Count; i++) // пока не конец списка
                {
                    bw.Write(lst.Items[i].ToString()); // записываем в файл каждый пункт
                }
                bw.Close();
                fs.Close();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
