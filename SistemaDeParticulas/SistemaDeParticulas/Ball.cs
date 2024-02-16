using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeParticulas
{
    internal class Ball
    {
        static Size space; 
        public float Radius, diameter, vx, vy;
        public float X, Y;
        public int index; 
        public Color c;
        public bool changed;

        public Ball(Random rand, Size size, int index) { 
            X = rand.Next(0, size.Width); 
            Y = rand.Next(0, size.Height);
            vx = rand.Next(-5, 10);
            vy = rand.Next(-5, 10);
            diameter = rand.Next(40, 55); 
            space = size;
            this.index = index;
            changed = false;
            Radius = diameter / 2;
            c = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
        }

        public void Render(Graphics g)
        {
            Brush brush = new SolidBrush(c);
            g.FillEllipse(brush, X - Radius, Y - Radius, diameter, diameter);
            g.DrawEllipse(Pens.Black, X - Radius, Y - Radius, diameter, diameter);
            g.FillEllipse(Brushes.White, X - 2, Y - 2, 4, 4);
        }



        private void ResolveWalls() { 
            if ((X - Radius) < 0) { changed = true;
                vx *= -1; X = Radius; 
            }
            if ((X + Radius) > space.Width) { 
                changed = true; 
                vx *= -1; X = space.Width - Radius; 
            }
            if ((Y - Radius) < 0) { 
                vy *= -1; changed = true; 
                Y = Radius; 
            } 
            if ((Y + Radius) > space.Height) {
                vy *= -1; 
                changed = true; 
                Y = space.Height - Radius; 
            } 
        }


        public void Update(List<Ball> balls, float deltaTime) { 
            float val = .95f;
            X += (vx * deltaTime);
            Y += (vy * deltaTime); 
            for (int b = index + 1; b < balls.Count; b++) {
                if (Collision(balls[b])) { 
                    Resolve(balls[b]); 
                } 
            } 
            ResolveWalls(); 
            vx *= val; vy *= val; 
        }


        public Boolean Collision(Ball ball) {

            float distance = Distance(ball);
            return distance <= (Radius + ball.Radius);


        }
        private float Distance(Ball ball) {
            float dx = X - ball.X;
            float dy = Y - ball.Y;
            return (float)Math.Sqrt(dx * dx + dy * dy);


        }
        public void Resolve(Ball other) {

            float dx = other.X - X;
            float dy = other.Y - Y;
            float distance = (float)Math.Sqrt(dx * dx + dy * dy);
            float overlap = (Radius + other.Radius) - distance;
            float moveX = (overlap / distance) * dx * 0.5f;
            float moveY = (overlap / distance) * dy * 0.5f;

            X -= moveX;
            Y -= moveY;
            other.X += moveX;
            other.Y += moveY;

            // Se asume elasticidad perfecta, por lo que se invierten las velocidades
            float tempVx = vx;
            float tempVy = vy;
            vx = other.vx;
            vy = other.vy;
            other.vx = tempVx;
            other.vy = tempVy;

            changed = true;
            other.changed = true;

        }



    }
}
