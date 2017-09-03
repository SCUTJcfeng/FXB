using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen pen = new Pen(Color.Indigo, 5);
            //pen.DashPattern = new float[] { 3, 3 };
            //graphics.DrawLine(pen, 20, 20, 220, 220);
            //graphics.DrawLine(pen, 20, 220, 220, 20);
            //graphics.DrawLine(pen, 20, 20, 220, 20);
            //graphics.DrawLine(pen, 20, 20, 20, 220);
            //graphics.DrawLine(pen, 20, 220, 220, 220);
            //graphics.DrawLine(pen, 220, 20, 220, 220);

            //graphics.DrawEllipse(pen, 20, 20, 200, 200);

            //F
            graphics.DrawLine(pen, 20, 20, 110, 20);
            graphics.DrawLine(pen, 20, 20, 20, 220);
            graphics.DrawLine(pen, 20, 120, 110, 120);

            //X
            graphics.DrawLine(pen, 130, 20, 240, 220);
            graphics.DrawLine(pen, 240, 20, 130, 220);

            //B
            graphics.DrawLine(pen, 260, 20, 260, 220);
            graphics.DrawArc(pen, 200, 20, 120, 100,-90,180);
            graphics.DrawArc(pen, 200, 120, 120, 100, -90,180);

            //-------
            Pen p = new Pen(Color.GreenYellow, 10);
            p.DashPattern = new float[] { 2, 1 };
            graphics.DrawLine(p, 20, 240, 320, 240);
        }
    }
}
