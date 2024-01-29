using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transformaciones
{
    internal class Cuadrado
    {
        public PointF a,b,c,d;
        public float lado;

        public Cuadrado(float lado)
        {
            this.lado = lado;
            this.a = new PointF(0, 0);
            this.b = new PointF(0, lado);
            this.c = new PointF(lado, lado);
            this.d = new PointF(lado, 0);
        }

        public void ConnectPoints(Graphics g)
        {
            g.DrawLine(Pens.Red, a, b);
            g.DrawLine(Pens.Yellow, b, c);
            g.DrawLine(Pens.Yellow, c, d);
            g.DrawLine(Pens.Yellow, d, a);
        }

        public void MoveFigure(float xMove, float yMove) 
        {
            a.X += xMove;
            b.X += xMove;
            c.X += xMove;
            d.X += xMove;

            a.Y += yMove;
            b.Y += yMove;
            c.Y += yMove;
            d.Y += yMove;
        }

        public void ScalateFigure(float scale)
        {
            b.Y = b.Y - lado + lado * scale;
            c.X = c.X - lado + lado * scale;
            c.Y = c.Y - lado + lado * scale;
            d.X = d.X - lado + lado * scale;
            lado = lado * scale;
        }

        public void RotatedPoints(double angle)
        {
            a = Rotate(a, angle); 
            b = Rotate(b, angle);
            c = Rotate(c, angle);   
            d = Rotate(d, angle);
        }

        private PointF Rotate(PointF a, double angle)
        {
            PointF rotated_Point = new PointF();

            rotated_Point.X = (float)((a.X * Math.Cos(angle)) - (a.Y * Math.Sin(angle)));
            rotated_Point.Y = (float)((a.X * Math.Sin(angle)) + (a.Y * Math.Cos(angle)));

            return rotated_Point;
        }
    }
}
