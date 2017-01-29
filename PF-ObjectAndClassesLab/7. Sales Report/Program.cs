using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Sales_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            Sale[] sale = ReadSales();

            var towns = sale.Select(s => s.Town).Distinct().OrderBy(t => t);
            foreach (var town in towns)
            {
                double salesInTown = sale.Where(s => s.Town == town).Select(s => s.price * s.quantity).Sum();
                Console.WriteLine("{0} -> {1:f2}", town, salesInTown);
            }
        }
        static Sale ReadSale()
        {
            string[] items = Console.ReadLine().Split();
            return new Sale() { Town = items[0], product = items[1], price = double.Parse(items[2]), quantity = double.Parse(items[3]) };

        }
        static Sale[] ReadSales()
        {
            int n = int.Parse(Console.ReadLine());
            Sale[] sales = new Sale[n];
            for (int i = 0; i < n; i++)
            {
                sales[i] = ReadSale();
            }
            return sales;
        }


    }
    class Sale
    {
        public string Town { get; set; }
        public string product { get; set; }
        public double price { get; set; }
        public double quantity { get; set; }

    }
}



