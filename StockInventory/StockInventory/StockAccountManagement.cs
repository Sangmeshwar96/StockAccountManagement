using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StockInventory
{
    class StockAccountManagement
    {
        double amount = 100;
        List<StockDetails> stock = new List<StockDetails>();
        List<StockDetails> customer = new List<StockDetails>();
        public void ReadStockJsonFile(string filePath)
        {
            var json = File.ReadAllText(filePath);
            this.stock = JsonConvert.DeserializeObject<List<StockDetails>>(json);
            foreach(var content in stock)
            {
                //Console.WriteLine(content.StockName+" "+content.StockPrice+" "+content.NoOfShares);
                Console.WriteLine("{0}" + "\t" + "{1}" + "\t" + "{2}", content.StockName, content.StockPrice, content.NoOfShares);
            }
        }
        public void ReadCustomerJsonFile(string filePath)
        {
            var json = File.ReadAllText(filePath);
            this.customer = JsonConvert.DeserializeObject<List<StockDetails>>(json);
            foreach (var content in customer)
            {
                //Console.WriteLine(content.StockName + " " + content.StockPrice + " " + content.NoOfShares);
                Console.WriteLine("{0}" + "\t" + "{1}" + "\t" + "{2}" + "\t\t" + "{3}", content.StockName, content.StockPrice, content.NoOfShares, content.NoOfShares * content.StockPrice);
            }
        }
    }
}
