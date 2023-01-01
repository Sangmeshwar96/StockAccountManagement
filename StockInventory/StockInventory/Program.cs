using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;
using System;
using System.Collections;

namespace StockInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Welcome to Stock Inventory Management---");
            string stockFilePath = @"C:\Users\hp\source\repos\StockInventory\StockInventory\Stock.json";
            string customerFilePath = @"C:\Users\hp\source\repos\StockInventory\StockInventory\Customer.json";
            StockAccountManagement management = new StockAccountManagement();
            while(true)
            {
                Console.WriteLine("\nEnter Any One Option For Info And Trade :\n" + "1.List Of All Company Stock\n" + "2.List Of All Company Stock Customer Have\n" + "3.Buy Share\n" + "4.Sell Share\n" + "5.Exit\n");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("\nList Of All Company Stock :");
                        management.ReadStockJsonFile(stockFilePath);
                        break;
                    case 2:
                        Console.WriteLine("\nList Of All Company Stock Customer Have :");
                        management.ReadCustomerJsonFile(customerFilePath
                            );
                        break;
                    case 3:
                        management.BuyStock("Flipkart");
                        management.WriteToStockJsonFile(stockFilePath);
                        management.WriteToCusatomerJsonFile(customerFilePath);
                        break;
                    case 4:
                        management.SellStock("Flipkart");
                        management.WriteToStockJsonFile(stockFilePath);
                        management.WriteToCusatomerJsonFile(customerFilePath);
                        break;
                    case 5:
                        Console.WriteLine("Thank You For Trading.");
                        break;
                }
                if (option == 5)
                    break;
            }




            //Console.WriteLine("\nList Of All Company Stock :");
            //management.ReadStockJsonFile(stockFilePath);
            //Console.WriteLine("\nList Of All Company Stock Customer Have :");
            //management.ReadCustomerJsonFile(customerFilePath);
            //management.BuyStock("Flipkart");
            //management.WriteToStockJsonFile(stockFilePath);
            //management.WriteToCusatomerJsonFile(customerFilePath);



        }
    }
}