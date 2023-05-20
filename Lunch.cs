using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm_Project124
{
    public class Lunch : Food
    {
        public bool IsCombo { get; }

        public Lunch(string name, double price, int points, bool isHeated, bool isCombo) : base(name, price, points, isHeated)
        {
            IsCombo = isCombo;
        }

        public override string ToString()
        {
            return base.ToString() + " - Is Combo: " + IsCombo;
        }

    }//Class

}//NameSpace
