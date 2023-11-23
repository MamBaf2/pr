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
        // Объявление переменной Arr как массива целых чисел длиной 10 элементов.
        private int[] Arr = new int[10];
        public Form1()
        {
            // Инициализация компонентов формы.
            InitializeComponent();
        }
        //лучшая часть кода
        private void Form1_Load(object sender, EventArgs e)
        {
                                
        }
        //кнопка закрытия
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Закрывает текущую форму.
            this.Close();
        }
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
                if (i != n) lblArr.Text += ",";
            }
            // Включение кнопки сортировки
            btnSort.Enabled = true;
        }
        //метод предназначен для поиска индекса минимального элемента в массиве x, начиная с индекса m
        private int MinNumber(int[] x, int m) 
        {
            // Присваивает начальное значение минимального элемента.
            int min = x[m];
            // Присваивает начальное значение индекса минимального элемента.
            int MinN = m;
            // Поиск минимального элемента в части массива, начиная с индекса m.
            for (int i = m; i < x.Length; i++) 
            {
                // Если текущий элемент меньше текущего минимального элемента.
                if (x[i] < min) 
                {
                    // Обновляет значение минимального элемента.
                    min = x[i];
                    // Обновляет значение индекса минимального элемента.
                    MinN = i;
                }
            }
            // Возвращает индекс минимального элемента.
            return MinN; 
        }
        //кнопка сортировки
        private void btnSort_Click(object sender, EventArgs e)
        {
            {
                // Объявление переменных k и t для хранения временных значений
                int k, t;
                // Цикл сортировки массива Arr методом выбора (Selection Sort)
                for (int i = 0; i < Arr.Length; i++) 
                {
                    // Поиск индекса минимального элемента начиная с i.
                    k = MinNumber(Arr, i);
                    // Запоминание текущего значения Arr[i].
                    t = Arr[i];
                    // Замена Arr[i] на минимальный элемент.
                    Arr[i] = Arr[k];
                    // Замена минимального элемента на Arr[i].
                    Arr[k] = t;
                    // Добавление текущего элемента в текстовое поле lblResult.
                    lblResult.Text += Arr[i];
                    // Добавление запятой, если данный элемент не последний.
                    if (i != Arr.Length - 1) { lblResult.Text += ","; } 
                }
                // Блокировка кнопки сортировки после выполнения.
                btnSort.Enabled = false; 
            }
        }
        // Метод для очистки полей и блокировки кнопки сортировки
        private void ClearFields()
        {
            lblArr.Text = "";
            lblResult.Text = "";
            txtMax.Text = "";
            txtMin.Text = "";
            btnSort.Enabled = false; 
        }
        //открытие второй формы
        private void btnForm_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); 
            form2.Show(); 
        }
        // Вызов метода ClearFields() при нажатии на кнопку
        private void button1_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
