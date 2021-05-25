using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace final_ase_comp2_gauravkharel
{
    /// <summary>
    /// concrete Rectangle Class
    /// </summary>
    public class Rectangle : Shape
    {


        public int x, y, width, height;

        /// <summary>
        /// initializing the value of variables width and height 
        /// </summary>
        public Rectangle() : base()
        {
            width = 0;
            height = 0;
        }
        /// <summary>
        /// the current instance of the class
        /// </summary>
        /// <param name="x">X-axis in the canvas</param>
        /// <param name="y">Y-axis in the canvas </param>
        /// <param name="width">width of the rectangle</param>
        /// <param name="height">height of the rectangle</param>
        public Rectangle(int x, int y, int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        /// <summary>
        /// Graphics class to inherit shape to the main form to draw Rectangle
        /// with, exceptional handling
        /// </summary>
        /// <param name="g"></param>
        public void draw(Graphics g)
        {
            try
            {
                Pen p = new Pen(Color.Black, 2); 
                g.DrawRectangle(p, x - (width / 2), y - (height / 2), width * 2, height * 2);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// to handle exception when parameter value exceeds
        /// </summary>
        /// <param name="list">refers to array of the pararameters</param>
        public void set(params int[] list)
        {
            try
            {
                this.x = list[0];
                this.y = list[1];
                this.width = list[2];
                this.height = list[3];
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}