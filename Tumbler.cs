using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm_Project124
{
    public class Tumbler : Merchandise
    {
        public string Color { get; }

        public Tumbler(string name, double price, int points, string color) : base(name, price, points)
        {
            Color = color;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Color: {Color}";
        }

    }//Class

}//NameSpace
