﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiotrowskaPatrycjaLab2Homework
{
    public class Breakfast : Recipemain
    {
        public Breakfast(string nameRec, int price, float time, bool bio) : base(nameRec, price, time, bio) { }

        public override string ToString()
        {
            return "Sniadanie";
        }
    }
}
