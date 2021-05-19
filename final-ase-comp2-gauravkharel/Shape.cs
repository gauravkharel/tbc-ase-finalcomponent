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
        void draw(Graphics g);

        void set(params int[] list);
    }
}
