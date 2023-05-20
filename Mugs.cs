using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm_Project124
{
    public class Mugs : Merchandise
    {
        private string design;

        public Mugs(string name, double price, int points, string design) : base(name, price, points)
        {
            this.design = design;
        }

        // Override ToString
        public override string ToString()
        {
            return base.ToString() + " - Design: " + design;
        }

    }//Class

}//NameSpace
