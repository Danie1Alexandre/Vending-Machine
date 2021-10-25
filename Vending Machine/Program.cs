using System;
using Vending_Machine.Model;
using Vending_Machine.Data;


namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vendingMachine = new VendingMachine();
            //creating objects
            Collection productList = new Collection();

            Soda cola = new Soda();
            cola.Price = 11;
            cola.Name = "Cola";
            productList.ProductCollection[0] = cola;

            Snacks PotatoChips = new Snacks();
            PotatoChips.Price = 15;
            PotatoChips.Name = "PotatoChips ";
            productList.ProductCollection[1] = PotatoChips;

            PokemonCard pikachu = new PokemonCard();
            pikachu.Price = 30;
            pikachu.Name = "Pokemoncard ";
            productList.ProductCollection[2] = pikachu;
            
            bool programRuning = true;

            while (programRuning == true)
            {


                Console.WriteLine("\n\tVending Machine\n-------------------------------");
                Console.WriteLine("  Choose a option between 1-4");
                Console.WriteLine("\t1: InsertMoney\n \t2: Show products\n  \t3: Purchase\n  \t4: EndTransaction\n ");
                vendingMachine.UserInput = vendingMachine.TypeNumber();

                switch(vendingMachine.UserInput)
                {
                    case 1:
                        Console.WriteLine("\nMachine accepts following denominations: 1kr, 5kr, 10kr, 20kr, 50kr, 100kr, 500kr and 1000kr");
                        Console.WriteLine("Insert amount of money to spend: ");
                        vendingMachine.InsertMoney();
                        vendingMachine.ShowUserMooneyAmount();
                        break;
                    
                    case 2:
                        Console.WriteLine("Available products products ");
                        vendingMachine.ShowAll(productList.ProductCollection);

                        break;

                    case 3:
                        Console.WriteLine("\nPick item 1-3 to Purchase");
                        Console.WriteLine("\n1. Cola\n2. Potato chips \n3. Pokemon card ");

                        vendingMachine.UserInput = vendingMachine.TypeNumber();
                        switch (vendingMachine.UserInput)
                        {
                            case 1:
                                if (11 < vendingMachine.MoneyPool)
                                {
                                    vendingMachine.Purchase(11);
                                    Console.WriteLine("\nYou bought a cola");
                                    cola.Use();
                                }
                                else
                                {
                                    Console.WriteLine($"can not afford product"); vendingMachine.ShowUserMooneyAmount();
                                }
                                break;
                            case 2:
                                if (15 < vendingMachine.MoneyPool)
                                {
                                    vendingMachine.Purchase(15);
                                    Console.WriteLine("\nYou bought Potato chips ");
                                    PotatoChips.Use();
                                }
                                else
                                {
                                    Console.WriteLine($"can not afford product"); vendingMachine.ShowUserMooneyAmount();
                                }
                                break;
                            case 3:
                                if (30 < vendingMachine.MoneyPool)
                                {
                                    vendingMachine.Purchase(30);
                                    Console.WriteLine("\nYou bought Pokemon card ");
                                    pikachu.Use();
                                }
                                else
                                {
                                    Console.WriteLine($"can not afford product"); vendingMachine.ShowUserMooneyAmount();
                                }
                                break;
                            default:
                                Console.WriteLine("Not a vaild option try again");
                                break;
                        } 
                        break;
                    case 4:
                        vendingMachine.EndTransaction();
                        programRuning = false;
                        break;

                    default:
                        Console.WriteLine("Not a vaild option try again");
                        break;
                }
            }

        }

    }
}
