using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiotrowskaPatrycjaLab2
{
    public partial class FormMain : Form
    {
        private Shape shape;  //WYbor z listy kształtu
        public FormMain()
        {
            InitializeComponent();
            Circle circle = new Circle();
            Square square = new Square();
            comboBoxShape.Items.Add(circle);
            comboBoxShape.Items.Add(square);
        }
        /// <summary>
        /// Wyswietlanie wartosci pola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonArea_Click(object sender, EventArgs e)
        {
            if (comboBoxShape.SelectedIndex != -1)
                textBoxArea.Text = shape.Area().ToString();
            else MessageBox.Show("Nie wybrano wartości");
        }
        /// <summary>
        /// Wynik dzialania wyboru parametru z listy wybieralnej combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            shape = (Shape)comboBoxShape.SelectedItem;
        }
        /// <summary>
        /// Funkcja do zmiany ksztalu figury innej niz kolo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChangeSize_Click(object sender, EventArgs e)
        {
            if(shape is IResizable)
            {
                IResizable resizable = (IResizable)shape;
                resizable.ChangeSize();
            }
            else
            {
                MessageBox.Show("Nie mozna zmienic rozmiaru okregu");
            }
        }

        private void buttonObwod_Click(object sender, EventArgs e)
        {
            textBoxPerimeter.Text = shape.Perimeter();
        }

        
    }
}
