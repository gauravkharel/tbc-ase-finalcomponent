using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_ase_comp2_gauravkharel
{
    interface Shape
    {
        /// <summary>
        /// The interface method used for drawing shapes
        /// </summary>
        /// <param name="g">refrencing interface method</param>
        void draw(Graphics g);

        void set(params int[] list);
    }
}
