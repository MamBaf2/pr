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
        private PictureBox rocketPictureBox;
        private Timer timer;
        private int rocketYPosition;
        public Form2()
        {
            InitializeComponent();
            InitializeRocket();
            InitializeTimer();
        }
        private void InitializeRocket()
        {
            rocketPictureBox = new PictureBox();
            rocketPictureBox.Image = Properties.Resources.rocket;
            rocketPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            rocketPictureBox.Size = new Size(100, 200);
            rocketPictureBox.Location = new Point(ClientSize.Width / 2 - rocketPictureBox.Width / 2, ClientSize.Height);
            Controls.Add(rocketPictureBox);
            rocketYPosition = rocketPictureBox.Location.Y;
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += tmr_Tick;
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            rocketYPosition -= 5; // Скорость взлета
            rocketPictureBox.Location = new Point(rocketPictureBox.Location.X, rocketYPosition);
            if (rocketYPosition <= -rocketPictureBox.Height)
            {
                timer.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rocketYPosition = ClientSize.Height;
            rocketPictureBox.Location = new Point(ClientSize.Width / 2 - rocketPictureBox.Width / 2, rocketYPosition);
            timer.Start();
        }
    }
}
