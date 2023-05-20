using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm_Project124
{
    public class GoldMember : Member
    {
        public GoldMember(string firstName, string lastName) : base(firstName, lastName) { }

        public override void DeductPoints(Product product)
        {
            Points -= product.Points / 2 - 50;
        }

        public override void AddPoints(Product product)
        {
            Points += product.Points + 50;
        }

    }//Class

}//NameSpace
