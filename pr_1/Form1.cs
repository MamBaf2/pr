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
    public partial class Lab7 : Form
    {
        public Lab7()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //кнопка "Вычислить".
        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Объявляем две переменные x и precision для ввода пользовательских значений.
            double x, precision;
            // Проверяем, успешно ли удалось преобразовать текст из txtX и txtPrecision в числа типа double.
            if (double.TryParse(txtX.Text, out x) && double.TryParse(txtPrecision.Text, out precision))
            {
                /* Объявляем несколько переменных для вычислений:
                 sum - сумма, начальное значение 0.
                 slog - текущее слагаемое, начальное значение равно x.
                 addslog - счетчик количества слагаемых, начальное значение 1.
                 f - флаг для отслеживания успешности вычислений.*/
                double sum = 0;
                double slog = x;
                int addslog = 1;
                bool f = false;
                // Начинаем цикл, который будет выполняться, пока текущее слагаемое по модулю больше или равно заданной точности.
                while (Math.Abs(slog) >= precision)
                {
                    // Добавляем текущее слагаемое к сумме.
                    sum += slog;
                    // Увеличиваем счетчик слагаемых.
                    addslog++;
                    // Вычисляем следующее слагаемое как x, деленное на addslog.
                    slog = x / addslog;
                }
                // Выводим сумму в элемент управления lblResult.
                lblResult.Text = "sum = " + sum.ToString();
                // Выводим количество слагаемых в элемент управления lblQuantity.
                lblQuantity.Text = "quantity = " + addslog.ToString();
                // Устанавливаем флаг f в true, чтобы показать, что вычисления успешно завершились.
                f = true;
            }
            else
            {
                // Если пользователь ввел некорректные значения (например, не числа), выводим сообщение об ошибке.
                MessageBox.Show("Введите числовое значение");
            }
        }
    }
}
