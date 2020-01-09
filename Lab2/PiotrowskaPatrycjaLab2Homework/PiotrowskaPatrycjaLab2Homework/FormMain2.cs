using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PiotrowskaPatrycjaLab2Homework;


namespace PiotrowskaPatrycjaLab2Homework
{


    public partial class FormMain2 : Form
    {

        private List<Recipemain> recipe;
        private List<Recipemain> recipechoosenlist = new List<Recipemain>();
        

        public FormMain2(List<Recipemain> list)
        {

            InitializeComponent();
            recipe = list;
           
            int price0 = 5;
            comboBoxPrice.Items.Add(price0);
            int price1 = 10;
            comboBoxPrice.Items.Add(price1);
            int price2 = 15;
            comboBoxPrice.Items.Add(price2);
            int price3 = 20;
            comboBoxPrice.Items.Add(price3);
            int price4 = 25;
            comboBoxPrice.Items.Add(price4);
            int price5 = 30;
            comboBoxPrice.Items.Add(price5);
            string price6 = "More than 30";
            comboBoxPrice.Items.Add(price6);


            float time0 = 0.25F;
            comboBoxTime.Items.Add(time0);
            float time1 = 0.5F;
            comboBoxTime.Items.Add(time1);
            float time2 = 1.0F;
            comboBoxTime.Items.Add(time2);
            float time3 = 1.5F;
            comboBoxTime.Items.Add(time3);
            float time4 = 2.0F;
            comboBoxTime.Items.Add(time4);
            float time5 = 3F;
            comboBoxTime.Items.Add(time5);
            string time6 = "More than 3";
            comboBoxTime.Items.Add(time6);

           
        }

        private void ComboBoxPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
           //recipe = (Recipemain)comboBoxPrice.SelectedItem;
           foreach(Recipemain rec in recipe)
            {
                if(comboBoxPrice.SelectedItem != null && comboBoxPrice.SelectedItem.Equals(rec.PriceRecipe))
                { 
                    recipechoosenlist.Add(rec);
                }
            }
            comboBoxTime.Visible = true;
            
        }
       
        private void ComboBoxTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Recipemain rec in recipechoosenlist)
            {
                if (comboBoxTime.SelectedItem != null && !comboBoxTime.SelectedItem.Equals(rec.TimeRecipe))
                {
                  
                    recipechoosenlist.Remove(rec);
                }
            }
            pictureBoxBreakfast.Visible = true;
            pictureBoxDinner.Visible = true;
            pictureBoxSupper.Visible = true;



        }

      

        private void PictureBoxSupper_Click(object sender, EventArgs e)
        {
            pictureBoxSupper.MouseClick += new MouseEventHandler((o, a)=>
           {
               textBoxFinishList.Text = " ";
               if (recipechoosenlist != null)
               {
                   foreach (Recipemain res in recipechoosenlist)
                   {
                       if (res.ToString() == "Kolacja")
                       {
                           textBoxFinishList.Text += res.NameRecipe + "\r\n";
                       }
                   }
               }
               else
               {
                   MessageBox.Show("Nie ma takiego zarcia");
               }
           });
        }

    

        //private void PictureBoxDinner_Click(object sender, EventArgs e)
        //{
        //    textBoxFinishList.Text = " ";
        //    if (recipechoosenlist != null)
        //    {
        //        foreach (Recipemain res in recipechoosenlist)
        //        {
        //            if (res.ToString() == "Obiad")
        //            {
        //                textBoxFinishList.Text += res.NameRecipe + "\r\n";
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Nie ma takiego zarcia");
        //    }
        //}

        private void PictureBoxBreakfast_Click(object sender, EventArgs e)
        {
            textBoxFinishList.Text = " ";
            if (recipechoosenlist != null)
            {
                foreach (Recipemain res in recipechoosenlist)
                {
                    if (res.ToString() == "Sniadanie")
                    {
                        textBoxFinishList.Text += res.NameRecipe + "\r\n";
                    }
                }
            }
            else
            {
                MessageBox.Show("Nie ma takiego zarcia");
            }
        }

        private void PictureBoxDinner_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxFinishList.Text = " ";
            if (recipechoosenlist != null)
            {
                foreach (Recipemain res in recipechoosenlist)
                {
                    if (res.ToString() == "Obiad")
                    {
                        textBoxFinishList.Text += res.NameRecipe + "\r\n";
                    }
                }
            }
            else
            {
                MessageBox.Show("Nie ma takiego zarcia");
            }
        }
    }
}



    