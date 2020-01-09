using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiotrowskaPatrycjaLab2
{
    /// <summary>
    /// Nowa klasa dziedzicząca po Shape()
    /// </summary>
    public class Square:Shape, IResizable
    {
        /// <summary>
        /// Konstruktor 
        /// </summary>
        /// <param name="size"></param>
        public Square(float size=1)
        {
            this.size = size;
        }
        /// <summary>
        /// Zmienna area przyporzadkowuje pole kwadratu 
        /// </summary>
        /// <returns></returns>
        public override float Area()
        {
            return size * size;
        }
        /// <summary>
        /// Wywolywanie dwoch okien, ktore podaja wartosci podane przez uzytkownika
        /// </summary>
        public void ChangeSize()
        {
            string input=Prompt.ShowDialog("Zmien dlugosc boku","Podaj nowa dlugosc boku");
            size = float.Parse(input);
        }

        /// <summary>
        /// WYbor nazwy ksztaltu Kawadrat z listy wybieralnej Combobox
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Kwadrat";
        }
       
    }
}
