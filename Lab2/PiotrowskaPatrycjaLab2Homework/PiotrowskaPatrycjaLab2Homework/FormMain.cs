using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiotrowskaPatrycjaLab2Homework
{
    public partial class FormMain : Form
    {
        List<Recipemain> Biorecipes = new List<Recipemain>();
        List<Recipemain> recipe = new List<Recipemain>();

        public FormMain()
        {
            InitializeComponent();

            recipe.Add(new Recipemain("nazwa", 34, 3, true));
            recipe.Add(new Dinner("Bigos", 15, 2, true));
            recipe.Add(new Supper("nazwa", 10, 0.25F, true));
            recipe.Add(new Breakfast("Bigos", 15, 2, true));
        }


        private void ButtonBio_Click(object sender, EventArgs e)
        {
            foreach (Recipemain rec in Biorecipes)
            {
                if (rec.bio==true)
                {

                    Biorecipes.Add(rec);
                }
            }

            FormMain2 f = new FormMain2(Biorecipes);
            this.Visible = false;
            f.ShowDialog();
            //this.Close();
          
            
        }

        private void ButtonNotBio_Click(object sender, EventArgs e)
        {
            foreach (Recipemain rec in Biorecipes)
            {
                if (rec.bio == false)
                {

                    Biorecipes.Add(rec);
                }
            }

            FormMain2 f = new FormMain2(Biorecipes);
            this.Visible = false;
            f.ShowDialog();
            this.Close();
        }
    }
    
}
