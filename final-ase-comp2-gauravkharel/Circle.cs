using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_ase_comp2_gauravkharel
{
    /// <summary>
    /// the concrete class for Circle 
    /// </summary>
    public class Circle : Shape
    {

        public int x, y, radius;

        public Circle() : base()
        {
        }

        /// <summary>
        /// the concrete class for Circle shape
        /// </summary>
        /// <param name="x">width</param>
        /// <param name="y">height</param>
        /// <param name="radius">radius of the circle</param>
        public Circle(int x, int y, int radius)
        {
            this.radius = radius;
        }

        /// <summary>
        /// Graphics class to inherit shape to the main form to draw Circle
        /// with, exceptional handling
        /// </summary>
        /// <param name="g"></param>
        public void draw(Graphics g)
        {
            try
            {
                Pen p = new Pen(Color.Black, 2);
                g.DrawEllipse(p, x - radius, y - radius, radius * 2, radius * 2);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// to handle the exception when user don't input the 
        /// variable as shown
        /// </summary>
        /// <param name="list"></param>
        public void set(params int[] list)
        {
            try
            {
                this.x = list[0];
                this.y = list[1];
                this.radius = list[2];
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}