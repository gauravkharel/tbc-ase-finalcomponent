using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_ase_comp2_gauravkharel
{
    /// <summary>
    /// abstract class for adding shapes to the main class
    /// </summary>
    abstract class Creator
    {
        /// <summary>
        /// the abstract class Shape is to implement simplicity as Factory Design Pattern work
        /// </summary>
        /// <param name="ShapeType">The shape of the object</param>
        /// <returns></returns>
        public abstract Shape getShape(string ShapeType);

    }
}
