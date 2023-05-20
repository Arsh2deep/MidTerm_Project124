using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm_Project124
{
    public static class Data
    {


        //fields
        private static readonly ObservableCollection<Member> memberCollection;
        private static readonly ObservableCollection<Product> productCollection;
        private static Product currentProduct;
        private static Member currentMember;

        //constructor
        static Data()
        {
            memberCollection = new ObservableCollection<Member>();
            productCollection = new ObservableCollection<Product>();
        }

        //properties
        public static ObservableCollection<Member> MemberCollection => memberCollection;
        public static ObservableCollection<Product> ProductCollection => productCollection;
        public static Product CurrentProduct => currentProduct;
        public static Member CurrentMember => currentMember;

        //methods
        public static void AddProductToCollection(Product product)
        {
            productCollection.Add(product);
        }

        public static void AddMemberToCollection(Member member)
        {
            memberCollection.Add(member);
        }

        public static void UpdateCurrentProduct(Product product)
        {
            currentProduct = product;
        }

        public static void UpdateCurrentMember(Member member)
        {
            currentMember = member;
        }
    }
}
