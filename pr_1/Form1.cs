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
            int k = 0;
            for (int i = 0; i < stroka.Length; i++)
            {
                if (stroka[i] == symbol)
                {
                    k += 1;
                }
            }
            return k;
        }
        private int NumberMA(string stroka)
        {
            // Переменная которая хранит кол-во символов
            int ma = 0;
            // Затем переходит при помощи цикла по каждому символу в строке
            for (int i = 0; i < txtStr.Text.Length - 1; i++)
            {
                // Если в строке символ равен М и А значение ma увеличивается на 1
                if (txtStr.Text[i] == 'м' && txtStr.Text[i + 1] == 'а')
                {
                    ma++;
                }
            }
            return ma;
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            string inputText = txtSymb.Text;

            /* Если введено "а", вызывается метод NumberSymbols 
               для подсчета количества символов 'а' в строке txtString.Text*/
            if (inputText == "а")
            {
                // и результат выводится в элемент TextBox txtKolvo
                txtKolvo.Text = NumberSymbols(txtStr.Text, 'а').ToString();
            }
            /* Если введено "ма", вызывается метод NumberMA 
               для подсчета количества подстрок "ма" в строке txtString.Text */
            else if (inputText == "ма")
            {
                // и результат выводится в элемент TextBox txtKolvo
                txtKolvo.Text = NumberMA(txtStr.Text).ToString();
            }
        }
    }
}
