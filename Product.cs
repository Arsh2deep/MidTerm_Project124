using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm_Project124
{
    public abstract class Product
    {
        //Fields
        public string Name { get; }
        public int Sku { get; }
        public double Price { get; }
        public int Points { get; }
        public static int NumberOfProducts { get; private set; }

        
        public Product(string name, double price, int points)
        {
            Name = name;
            Price = price;
            Points = points;
            
            Random rand = new Random();
            Sku = rand.Next(1000000, 10000000);

            NumberOfProducts++;

        }//Constructor

        
        public override string ToString()
        {
            return $"{GetType().Name} - Sku: {Sku} - Name: {Name} - Price: {Price:C} - Points: {Points}";
        }

    }//Class

}//NameSpace
