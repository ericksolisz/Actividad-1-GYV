using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Drawing;

namespace Transformaciones
{
    internal class Canvas
    {
        Bitmap bitmap;
        public int Width, Height, Sx, Sy;
        public double angle;
        public List<PointF> points = new List<PointF>() { new PointF(0,0), new PointF(0,100), new PointF(100,100), new PointF(100,0) };
        public List<PointF> lines = new List<PointF>() { new PointF(0, 0), new PointF(150, 50), new PointF(0, 100) };
        public Figure Cuadrado;

        public Canvas(Bitmap bitmap) 
        {
            this.bitmap = bitmap;
            Width = bitmap.Width;
            Height = bitmap.Height;
            Sy = Height / 2;
            Sx = Width / 2;
            angle = 0;

            Cuadrado = new Figure(points, Width, Height);
           
        }

        public void RenderPlanes(Graphics g)
        {
            // Crea las lineas del plano de referencia
            Point h1 = new Point(0, Sy);
            Point h2 = new Point(Width, Sy);
            Point w1 = new Point(Sx, 0);
            Point w2 = new Point(Sx, Height);

            g.DrawLine(Pens.Gray, h1, h2);
            g.DrawLine(Pens.Gray, w1, w2);
        }

        public void Render(Graphics g)
        {
            Cuadrado.DrawFigure(g, 1);
            
        }

        public void Update(Graphics g)
        {
            Clean(g);
            Cuadrado.DrawFigure(g, 1);
            
        }


        // Aqui inician las funciones para la animacion
        private PointF RotatePoint(PointF a)
        {
            PointF rotated_Point = new PointF();

            rotated_Point.X = Sx + (float)((a.X * Math.Cos(angle)) - (a.Y * Math.Sin(angle)));
            rotated_Point.Y = Sy - (float)((a.X * Math.Sin(angle)) + (a.Y * Math.Cos(angle)));

            return rotated_Point;
        }

        private void RotatedLine(Graphics g, Point a, Point b)
        {
            PointF a2 = RotatePoint(a);
            PointF b2 = RotatePoint(b); 

            g.DrawLine(Pens.Red, a2, b2);
        }

        private void RotatedLineY(Graphics g, Point a, Point b)
        {
            PointF a2 = RotatePoint(a);
            PointF b2 = RotatePoint(b);

            g.DrawLine(Pens.Yellow, a2, b2);
        }

        public void RenderR(Graphics g) 
        {
            Point a = new Point(20, 0);
            Point b = new Point(20, 100);
            Point c = new Point(120, 100);
            Point d = new Point(120, 0);

            RotatedLine(g, a, b);
            RotatedLine(g, b, c);
            RotatedLine(g, c, d);
            RotatedLine(g, d, a);
        }

        public void RenderCenterR(Graphics g) 
        {
            Point a = new Point(-50, -50);
            Point b = new Point(-50, 50);
            Point c = new Point(50, 50);
            Point d = new Point(50, -50);

            RotatedLineY(g, a, b);
            RotatedLineY(g, b, c);
            RotatedLineY(g, c, d);
            RotatedLineY(g, d, a);
        }
        // Aqui terminan las lineas de la animacion

        public void Clean(Graphics g)
        {
            Graphics.FromImage(bitmap).Clear(Color.Black);
            RenderPlanes(g);
            angle = 0;
        }
    }
}
