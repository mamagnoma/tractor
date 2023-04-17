using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        private void DrawPerson(Graphics g, int x, int y)
        {
            // Нарисуйте голову
            g.DrawEllipse(Pens.Black, x - 20, y - 40, 40, 40);

            // Нарисуйте тело
            g.DrawLine(Pens.Black, x, y, x, y + 80);

            // Нарисуйте руки
            g.DrawLine(Pens.Black, x, y + 20, x - 20, y + 60);
            g.DrawLine(Pens.Black, x, y + 20, x + 20, y + 60);

            // Нарисуйте ноги
            g.DrawLine(Pens.Black, x, y + 80, x - 20, y + 120);
            g.DrawLine(Pens.Black, x, y + 80, x + 20, y + 120);
        }
        private void DrawTractor(Graphics g, int x, int y, Color color)
        {
            // Нарисуйте кузов трактора
            g.FillRectangle(new SolidBrush(color), x, y, 100, 50);

            // Нарисуйте колеса трактора
            g.FillEllipse(Brushes.Black, x + 10, y + 40, 20, 20);
            g.FillEllipse(Brushes.Black, x + 70, y + 40, 20, 20);

            // Нарисуйте руль трактора
            g.DrawLine(Pens.Black, x + 10, y + 10, x + 30, y + 10);
            g.DrawLine(Pens.Black, x + 10, y + 10, x + 10, y + 30);
            g.DrawLine(Pens.Black, x + 10, y + 30, x + 30, y + 30);

            // Нарисуйте окно трактора
            g.FillRectangle(Brushes.White, x + 60, y + 10, 30, 30);
            g.DrawRectangle(Pens.Black, x + 60, y + 10, 30, 30);
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawPerson(e.Graphics, 100, 200);
            DrawTractor(e.Graphics, 100, 50, Color.Blue);
            DrawTractor(e.Graphics, 00, 50, Color.Yellow);
            //Graphics g = e.Graphics; g.Clear(Color.White); for (int i = 0; i < 50; i++);
                //g.DrawLine(new Pen(Brushes.Black, 2),
                //10, 4 * i + 20, 200, 4 * i + 20);

        }
    }
}
