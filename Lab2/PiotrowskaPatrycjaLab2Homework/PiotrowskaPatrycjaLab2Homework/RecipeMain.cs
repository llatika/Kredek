using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiotrowskaPatrycjaLab2Homework
{


    public class Recipemain
    {
        public string NameRecipe { get; set; }
        public int PriceRecipe { get; set; }
        public float TimeRecipe { get; set; }
        public bool bio {get;set;}

        public Recipemain(string nameRec, int price, float time, bool bio)
        {
            this.NameRecipe = nameRec;
            this.PriceRecipe = price;
            this.TimeRecipe = time;
            this.bio = bio;
           
        }

        



        //public void List()
        //{
        //    recipemains = new List<Recipemain>();
        //   //// recipemains.Add(new Recipemain("nazwa",))
        //    recipemains.Add(new Recipemain() { NameRecipe = "Lamb", PriceRecipe = 40, TimeRecipe = 2.5F, TasteRecipe = "salt", bio = true });
        //    recipemains.Add(new Recipemain() { NameRecipe = "Pork", PriceRecipe = 20, TimeRecipe = 1.5F, TasteRecipe = "salt" ,bio=false});
        //    recipemains.Add(new Recipemain() { NameRecipe = "Pancakes", PriceRecipe = 15, TimeRecipe = 2F, TasteRecipe = "sweet" });
        //    recipemains.Add(new Soup() { NameRecipe = "Tomato soup", PriceRecipe = 15, TimeRecipe = 4F, TasteRecipe = "salt" });
        //    recipemains.Add(new Recipemain() { NameRecipe = "Porridge", PriceRecipe = 6, TimeRecipe = 0.5F, TasteRecipe = "sweet" });
        //}

        //public void Searching()
        //{
        //    for(int i=0;i<5;i++)
        //        if()
        //}
    }

   

}

