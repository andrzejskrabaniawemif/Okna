using Okna.Forms;
using Okna.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DietCalc.Classes
{
    public class Macronutritions
    {
        public decimal protein { get; set; }
        public decimal fat { get; set; }
        public decimal carbo { get; set; }

        public Macronutritions(decimal CPM, decimal target, int macro)
        {
            this.protein = CalcProtein(CPM, target, macro);
            this.fat = CalcFat(CPM, target, macro);
            this.carbo = CalcCarbo(CPM, target, macro);
        }

        

        public decimal CalcProtein(decimal CPM, decimal target, int macro)
        {
            if (macro == 0)
            {
                return ((CPM * target) / 3)*0.2M;
            }
            else
            {
                return ((CPM * target) / 3) * 0.4M;
            }
        }
         
        public decimal CalcFat(decimal CPM, decimal target, int macro)
        {
            if (macro == 1)
            {
                return ((CPM * target) / 7)*0.3M;
            }
            else
            {
                return ((CPM * target) / 7) * 0.4M;
            }
        }

        public decimal CalcCarbo(decimal CPM, decimal target, int macro)
        {
            if (macro == 2)
            {
                return ((CPM * target) / 7) * 0.5M;
            }
            else
            {
                return ((CPM * target) / 7) * 0.2M;
            }
        }
    }

    
}