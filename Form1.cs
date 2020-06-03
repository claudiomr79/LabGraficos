using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabGraficos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //protected override void OnPaint(PaintEventArgs paintEvnt)
        //{
        //    // Get the graphics object 
        //    Graphics gfx = paintEvnt.Graphics;
        //    // Create a new pen that we shall use for drawing the line 
        //    Pen myPen = new Pen(Color.Black);
        //    // Loop and create a new line 10 pixels below the last one 
        //    for (int i = 20; i < 250; i = i + 10)
        //    {
        //        gfx.DrawLine(myPen, 20, i, 270, i);
        //    }
        //}
        //lineas verticales
        //protected override void OnPaint(PaintEventArgs paintEvnt)
        //{
        //    // Get the graphics object 
        //    Graphics gfx = paintEvnt.Graphics;
        //    // Create a new pen that we shall use for drawing the line 
        //    Pen myPen = new Pen(Color.Black);
        //    // Loop and create a horizontal line 10 pixels below the last one 
        //    for (int i = 5; i <= 250; i = i + 10)
        //    {
        //        gfx.DrawLine(myPen, 20, i, 270, i);
        //    }
        //    // Loop and create a vertical line 10 pixels next to the last one 
        //    for (int x = 20; x < 280; x = x + 10)
        //    {
        //        gfx.DrawLine(myPen, x, 20, x, 250);
        //    }
        //}
        //protected override void OnPaint(PaintEventArgs paintEvnt)
        //{
        //    // Get the graphics object 
        //    Graphics gfx = paintEvnt.Graphics;
        //    // Create a new pen that we shall use for drawing the line 
        //    Pen myPen = new Pen(Color.Black);

        //    // Loop until the coordinates reach 250 (the lower right corner of the form) 
        //    for (int i = 0; i < 250; i = i + 50)
        //    {
        //        // Draw a 50x50 pixels rectangle 
        //        gfx.DrawRectangle(myPen, i, i, 50, 50);
        //    }
        //}

        protected override void OnPaint(PaintEventArgs paintEvnt)
        {
            // Get the graphics object 
            Graphics gfx = paintEvnt.Graphics;
            int x1 = 0;
            int y1 = 0;

            // Loop trough the 255 values red can have 
            for (int i = 0; i <= 255; i++)
            {
                // Create new brush with a defined color 
                Color brushColor = Color.FromArgb(i, 0, 0);
                // The brush is solid because we want a solid rectangle 
                SolidBrush myBrush = new SolidBrush(brushColor);
                // Actually draw the rectangle 
                gfx.FillRectangle(myBrush, x1, y1, 10, 10);
                // The next rectangle should be near the last one 
                x1 = x1 + 10;
                // If the row is complete start another one 
                if ((x1 % 290) == 0)
                {
                    y1 = y1 + 10;
                    x1 = 0;
                }
            }

            for (int i = 0; i <= 255; i++)
            {
                Color brushColor = Color.FromArgb(0, i, 0);
                SolidBrush myBrush = new SolidBrush(brushColor);
                gfx.FillRectangle(myBrush, x1, y1, 10, 10);
                x1 = x1 + 10;
                if ((x1 % 290) == 0)
                {
                    y1 = y1 + 10;
                    x1 = 0;
                }
            }

            for (int i = 0; i <= 255; i++)
            {
                Color brushColor = Color.FromArgb(0, 0, i);
                SolidBrush myBrush = new SolidBrush(brushColor);
                gfx.FillRectangle(myBrush, x1, y1, 10, 10);
                x1 = x1 + 10;
                if ((x1 % 290) == 0)
                {
                    y1 = y1 + 10;
                    x1 = 0;
                }
            }
        }


    }
}
