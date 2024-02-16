using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeParticulas
{
    public partial class Form1 : Form
    {
        List<Ball> balls;
        Bitmap bmp;
        Graphics g;
        static Random rand = new Random();
        static float deltaTime;

       

        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
            TXT_BALLS_AMOUNT.Text = "10";
            Init();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            AdjustCanvasSize();
        }

        private void AdjustCanvasSize()
        {
            // Adjust the size and position of PCT_CANVAS based on the form size
            PCT_CANVAS.Size = new Size(this.ClientSize.Width - 20, this.ClientSize.Height - 70);
            PCT_CANVAS.Location = new Point(5, 60);
        }



        private void Init()
        {
            if (PCT_CANVAS.Width == 0) return;
            balls = new List<Ball>();
            bmp = new Bitmap(PCT_CANVAS.Width, PCT_CANVAS.Height);
            g = Graphics.FromImage(bmp);
            deltaTime = 0;
            PCT_CANVAS.Image = bmp;
            for (int i = 0; i < int.Parse(TXT_BALLS_AMOUNT.Text); i++)
                balls.Add(new Ball(rand, PCT_CANVAS.Size, i));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; // Establecer el estado del formulario como maximizado
            AdjustCanvasSize();
            Init();
        }

        private void TIMER_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.Black);
            Ball b;
            for (int i = 0; i < balls.Count; i++) {
                balls[i].Update(balls, deltaTime);
                b = balls[i];
                g.FillEllipse(new SolidBrush(balls[i].c), b.X - b.diameter / 2, b.Y - b.diameter / 2, b.diameter, b.diameter);
                balls[i].changed = false; 
            }
            PCT_CANVAS.Invalidate();
            deltaTime += .1f;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void TXT_BALLS_AMOUNT_TextChanged(object sender, EventArgs e)
        {

        }

        private void PCT_CANVAS_Click(object sender, EventArgs e)
        {

        }
    }
}
