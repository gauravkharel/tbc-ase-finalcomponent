using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_ase_comp2_gauravkharel
{
    public class Line : Shape
    {
        // passing values to intiated variable as x for x-axis 
        // and y for y-axis
        public int x, y, toX, toY;

        public Line() : base()
        {

        }

        public Line(int x, int y, int toX, int toY)
        { }


        //implement drawing elements
        public void draw(Graphics g)
        {
            try
            {
                Pen p = new Pen(Color.Black, 2);
                g.DrawLine(p, x, y, toX, toY);
            }
            catch (Exception exception)
            {

                throw exception;
            }
        }

        public void set(params int[] list)
        {
            this.x = list[0];
            this.y = list[1];
            this.toX = list[2];
            this.toY = list[3];
        }
    }
}
