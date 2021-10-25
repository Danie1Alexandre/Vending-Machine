using System;
using System.Collections.Generic;
using System.Text;
using Vending_Machine.Data;

namespace Vending_Machine.Model
{
    

    class VendingMachine : IVending
    {
        Collection showList = new Collection();
        
        private readonly int[] arrayPrice = { 1, 5, 10, 20, 50, 100, 500, 1000 };
        private int moneyPool;
        private int userInput;


        public int MoneyPool
        {
            get { return moneyPool; }
            set { moneyPool = value; }
        }

        public int UserInput
        {
            get { return userInput; }
            set { userInput = value; }
        }

        public int TypeNumber()
        {
            userInput = Convert.ToInt32(Console.ReadLine());
            return userInput;
        }

        public int InsertMoney()
        {
            int userMoneyInput;
            int acceptedValue = 0;

            while (true)
            {
                userMoneyInput = TypeNumber();
                for (int i = 0; i < arrayPrice.Length; i++)
                {
                    if (userMoneyInput == arrayPrice[i])
                    {
                        acceptedValue = arrayPrice[i];
                    }
                }
                if (acceptedValue == userMoneyInput)
                {
                    moneyPool += acceptedValue;
                    break;
                }
                else
                    Console.WriteLine("Insert valid denominations : ");
            }
            return moneyPool;
        }

        public void Purchase(int price)
        {
            moneyPool -= price;
        }

        public void ShowUserMooneyAmount()
        {
            Console.WriteLine("Your amount is: " + moneyPool);
        }

        public void EndTransaction()
        {

            Console.WriteLine("\nTransaktion ended ");
            if (0 < MoneyPool)
            {
                Console.WriteLine("Amount of change returned: " + moneyPool);
            }
        }

        public void ShowAll(Products[] collection)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(collection[i].Name);
            }
        }
    }
}
