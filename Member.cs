using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm_Project124
{
    public abstract class Member
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int MemberNumber { get; }
        public int Points { get; protected set; }
        public DateTime MemberSince { get; }
        public ObservableCollection<Product> PreviousTransactions { get; }

        public Member(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            MemberNumber = new Random().Next(1000000, 10000000);
            Points = 0;
            MemberSince = DateTime.Now;
            PreviousTransactions = new ObservableCollection<Product>();
        }

        public abstract void DeductPoints(Product product);
        public abstract void AddPoints(Product product);

        public void AddProduct(Product product)
        {
            PreviousTransactions.Add(product);
        }

        public override string ToString()
        {
            return $"{GetType().Name} - {FirstName} {LastName} - Points: {Points} - Member Number: {MemberNumber}";
        }

    }//Class

}//NameSpace
