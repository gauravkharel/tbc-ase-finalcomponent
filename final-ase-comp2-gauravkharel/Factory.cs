using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_ase_comp2_gauravkharel
{
    class Factory : Creator
    {
        public override Shape getShape(string shapeType)
        {

            shapeType = shapeType.ToLower().Trim();
            if (shapeType.Equals("line"))
            {
                return new Line();
            }
            else if (shapeType.Equals("rectangle"))
            {
                return new Rectangle();
            }
            else
            {
                System.ArgumentException argEx = new System.ArgumentException("Factory error: " + shapeType + " does not exist");
                throw argEx;
            }
        }
    }
}

