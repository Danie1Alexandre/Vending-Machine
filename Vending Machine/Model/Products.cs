using System;
using System.Collections.Generic;
using System.Text;
using Vending_Machine.Data;

namespace Vending_Machine.Model
{
    abstract class Products
    {
        string productName;
        int productPrice;
 

        public void Examine()
        {
            Console.WriteLine(productName + ": " + productPrice + "kr");
        }

        public void Use()
        {
            Console.WriteLine("productBehaviour");
        }

        public int Price
        {
            get { return productPrice; }
            set { productPrice = value; }
        }
        public string Name
        {
            get { return productName; }
            set { productName = value; }
        }

    }


}
