using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm_Project124
{
    public class Coffee : Drinks
    {
        public string RoastType { get; }

        public Coffee(string name, decimal price, int points, Size drinkSize, string roastType) : base(name, price, points, drinkSize)
        {
            RoastType = roastType;
        }

        public override string ToString()
        {
            return base.ToString() + " - Roast Type: " + RoastType;
        }

    }//Class

}//NameSpace
