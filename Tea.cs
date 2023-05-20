using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm_Project124
{
    public class Tea : Drinks
    {
        public string TeaType { get; }

        public Tea(string name, double price, int points, Size drinkSize, string teaType) : base(name, price, points, drinkSize)
        {
            TeaType = teaType;
        }

        public override string ToString()
        {
            return base.ToString() + " - Tea Type: " + TeaType;
        }

    }//Class

}//NameSpace
