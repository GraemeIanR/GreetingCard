using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GreetingCard
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen blackPen = new Pen(Color.Black, 5);
        Brush brownBrush = new SolidBrush(Color.Brown);
        Brush greenBrush = new SolidBrush(Color.LimeGreen);
        Brush redBrush = new SolidBrush(Color.Red);
        Brush blueBrush = new SolidBrush(Color.Blue);
        Brush whiteBrush = new SolidBrush(Color.White);
        Font Lobster = new Font("Lobster", 30, FontStyle.Bold);

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            g.Clear(Color.Green);

            g.DrawRectangle(blackPen, 275, 250, 50, 75);
            g.FillRectangle(brownBrush, 275, 250, 50, 75);
            g.DrawArc(blackPen, 150, 200, 300, 50, 0, 180);
            g.DrawLine(blackPen, 150, 230, 210, 150);
            g.DrawLine(blackPen, 450, 230, 390, 150);
            g.DrawLine(blackPen, 210, 150, 180, 150);
            g.DrawLine(blackPen, 390, 150, 415, 150);
            g.DrawLine(blackPen, 180, 150, 300, 25);
            g.DrawLine(blackPen, 415, 150, 300, 25);
            g.FillEllipse(redBrush, 250, 100, 15, 15);
            g.FillEllipse(redBrush, 375, 200, 15, 15);
            g.FillEllipse(greenBrush, 190, 200, 15, 15);
            g.FillEllipse(greenBrush, 325, 155, 15, 15);
            g.FillEllipse(blueBrush, 280, 220, 15, 15);
            g.FillEllipse(blueBrush, 300, 65, 15, 15);
            g.FillEllipse(whiteBrush, 260, 160, 15, 15);
            g.FillEllipse(whiteBrush, 335, 115, 15, 15);
            g.DrawRectangle(blackPen, 180, 275, 75, 50);
            g.FillRectangle(blueBrush, 180, 275, 75, 50);
            g.DrawRectangle(blackPen, 209, 275, 15, 50);
            g.FillRectangle(whiteBrush, 209, 275, 15, 50);
            g.DrawRectangle(blackPen, 180, 292, 75, 15);
            g.FillRectangle(whiteBrush, 180, 292, 75, 15);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            g.Clear(Color.Green);

            g.DrawRectangle(blackPen, 150, 150, 300, 200);
            g.FillRectangle(blueBrush, 150, 150, 300, 200);
            g.DrawRectangle(blackPen, 263, 150, 75, 200);
            g.FillRectangle(whiteBrush, 263, 150, 75, 200);
            g.DrawRectangle(blackPen, 150, 220, 300, 75);
            g.FillRectangle(whiteBrush, 150, 220, 300, 75);

            int i = 1;

            Thread.Sleep(1000);

            while (i <= 100)
            {
                g.Clear(Color.Green);
                g.DrawString("Merry Christmas!!", Lobster, whiteBrush, 180, 125);

                Thread.Sleep(250);

                g.Clear(Color.Green);
                g.TranslateTransform(175, 200);
                g.RotateTransform(9);
                g.DrawString("Merry Christmas!!", Lobster, whiteBrush, 5, -20);

                Thread.Sleep(250);

                g.Clear(Color.Green);
                g.RotateTransform(-18);
                g.DrawString("Merry Christmas!!", Lobster, whiteBrush, -5, 10);
                g.ResetTransform();

                Thread.Sleep(250);
                i++;
            }
            Close();
        }
    }
}
