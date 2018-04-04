﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;



namespace Geometry
{
    class Square : MyDraw
    {
        private int x, y, sidelength;

        public Square (int x, int y, int sidelength)
        {
            this.x = x;
            this.y = y;
            this.sidelength = sidelength;
        }

        public override void Draw(Graphics graphics)
        {
            Pen myPen = new Pen(Color.Coral, 3.0F);
            graphics.DrawRectangle(myPen, x, y, sidelength, sidelength);
        }
    }
}