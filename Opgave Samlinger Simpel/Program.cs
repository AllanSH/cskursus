using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_Samlinger_Simpel
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Transaction> liste = new List<Transaction>();
            liste.Add(new Transaction() { TradeId = "1234567890", Amount = -1500 });
            liste.Add(new Transaction() { TradeId = "2345678901", Amount = 5000 });
            liste.Add(new Transaction() { TradeId = "3456789012", Amount = 200000 });
            
            foreach (var item in liste)
            {
                Console.WriteLine($"Udskriv TradeId: {item.TradeId} Amount {item.Amount}");
            }

            Dictionary<int, Transaction > diction1 = new Dictionary<int,Transaction>();
            diction1.Add(1, new Transaction() { TradeId = "1234567890", Amount = -1500 });
            diction1.Add(2, new Transaction() { TradeId = "2345678901", Amount = 5000 });
            diction1.Add(3, new Transaction() { TradeId = "3456789012", Amount = 200000 });

            foreach (var item in diction1)
            {
                Console.WriteLine($"Udskriv diction1: {item.Value.TradeId} Amount: {item.Value.Amount} Key: {item.Key}");
            }

        }
    }

    class Transaction
    {
        public String TradeId { get; set; }
        public int Amount { get; set; }
    }
}
