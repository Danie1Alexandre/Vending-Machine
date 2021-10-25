using System;
using System.Collections.Generic;
using System.Text;


namespace Vending_Machine.Model
{
    class Soda : Products
    {

        public new void Use()
        {
            Console.WriteLine("Drinking the soda");
        }


    }
}
