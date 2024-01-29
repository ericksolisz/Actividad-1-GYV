using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transformaciones
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Canvas canvas;

        Graphics g;

        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            bmp = new Bitmap(PCT_Canvas.Width, PCT_Canvas.Height);
            g = Graphics.FromImage(bmp);
            PCT_Canvas.Image = bmp;
            canvas = new Canvas(bmp);
            canvas.RenderPlanes(g);
            canvas.Render(g);

            PCT_Canvas.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PCT_Canvas_Click(object sender, EventArgs e)
        {

        }

        private void TIMER_Tick(object sender, EventArgs e)
        {
            double normalAngle = canvas.angle / Math.PI * 180;
            PCT_Canvas.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            canvas.Clean(g);

            PCT_Canvas.Invalidate();
        }

       

        private void CcenterButton_Click(object sender, EventArgs e)
        {
            canvas.Cuadrado.CenterFigure();
            canvas.Update(g);
        }

        private void CXPlusButton_Click(object sender, EventArgs e)
        {
            canvas.Cuadrado.MoveFigure(5, 0);
            canvas.Update(g);
        }

        private void CXMinusButton_Click(object sender, EventArgs e)
        {
            canvas.Cuadrado.MoveFigure(-5, 0);
            canvas.Update(g);
        }

        private void CYPlusButton_Click(object sender, EventArgs e)
        {
            canvas.Cuadrado.MoveFigure(0, -5);
            canvas.Update(g);
        }

        private void CYMinusButton_Click(object sender, EventArgs e)
        {
            canvas.Cuadrado.MoveFigure(0, 5);
            canvas.Update(g);
        }

        private void XPlusSButton_Click(object sender, EventArgs e)
        {
            canvas.Cuadrado.ScaleFigure((float)1.1);
            canvas.Update(g);
        }

        private void CMinusSButton_Click(object sender, EventArgs e)
        {
            canvas.Cuadrado.ScaleFigure((float)-0.9);
            canvas.Update(g);
        }

        private void CRotateButton_Click(object sender, EventArgs e)
        {
            canvas.Cuadrado.RotateFigure(5);
            canvas.Update(g);
        }

        private void CRotateOGButton_Click(object sender, EventArgs e)
        {
            canvas.Cuadrado.RotateFigureOG(5);
            canvas.Cuadrado.RotateFigureOG(5);
            canvas.Update(g);
        }
    }
}
