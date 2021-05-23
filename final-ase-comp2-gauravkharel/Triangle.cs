using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_ase_comp2_gauravkharel
{
    public class Triangle : Shape
    {


        public int x, y, width, height;


        public Triangle() : base()
        {
            width = 0;
            height = 0;
        }

        public Triangle(int x, int y, int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void draw(Graphics g)
        {
            try
            {
                Pen p = new Pen(Color.Black, 2); 
                             
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

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