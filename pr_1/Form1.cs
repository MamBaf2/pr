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
    public partial class Lab5 : Form
    {
        public Lab5()
        {
            //Инициализация компонентов формы
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            /*Кнопка, обнаруживаются элементы fromX, toX, fromY и toY, в которых сохраняются значения,
             введенные в текстовых полях txtX1, txtX2, txtY1 и txtY2. */
            int fromX = int.Parse(txtX1.Text);
            int toX = int.Parse(txtX2.Text);
            int fromY = int.Parse(txtY1.Text);
            int toY = int.Parse(txtY2.Text);
        if (fromX > toX)
            {
                /*Это проверка условия: если начальное значение fromX больше конечного значения toX, 
                 то выводится сообщение с ошибкой, и текстовые поля txtX1 и txtX2 очищаются. */
                MessageBox.Show("интервал должен быть от меньшего к большему!");
                txtX1.Text = "";
                txtX2.Text = "";
            }
        if (fromY > toY)
            {
                /*Это проверка условия: если начальное значение fromY больше конечного значения toY, 
                 то выводится сообщение с ошибкой, и текстовые поля txtY1 и txtY2 очищаются. */
                MessageBox.Show("интервал должен быть от меньшего к большему!");
                txtY1.Text = "";
                txtY2.Text = "";
            }
            /*Это два вложенных цикла for, которые перебирают значения x и y в заданных интервалах.
            добавляется строка в элемент lstResult ,
            которая содержит результат вычисления z(x, y) = x - y  */
            for (int x = fromX; x <= toX; x++)
            {
                for (int y = fromY; y <= toY; y++)
                {
                    lstResult.Items.Add($"z(x,y) = {x} - {y} = {x - y}");
                }
            }
        }
    }
}
