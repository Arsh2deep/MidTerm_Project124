using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm_Project124
{
    public class GiftCard : Product
    {
        public decimal Amount { get; }

        public GiftCard(string name, double price, int points, decimal amount) : base(name, price, points)
        {
            Amount = amount;
        }

        public override string ToString()
        {
            return base.ToString() + " - Amount: $" + Amount;
        }

    }//Class

}//NameSpace
