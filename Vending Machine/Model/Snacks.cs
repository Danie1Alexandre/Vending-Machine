using System;
using System.Collections.Generic;
using System.Text;


namespace Vending_Machine.Model
{
    class Snacks: Products
    {
        public new void Use()
        {
            Console.WriteLine("Eating chips");

        }
    }
}
