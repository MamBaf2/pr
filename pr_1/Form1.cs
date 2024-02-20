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
        //
        private int x1, y1, x2, y2;
        private double a,t,fi;

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private Pen pen = new Pen(Color.DarkRed, 2);

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawLine(pen, x2, y2, 20, 20);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            a = 150;
            fi = -0.5;
            t=Math.Tan(fi);
            x1 = ClientSize.Width / 2;
            y1 = ClientSize.Height / 2;
            x2 = x1 + (int)((3*a*t)/(1+t*t*t));
            y2 = y1 - (int)((3*a*t*t)/(1+t*t*t));
        }
        private void tmr_Tick(object sender, EventArgs e)
        {
            fi += 0.01;
            t=Math.Tan(fi);
            x2 = x1 + (int)((3*a*t)/(1+t*t*t));
            y2 = y1 - (int)((3*a*t*t)/(1+t*t*t));
            Invalidate();
        }
    }
}
