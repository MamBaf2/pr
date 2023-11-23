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
    public partial class Form2 : Form
    {
        public Form2()
        {
            // Инициализация компонентов формы
            InitializeComponent();
        }
        // Объявление и инициализация массива Arr размером 10.
        private int[] Arr = new int[10];
        //кнопка новый массив
        private void btnNewArr_Click(object sender, EventArgs e)
        {
            // Определение переменной n, которая указывает на количество элементов массива.
            int n = 10;
            // Преобразует текст из поля txtMin в целое число и сохраняет в переменную a.
            int a = int.Parse(txtMin.Text);
            // Преобразует текст из поля txtMax в целое число и сохраняет в переменную b.
            int b = int.Parse(txtMax.Text);

            if (a > b)
            {
                MessageBox.Show("Нижняя граница должна быть меньше или равна верхней границе.");
                return;
            }
            // Создает класс Random для генерации случайных чисел.
            Random r = new Random();

            //i = 0, условие, i+1
            for (int i = 0; i < n; i++)
            {
                // Заполняет массив случайными числами в заданном диапазоне.
                Arr[i] = r.Next(a, b);
                // Добавляет значение элемента массива в текстовое поле lblArr.
                lblArr.Text += Arr[i];
                // Добавляет запятую, если текущий элемент не последний
                if (i != n) lblArr.Text += ", ";
            }
            // Включение кнопки сортировки
            btnSort.Enabled = true;
            // Вызов метода InsertionSort для сортировки массива Arr.
            InsertionSort(Arr);
        }
        private void InsertionSort(int[] Arr)
        {
            // Начало цикла для прохода по элементам массива, начиная со второго элемента.
            for (int i = 1; i < Arr.Length; i++)
            {
                // Сохранение значения текущего элемента массива.
                int key = Arr[i];
                // Задание индекса предыдущего элемента.
                int j = i - 1;

                // Цикл для сдвига элементов массива вправо, пока выполняется условие и ключ меньше предыдущего элемента.
                while (j >= 0 && Arr[j] > key)
                {
                    // Сдвиг элемента вправо.
                    Arr[j + 1] = Arr[j];
                    // Уменьшение индекса для проверки предыдущего элемента.
                    j--;
                }

                // Помещение сохраненного значения в правильное положение.
                Arr[j + 1] = key;
            }
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            // Устанавливает в текстовое поле содержимое массива, разделенное запятой.
            lblResult.Text = string.Join(", ", Arr);
            // Отключает кнопку сортировки.
            btnSort.Enabled = false;
        }
        private void ClearFields()
        {
            lblArr.Text = "";
            lblResult.Text = "";
            txtMax.Text = "";
            txtMin.Text = "";
            btnSort.Enabled = false;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    } /* Selection sort (Сортировка выбором): На каждом шаге этот алгоритм находит минимальный (или максимальный) элемент и перемещает его на соответствующую позицию.
Insertion sort (Сортировка вставками): Этот алгоритм поочередно берет каждый элемент массива и вставляет его на подходящее место в уже отсортированной части массива. */
}
