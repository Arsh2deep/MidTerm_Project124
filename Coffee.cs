using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm_Project124
{
    public class Coffee : Product
    {
        public Coffee()
        {
            Name = "Coffee";
            Price = 2.0;
            Points = 1;
        }

        public override void Buy()
        {
            // Deduct the price from the customer's balance
            // Add points to the customer's membership account
        }
    }

    public class Tea : Product
    {
        public Tea()
        {
            Name = "Tea";
            Price = 1.5;
            Points = 1;
        }

        public override void Buy()
        {
            // Deduct the price from the customer's balance
            // Add points to the customer's membership account
        }
    }
    public class Pastry : Product
    {
        public Pastry()
        {
            Name = "Pastry";
            Price = 2.5;
            Points = 2;
        }

        public override void Buy()
        {
            // Deduct the price from the customer's balance
            // Add points to the customer's membership account
        }
    }

}
