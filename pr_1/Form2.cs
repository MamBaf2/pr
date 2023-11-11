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
        //кнопка открытия файлОЧКА
        private void button3_Click(object sender, EventArgs e)
        {
            // Получаем путь к файлу из текстового поля
            string fileName = txt1.Text;
            // Очищаем элемент управления ListBox перед открытием нового файла
            lstFromFile.Items.Clear();
            /* Используем конструкцию using для создания FileStream и BinaryReader
            и обеспечиваем автоматическое закрытие ресурсов (файлового потока и бинарного читателя),
            когда они больше не нужны, чтобы избежать утечек ресурсов. 
            Создаем FileStream для открытия файла с заданным именем в режиме FileMode.Open (для чтения).
            FileStream - класс для работы с потоком байтов в файле.
            Он также используется в конструкции using, что гарантирует его закрытие после использования. */
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            /* Создаем BinaryReader для чтения данных из FileStream.
            BinaryReader - обертка вокруг потока, предоставляющая методы чтения примитивных типов данных из бинарного потока.
            Также используется в конструкции using для автоматического закрытия после использования. */
            using (BinaryReader br = new BinaryReader(fs))
            {
                /* Начинаем цикл, который будет выполняться до тех пор, пока не достигнут конец файла.
                Метод PeekChar() возвращает следующий символ без перемещения указателя текущей позиции в файле. */
                while (br.PeekChar() != -1)
                {
                    // Добавляем в элемент управления ListBox каждую строку, прочитанную с использованием BinaryReader.
                    lstFromFile.Items.Add(br.ReadString());
                }
                // Закрываем BinaryReader и FileStream
                br.Close();
                fs.Close();
            }
        }
        //кнопка добавить
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Добавляем текст из текстового поля в элемент управления ListBox и очищаем текстовое поле
            lst.Items.Add(txt2.Text);
            txt2.Clear();
        }
        //кнопка сохранить
        private void btnSave_Click(object sender, EventArgs e)
        {
            // пуmь к файлу из текстового поля
            string fileName = txt1.Text;
            // если файл существуеm - удаляем его
            if (File.Exists(fileName))
            {
                File.Delete(fileName); 
            }
            // Используем конструкцию using для автоматического закрытия FileStream и BinaryWriter после использования
            // создаем файл или перезаписываем существующий
            using (FileStream fs = File.Create(fileName, 1024))
            // класс для работы с данными файла в двоичной виде
            using (BinaryWriter bw = new BinaryWriter(fs))
            {
                // пока не конец списка Записываем каждый элемент из элемента управления ListBox в файл
                for (var i = 0; i < lst.Items.Count; i++)
                {
                    bw.Write(lst.Items[i].ToString());
                }
                // Закрываем BinaryWriter и FileStream
                bw.Close();
                fs.Close();
            }
        }
        //кнопка выходи
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Закрываем текущую форму
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
