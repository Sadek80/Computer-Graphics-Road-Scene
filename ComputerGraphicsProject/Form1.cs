using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerGraphicsProject
{
    public partial class Form1 : Form
    {
        Graphics graphic;
        Graphics graphic_fan; 
        Graphics graphic_car;
        Brush groundBrush = new SolidBrush(Color.FromArgb(100, 100, 150));
        public Form1()
        {
            InitializeComponent();
            this.Height = 2000;
            this.Width = 2000;   
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Initialize Graphics
            initializeObjects();

            // Sky + Ground
            drawSkyAndGround();

            // Mountains
            drawMountains();

            // Sun
            drawSun();

            // Turbines
            drawWindTurbine();

            // Car
            drawCar();

            // Dispose Objects After Usage (Robustness)
            //graphic.Dispose();
            //graphic_car.Dispose();
            //graphic_fan.Dispose();
            //groundBrush.Dispose();
        }

        /// <summary>
        /// Draw main background (Sky & Ground)
        /// </summary>
        private void drawSkyAndGround()
        {
            graphic.Clear(Color.SkyBlue);
            graphic.FillRectangle(groundBrush, 0, 550, 2000, 280);
            graphic.DrawLine(new Pen(Color.White, 8), new Point(0, 630), new Point(2000, 630));
            graphic.FillRectangle(Brushes.Green, 0, 700, 2000, 230);
        }

        /// <summary>
        /// Draw Mountains along the Road
        /// </summary>
        private void drawMountains()
        {
            Point p1 = new Point(0, 550);
            Point p2 = new Point(0, 490);
            Point p3 = new Point(320, 350);
            Point p4 = new Point(350, 390);
            Point p5 = new Point(650, 240);
            Point p6 = new Point(950, 460);
            Point p7 = new Point(1250, 360);
            Point p8 = new Point(2000, 570);
            Point[] shape = { p1, p2, p3, p4, p5, p6, p7, p8 };
            graphic.FillPolygon(Brushes.Green, shape);
        }

        /// <summary>
        /// Draw a Yellow Ellipse..
        /// </summary>
        private void drawSun()
        {
            graphic.FillEllipse(Brushes.Yellow, 1050, 50, 150, 150);
        }

        /// <summary>
        /// Draw Wind Turbines
        /// </summary>
        private void drawWindTurbine()
        {
            //poles
            graphic.FillRectangle(Brushes.Gray, 240, 70, 10, 400);
            graphic.FillRectangle(Brushes.Gray, 500, 170, 5, 200);
            graphic.FillRectangle(Brushes.Gray, 800, 195, 7, 300);

            //fan
            Point p9 = new Point(245, 70);
            Point p10 = new Point(205, 40);
            Point p11 = new Point(55, 0);
            Point p12 = new Point(195, 70);
            Point[] fan1 = { p9, p10, p11, p12 };
            graphic_fan.FillPolygon(Brushes.Red, fan1);


            Point p13 = new Point(245, 70);
            Point p14 = new Point(285, 40);
            Point p15 = new Point(435, 0);
            Point p16 = new Point(295, 70);
            Point[] fan2 = { p13, p14, p15, p16 };
            graphic_fan.FillPolygon(Brushes.Red, fan2);


            Point p17 = new Point(245, 70);
            Point p18 = new Point(225, 100);
            Point p19 = new Point(245, 260);
            Point p20 = new Point(265, 100);
            Point[] fan3 = { p17, p18, p19, p20 };

            graphic_fan.FillPolygon(Brushes.Red, fan3);

            graphic_fan.TranslateTransform(380, 135);
            graphic_fan.ScaleTransform(.5f, .5f);


            graphic_fan.FillPolygon(Brushes.Red, fan1);
            graphic_fan.FillPolygon(Brushes.Red, fan2);
            graphic_fan.FillPolygon(Brushes.Red, fan3);

            graphic_fan.TranslateTransform(430, 0);
            graphic_fan.ScaleTransform(1.7f, 1.7f);


            graphic_fan.FillPolygon(Brushes.Red, fan1);
            graphic_fan.FillPolygon(Brushes.Red, fan2);
            graphic_fan.FillPolygon(Brushes.Red, fan3);
        }

        private void drawCar()
        {
            graphic_car.FillRectangle(Brushes.Red, 565, 457, 160, 45);
            graphic_car.FillRectangle(Brushes.Red, 530, 502, 330, 75);

            graphic_car.FillEllipse(Brushes.Black, 550, 577, 100, 100);
            graphic_car.FillEllipse(Brushes.White, 562, 589, 75, 75);

            graphic_car.FillEllipse(Brushes.Black, 750, 577, 100, 100);
            graphic_car.FillEllipse(Brushes.White, 762, 589, 75, 75);

            graphic_car.TranslateTransform(2, 0);
        }

        private void initializeObjects()
        {
            // Initialize Main Graphic Objects
            graphic = this.CreateGraphics();
            graphic_fan = this.CreateGraphics();
            graphic_car = this.CreateGraphics();
        }
    }
}
