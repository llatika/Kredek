using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiotrowskaPatrycjaLab2
{  
    
    /// <summary>
    /// Klasa Circle dziedzicząca po klasie Shape
    /// </summary>
    public class Circle:Shape
    {
        /// <summary>
        /// Konstruktor dla klasy Circle.
        /// </summary>
        /// <param name="size"></param>
        public Circle(float size=1)
        {
            this.size = size;
        }
        /// <summary>
    /// Obliczanie pola kola
    /// </summary>
    /// <returns></returns>
        public override float Area()     //Nadpisanie funkcji Area() w Shape()
        {
            float area = 3.1415F * size * size;
            return area;
           // throw new NotImplementedException();)
        
        }/// <summary>
        /// Zwracanie nazwy koła ,zamiast domyslnie nazwy klasy
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Koło";
        }
        /// <summary>
        /// Obwod kola
        /// </summary>
        /// <returns></returns>
        public override string Perimeter()
        {
            base.Perimeter();
            float area = 3.1415F * 2 * size;
            return area.ToString();
        }
    }
}
