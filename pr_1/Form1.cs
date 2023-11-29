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

        private int NumberSymbols(string stroka, char symbol)
        {
            // Инициализация переменной для подсчета количества символов в строке.
            int k = 0;
            // Цикл для прохода по каждому символу в строке.
            for (int i = 0; i < stroka.Length; i++)
            {
                // Если символы совпадают, увеличиваем счетчик
                if (stroka[i] == symbol)
                {
                    // Если символы совпадают, увеличиваем счетчик
                    k += 1;
                }
            }
            // Возврат общего количества найденных символов в строке
            return k;
        }
        private int NumberMA(string stroka)
        {
            // Инициализация переменной для подсчета встреч символов "ма" в тексте
            int ma = 0;
            // Цикл для прохода по каждому символу текста, за исключением последнего.
            for (int i = 0; i < txtStr.Text.Length - 1; i++)
            {
                // Проверка, совпадает ли текущий и следующий символы с "м" и "а" соответственно.
                if (txtStr.Text[i] == 'м' && txtStr.Text[i + 1] == 'а')
                {
                    // Увеличение счетчика в случае обнаружения сочетания "ма".
                    ma++;
                }
            }
            // Возврат общего количества встреч символов "ма" в тексте.
            return ma;
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            // Сохранение введенного пользователем текста в переменную inputText.
            string inputText = txtSymb.Text;
            // Проверка, равен ли введенный текст "а".
            if (inputText == "а")
            {
                // Вывод количества символов 'а' в текстовое поле txtKolvo.
                txtKolvo.Text = NumberSymbols(txtStr.Text, 'а').ToString();
            }
            // Проверка, равен ли введенный текст "ма".
            else if (inputText == "ма")
            {
                // Вывод количества вхождений подстроки 'ма' в текстовое поле txtKolvo.
                txtKolvo.Text = NumberMA(txtStr.Text).ToString();
            }
        }
    }
}
