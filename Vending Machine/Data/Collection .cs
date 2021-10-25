using System;
using System.Collections.Generic;
using System.Text;
using Vending_Machine.Model;

namespace Vending_Machine.Data
{
    class Collection : Products
    {
        private Products[] productCollection = new Products[3];


        public Products[] ProductCollection
        {
            get { return productCollection; }
            set { productCollection = value; }
        }

        public Products[] findProducts()
        {
            return productCollection;
        }



    }
}
