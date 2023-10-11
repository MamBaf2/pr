using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr_2
{
    public partial class Form1 : Form
    {
        Random randomizer = new Random(); // класс рандом для случайных чисел
        int addend1; //переменная сложения
        int addend2;
        int minuend; //переменная вычитания
        int subtrahend;
        int multiplicand; //Переменая умножения
        int multiplier;
        int dividend; //переменая деления
        int divisor;
        int timeLeft; //переменная отсчёта времени
        public Form1()
        {
            InitializeComponent();
        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void plusRightLabel_Click(object sender, EventArgs e)
        {

        }
        public void StartTheQuiz()
        {
            addend1 = randomizer.Next(51); // Генерируем случайное число от 0 до 50 и присваиваем его переменной
            addend2 = randomizer.Next(51);
            plusLeftLabel.Text = addend1.ToString(); // Преобразуем значение addend1 в строку и устанавливаем его в качестве текста для plusLeftLabel
            plusRightLabel.Text = addend2.ToString();
            sum.Value = 0; // Устанавливаем значение sum равным 0
            minuend = randomizer.Next(1, 101); // Генерируем случайное число от 1 до 100 и присваиваем его переменной minuend
            subtrahend = randomizer.Next(1, minuend); // Генерируем случайное число от 1 до minuend и присваиваем его переменной subtrahend
            minusLeftLabel.Text = minuend.ToString(); // Преобразуем значение minuend в строку и устанавливаем его в качестве текста для minusLeftLabel
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;
            multiplicand = randomizer.Next(2, 11); // Генерируем случайное число от 2 до 10 и присваиваем его переменной multiplicand
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient; // Умножаем divisor на temporaryQuotient и присваиваем результат переменной dividend
            dividedLeftLabel.Text = dividend.ToString(); // Преобразуем значение dividend в строку и устанавливаем его в качестве текста для dividedLeftLabel
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();

        }
        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value) // Проверяет, является ли сумма addend1 и addend2 равной значению sum.Value,
                && (minuend - subtrahend == difference.Value) // разность minuend и subtrahend равна значению difference.Value,
                && (multiplicand * multiplier == product.Value) // произведение multiplicand и multiplier равно значению product.Value
                && (dividend / divisor == quotient.Value)) // и частное dividend и divisor равно значению quotient.Value
                return true;
            else // Возвращает true, если все условия выполняются, иначе возвращает false
                return false;
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false; // Отключение кнопки "Старт"
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer()) // Проверка ответа пользователя
            {
                timer1.Stop();
                MessageBox.Show("давай краба у тебя всё верно!", "Красаучег");
                startButton.Enabled = true; // Включение кнопки "Старт"
            }
            else if (timeLeft > 0) // Проверка, осталось ли время
            {
                timeLeft = timeLeft - 1; // Уменьшение времени на 1 секунду
                timeLabel.Text = timeLeft + " seconds"; // Обновление текста на метке времени
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Time's up";
                MessageBox.Show("пробуй ещё раз!", "Сори ты нуб");
                sum.Value = addend1 + addend2; // Обновление значения суммы
                difference.Value = minuend - subtrahend; // Обновление значения разницы
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
            }
            if (timeLeft <= 5)
            {
                timeLabel.BackColor = Color.Red;
            }
           
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown; // Эта строка кода приводит объект "sender" к типу NumericUpDown и присваивает его переменной "answerBox".
            if (answerBox != null) // Эта строка кода приводит объект "sender" к типу NumericUpDown и присваивает его переменной "answerBox".
            {
                int lenghtOfAnswer = answerBox.Value.ToString().Length; // Эта строка кода вычисляет длину значения в контроле "answerBox" и присваивает ее переменной "lengthOfAnswer"
                answerBox.Select (0, lenghtOfAnswer); // Эта строка кода выбирает всё значение в контроле "answerBox", указывая начальный индекс 0 и длину "lengthOfAnswer"
            }
        }

        private void diff_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;
            if (answerBox != null)
            {
                int lenghtOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lenghtOfAnswer);
            }
        }

        private void prod_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;
            if (answerBox != null)
            {
                int lenghtOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lenghtOfAnswer);
            }
        }

        private void quotient_Enter(object sender, EventArgs e)
        {

        }

        private void quoti_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;
            if (answerBox != null)
            {
                int lenghtOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lenghtOfAnswer);
            }// Звуковой сигнал в сделку не входил(
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
