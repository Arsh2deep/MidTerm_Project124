using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm_Project124
{
    public abstract class Drinks : Product
    {
        public enum Size
        {
            Short,
            Tall,
            Grande,
            Venti,
            Trenta
        }

        public Size DrinkSize { get; }

        protected Drinks(string name, double price, int points, Size drinkSize) : base(name, price, points)
        {
            DrinkSize = drinkSize;
        }

    }//Class

}//NameSpace
