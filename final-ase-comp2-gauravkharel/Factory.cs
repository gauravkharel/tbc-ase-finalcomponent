using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_ase_comp2_gauravkharel
{
    class Factory : Creator
    {
        /// <summary>
        /// Using Factory Pattern to correlate different shapes concrete class to main form
        /// </summary>
        /// <param name="shapeType">The shape of the object</param>
        /// <returns></returns>
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
            else if (shapeType.Equals("circle"))
            {
                return new Circle();
            }
            else if (shapeType.Equals("triangle"))
            {
                return new Triangle();
            }
            else
            {
                //Exception Handling
                System.ArgumentException argEx = new System.ArgumentException("Factory error: " + shapeType + " does not exist");
                throw argEx;
            }
        }
    }
}

