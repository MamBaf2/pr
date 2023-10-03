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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text))
                lstNames.Items.Add(txtName.Text);
            Cursor.Position = PointToScreen(button1.Location);
            btnAdd.Text = "&Print";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "&Print";
            label1.TabIndex = 9;
            button1.TabIndex = 10;
        }

        private void True(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                MessageBox.Show($"Form.KeyPress: '{e.KeyChar}' pressed.");
                switch (e.KeyChar)
                {
                    case (char)49:
                    case (char)52:
                    case (char)55:
                        MessageBox.Show($"Form.KeyPress: '{e.KeyChar}' consumed.");
                        e.Handled = true;
                        break;

                }
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e) =>
            Cursor.Hide();

        private void button1_MouseLeave(object sender, EventArgs e) =>
            Cursor.Show();

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedName = lstNames.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedName))
            {
                lstNames.Items.Remove(selectedName);
            }
            Cursor.Position = PointToScreen(btnAdd.Location);
        }
    }
}
