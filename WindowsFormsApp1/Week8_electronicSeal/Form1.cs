using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace electronicSeal
{
    public partial class Form1 : Form
    {
        String str_seal= "无用阶级第八周作业";
        Font font= new Font("仿宋", 20f, FontStyle.Bold);
        int size_Seal = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void RenderSeal(Graphics g, string text, PointF center, float radius, float angle)
        {
            float newAngle = (angle % 360 - 180) / 2 + 180;
            int times = text.Length;
            SizeF sf = SizeF.Empty;
           // Font font = new Font("仿宋", 20f,FontStyle.Bold);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            sf = g.MeasureString(text[0].ToString(), font);
            //外圆
            g.DrawEllipse(new Pen(Color.Red, 5),
                   new RectangleF(center.X - radius - sf.Width / 2,
                   center.Y - radius - sf.Width / 2, radius * 2 + sf.Width, radius * 2 + sf.Height));
            //绘制印章文字
            for (int i = 0; i < times; i++)
            {
                float tempAngle = (newAngle - i * (angle / (times - 1)));
                float x = (float)Math.Cos((-1) * tempAngle * Math.PI / 180) * radius + center.X;
                float y = (float)Math.Sin((-1) * tempAngle * Math.PI / 180) * radius + center.Y;
                //先平移再旋转
                g.ResetTransform();
                g.TranslateTransform(x, y);
                g.RotateTransform(90 - tempAngle);
                sf = g.MeasureString(text[i].ToString(), font);
                g.DrawString(text[i].ToString(), font, Brushes.Red, -sf.Width / 2, -sf.Height / 2);
            }
        }

        public void RenderStar(Graphics g, PointF pt, float radius, float angle = 0)
        {
            int[] pointSequence = { 2, 4, 1, 3, 0 };
            List<PointF> points = new List<PointF>(pointSequence.Length);
            for (int i = 0; i < pointSequence.Length; i++)
            {
                float radian = (54 + 72 * pointSequence[i]) * (float)Math.PI / 180;
                points.Add(new PointF((float)Math.Cos(radian) * radius, (float)Math.Sin(radian) * radius));
            }
            g.ResetTransform();
            g.TranslateTransform(pt.X, pt.Y);
            g.RotateTransform(angle);
            g.FillPolygon(Brushes.Red, points.ToArray(), System.Drawing.Drawing2D.FillMode.Winding);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            PointF pointF= new PointF(ClientRectangle.Width / 2, ClientRectangle.Height / 2+70);
            RenderSeal(g, str_seal,pointF , (80*size_Seal)/10, 240);
            RenderStar(g, pointF, (50*size_Seal)/10, 0);
        }

        private void txtSeal_TextChanged(object sender, EventArgs e)
        {
            String tmp = txtSeal.Text.ToString();
            if(tmp.Length>0)
            {
                str_seal = tmp;
            }
            
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if (this.fontDialog1.ShowDialog() == DialogResult.OK)
            {
                //Font("仿宋", 20f, FontStyle.Bold);
                this.font = this.fontDialog1.Font;
                //font.FontFamily = this.fontDialog1.Font.FontFamily;
                
            }
        }

        private void trbSeal_ValueChanged(object sender, EventArgs e)
        {
            size_Seal = trbSeal.Value;
            int percent = size_Seal * 10;
            lblSizePercent.Text = percent.ToString()+"%";
        }
    }
}
