using System;
using System.Collections.Generic;
using System.Text;
using Vending_Machine.Data;

namespace Vending_Machine.Model
{
    class PokemonCard : Products
    {
        public new void Use()
        {
            Console.WriteLine("Reading stats on Pokemon card");
        }
    }
}
