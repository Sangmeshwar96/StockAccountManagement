using System;

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
            Console.WriteLine("\nList Of All Company Stock :");
            management.ReadStockJsonFile(stockFilePath);
            Console.WriteLine("\nList Of All Company Stock Customer Have :");
            management.ReadCustomerJsonFile(customerFilePath);
            management.BuyStock("Flipkart");
            management.WriteToStockJsonFile(stockFilePath);
            management.WriteToCusatomerJsonFile(customerFilePath);

        }
    }
}