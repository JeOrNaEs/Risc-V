using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Text = "PC";
            label1.Visible = true;
            Graphics golfgti6;
            golfgti6 = pictureBox1.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 1);
            Pen blackPen2 = new Pen(Color.Black, 3);
            golfgti6.DrawRectangle(blackPen, 10, 50, 30, 55);
            golfgti6.DrawLine(blackPen2, 25, 0, 25, 50);
            golfgti6.DrawLine(blackPen2, 25, 0, 800, 0);
            golfgti6.DrawLine(blackPen2, 800, 0, 800, 60);
            golfgti6.DrawLine(blackPen2, 800, 60, 780, 60);
            golfgti6.DrawEllipse(blackPen, 750, 20, 30, 120);
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            golfgti6.DrawLine(blackPen2, 25, 105, 25, 160);
            golfgti6.DrawRectangle(blackPen, 5, 160, 200, 210);
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            golfgti6.DrawLine(blackPen2, 25, 125, 75, 125);
            golfgti6.DrawEllipse(blackPen2, 22, 122, 5, 5);
            golfgti6.DrawLine(blackPen2, 74, 126, 74, 45);
            golfgti6.DrawLine(blackPen2, 74, 44, 194, 44);
            golfgti6.DrawLine(blackPen, 194, 24, 194, 64);
            golfgti6.DrawLine(blackPen, 194, 64, 204, 69);
            golfgti6.DrawLine(blackPen, 204, 69, 194, 74);
            golfgti6.DrawLine(blackPen, 194, 74, 194, 114);
            golfgti6.DrawLine(blackPen, 274, 44, 274, 94);
            golfgti6.DrawLine(blackPen, 194, 24, 274, 44);
            golfgti6.DrawLine(blackPen, 274, 94, 194, 114);
            golfgti6.DrawLine(blackPen2, 174, 94, 194, 94);
            label13.Visible = true;
            label14.Visible = true;
            golfgti6.DrawLine(blackPen2, 274, 67, 594, 67);
            golfgti6.DrawLine(blackPen, 594, 44, 594, 84);
            golfgti6.DrawLine(blackPen, 594, 84, 604, 89);
            golfgti6.DrawLine(blackPen, 604, 89, 594, 94);
            golfgti6.DrawLine(blackPen, 594, 94, 594, 134);
            golfgti6.DrawLine(blackPen, 684, 64, 684, 114);
            golfgti6.DrawLine(blackPen, 594, 44, 684, 64);
            golfgti6.DrawLine(blackPen, 684, 114, 594, 134);
            label15.Visible = true;
            golfgti6.DrawEllipse(blackPen2, 572, 65, 5, 5);
            golfgti6.DrawLine(blackPen2, 574, 67, 574, 30);
            golfgti6.DrawLine(blackPen2, 574, 30, 758, 30);
            golfgti6.DrawLine(blackPen2, 685, 90, 750, 90);

            golfgti6.DrawLine(blackPen, 205, 190, 350, 190);
            golfgti6.DrawEllipse(blackPen2, 224, 188, 4, 4);
            golfgti6.DrawLine(blackPen, 225, 230, 350, 230);
            golfgti6.DrawEllipse(blackPen2, 224, 228, 4, 4);
            golfgti6.DrawLine(blackPen, 225, 350, 295, 350);
            golfgti6.DrawEllipse(blackPen2, 224, 348, 4, 4);
            golfgti6.DrawLine(blackPen, 225, 190, 225,460);
            golfgti6.DrawEllipse(blackPen, 290, 240, 30, 120);
            label19.Visible = true;
            label20.Visible = true;
            label21.Visible = true;
            label22.Visible = true;
            label23.Visible = true;
            golfgti6.DrawLine(blackPen, 270, 230, 270, 270);
            golfgti6.DrawEllipse(blackPen2, 268, 228, 4, 4);
            golfgti6.DrawLine(blackPen, 270, 270, 290, 270);
            golfgti6.DrawLine(blackPen, 320, 305, 350, 305);

            golfgti6.DrawRectangle(blackPen, 350, 175, 150, 210);
            label24.Visible = true;
            label25.Visible = true;
            label26.Visible = true;
            label27.Visible = true;
            label28.Visible = true;
            label29.Visible = true;
            label30.Visible = true;
            label31.Visible = true;
            label32.Visible = true;
            label33.Visible = true;
            label34.Visible = true;
            label35.Visible = true;
            label36.Visible = true;
            label37.Visible = true;
            label38.Visible = true;
            label39.Visible = true;
            label40.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics golfgti6;
            golfgti6 = pictureBox1.CreateGraphics();
            Pen redPen = new Pen(Color.Red, 1);
            Pen blackPen = new Pen(Color.Black, 1);
            Pen redPen2 = new Pen(Color.Red, 3);
            Pen blackPen2 = new Pen(Color.Black, 3);
            Thread.Sleep(1000);
            golfgti6.DrawRectangle(redPen, 10, 50, 30, 55);
            Thread.Sleep(1000);
            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            golfgti6.DrawRectangle(blackPen, 10, 50, 30, 55);
            golfgti6.DrawLine(redPen2, 25, 105, 25, 160);
            Thread.Sleep(1000);
            golfgti6.DrawLine(blackPen2, 25, 105, 25, 160);
            golfgti6.DrawRectangle(redPen, 5, 160, 200, 210);
            Thread.Sleep(1000);
            golfgti6.DrawRectangle(blackPen, 5, 160, 200, 210);
            golfgti6.DrawLine(redPen, 205, 190, 350, 190);
            Thread.Sleep(1000);
            golfgti6.DrawLine(blackPen, 205, 190, 350, 190);
            golfgti6.DrawRectangle(redPen, 350, 175, 150, 210);
        }
    }
}
