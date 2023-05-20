using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm_Project124
{
    public abstract class Food : Product
    {
        public bool IsHeated { get; }

        protected Food(string name, double price, int points, bool isHeated) : base(name, price, points)
        {
            IsHeated = isHeated;
        }

    }//Class

}//NameSpace
