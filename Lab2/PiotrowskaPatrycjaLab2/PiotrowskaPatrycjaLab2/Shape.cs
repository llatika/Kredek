using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiotrowskaPatrycjaLab2
{
    public abstract class Shape
    {
        //pole
        protected float size;
        /// <summary>
        /// Abstract method
        /// </summary>
        /// <returns></returns>
        public abstract float Area();
        public virtual string Perimeter()
        {
            System.Windows.Forms.MessageBox.Show("Tutaj klasa bazowa");
            return "bazowa";
        }
    }

}
