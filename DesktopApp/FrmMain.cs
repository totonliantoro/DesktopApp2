//***********************************************************************************************
//Programmer: Toton Liantoro
//Date: 13 October 2022
//Software: Microsoft Visual Studio 2022 Community Edition
//Platform: Microsoft Windows 11 64-bit
//Purpose: To complete the assignment 2 Subject: Apply Advance Object-Oriented Language Skills
//***********************************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment2_Toton
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.Width = 700;
            this.Height = 500;
            
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void FrmMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black); //paint exterior
            Brush myBrush = new SolidBrush(Color.Red); //paint interior
            Brush myBrush1 = new SolidBrush(Color.Cornsilk);
            Brush myBrush2 = new SolidBrush(Color.Blue);
            Brush myBrush3 = new SolidBrush(Color.Yellow);
            Brush myBrush4 = new SolidBrush(Color.DarkGreen);
            Font font1 = new Font("Arial", 18);

            g.DrawLine(myPen, 200, 200, 300, 150);
            g.DrawLine(myPen, 300, 150, 400, 200);
            g.DrawLine(myPen, 400, 200, 200, 200);
            g.DrawRectangle(myPen, 200, 200, 200, 100);
            g.DrawRectangle(myPen, 270, 260, 20, 40);
            Point point1 = new Point(201, 201);
            Point point2 = new Point(300, 150);
            Point point3 = new Point(400, 200);
            //PointF point4 = new PointF(50.0F, 150.0F);
            Point[] points1 = { point1, point2, point3 };
            g.FillPolygon(myBrush, points1);
            g.FillRectangle(myBrush1, 201, 200, 199, 100);
            g.FillRectangle(myBrush2, 270, 260, 19, 39);
            g.FillEllipse(myBrush3, 500, 80, 30, 30);
            g.DrawString("Welcome Back Home", font1, myBrush4,200,100);




        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDragDrop form2 = new FrmDragDrop();
            form2.ShowDialog();
        }

        private void btnExit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
