using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm_Project124
{

    public class Breakfast : Food
    {
        public bool HasDairy { get; }

        public Breakfast(string name, decimal price, int points, bool isHeated, bool hasDairy) : base(name, price, points, isHeated)
        {
            HasDairy = hasDairy;
        }

        public override string ToString()
        {
            return base.ToString() + " - Has Dairy: " + HasDairy;
        }

    }//Class

}//NameSpace
