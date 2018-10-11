using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drawTree
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        const double PI = Math.PI;
        public double th1 = 35 * Math.PI / 180;
        public double th2 = 25 * Math.PI / 180;
        public double per1 = 0.6;
        public double per2 = 0.7;

        public Boolean isRandom = true;
        public double k = 2;
        public double width=0.1;
        public string color;
        public Pen pen = new Pen(Color.Blue, 1);
        


        Random rnd = new Random();


        double Rand()
        {
            return rnd.NextDouble();
        }

        public Form1()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual; //A
            this.Location = new Point(400, 0); //B

            this.Paint += new PaintEventHandler(this.Form1_Paint);
            this.Click += new EventHandler(this.Redraw);

  
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Redraw);
        }



        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            
            switch (color)
            {
                case "blue":
                    pen.Color = Color.Blue;
                    break;
                case "red":
                    pen.Color = Color.Red;
                    break;
                case "green":
                    pen.Color = Color.Green;
                    break;
                case "pink":
                    pen.Color = Color.Pink;
                    break;
                case "violet":
                    pen.Color = Color.Violet;
                    break;
                case "yellow":
                    pen.Color = Color.Yellow;
                    break;
            }
            pen.Width = (float)width;

            graphics = e.Graphics;

            if(isRandom)
            {
                DrawTreeRnd(10, 300, 500, 100, -PI / 2, k, pen);
            }
            else
            {
                DrawTree(10, 300, 500, 100, -PI / 2, k, pen);
            }


        }

        private void Redraw(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        void DrawTreeRnd(int n, double x0, double y0, double leng, double th,double k,Pen pen)
        {

            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            double x2 = x0 + leng *k* Math.Cos(th);
            double y2 = y0 + leng *k* Math.Sin(th);

            DrawLine(x0, y0, x1, y1,pen);
            DrawTreeRnd(n - 1, x1, y1, per1 * leng * (0.5 + Rand()), th + th1 * (0.5 + Rand()),k,pen);



            DrawLine(x1, y1, x2, y2,pen);
            DrawTreeRnd(n - 1, x2, y2, per2 * leng * (0.4 + Rand()), th - th2 * (0.5 + Rand()),k,pen);

            if (Rand() > 0.6)
            {
                DrawTreeRnd(n - 1, x1, y1, per1 * leng * (0.5 + Rand()), th + th1 * (0.5 + Rand()),k,pen);
                DrawTreeRnd(n - 1, x2, y2, per2 * leng * (0.4 + Rand()), th - th2 * (0.5 + Rand()),k,pen);

            }
                

        }

        void DrawTree(int n, double x0, double y0, double leng, double th, double k, Pen pen)
        {

            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            double x2 = x0 + leng * k * Math.Cos(th);
            double y2 = y0 + leng * k * Math.Sin(th);

            DrawLine(x0, y0, x1, y1, pen);
            DrawTree(n - 1, x1, y1, per1 * leng, th + th1, k, pen);



            DrawLine(x1, y1, x2, y2, pen);
            DrawTree(n - 1, x2, y2, per2 * leng, th - th2, k, pen);


        }


        void DrawLine(double x0, double y0, double x1, double y1, Pen pen)
        {
            
            graphics.DrawLine(new Pen(pen.Color, pen.Width), (int)x0, (int)y0, (int)x1, (int)y1);


        }

        private void Form1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
