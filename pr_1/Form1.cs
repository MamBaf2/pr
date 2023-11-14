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
        private int[] Arr = new int[10];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                                
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewArr_Click(object sender, EventArgs e)
        {
            int n = 10;
            int a = int.Parse(txtMin.Text);
            int b = int.Parse(txtMax.Text);
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                Arr[i] = r.Next(a, b);
                lblArr.Text += Arr[i];
                if (i != n) lblArr.Text += ",";
            }
            btnSort.Enabled = true;
        }
        private int MinNumber(int[] x, int m) //Эту часть кода видимо писал под снюсом, сами видели :)
        {
            int min = x[m];
            int MinN = m; //Короче эта часть кода приводит к состоянию готовности минимальный элемент в оставшейся части массива
            for (int i = m; i < x.Length; i++) //Цикл определения минимального элемента в оставшейся части массива
            {
                if (x[i] < min) //Обновление минимального элемента и его индекса
                {
                    min = x[i];
                    MinN = i;
                }
            }
            return MinN; //Возвращаем индекс мин элемента
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            {
                int k, t; //Короче эта часть кода приводит к состоянию готовности 
                for (int i = 0; i < Arr.Length; i++) /* Короче i приравнивается к 0, и постепенно увеличивается на 1,
                                              и цикл будет продолжаться пока i не дойдет до значения длины массива, в данном случае это 10*/
                {
                    k = MinNumber(Arr, i);
                    t = Arr[i]; //Временная переменная принимает значение
                    Arr[i] = Arr[k]; // i заменяется на мин значение из предыдущего шага 
                    Arr[k] = t; // Значение из предыдущего шага заменятеся на значение из временной переменной 
                    lblResult.Text += Arr[i]; //Добавление текущего элемента в текстовое поле 
                    if (i != Arr.Length - 1) { lblResult.Text += ","; } //Добавление запятой, если данный элемент не последний
                }
                btnSort.Enabled = false; //Блокировка кнопки сортировки
            }
        }
        private void ClearFields()
        {
            lblArr.Text = "";
            lblResult.Text = "";
            txtMax.Text = "";
            txtMin.Text = "";
            btnSort.Enabled = false; //Блокировка кнопки сортировки
        }

        private void btnForm_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); // Создание экземпляра Form2
            form2.Show(); // Открыть Form2
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
