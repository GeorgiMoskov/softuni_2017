using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7_AndreyBilliard
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> shopItemPrice = new Dictionary<string, decimal>();

            int barSize = int.Parse(Console.ReadLine());

            for(int i = 0; i < barSize; i++)
            {
                string[] inputLn = Console.ReadLine().Split('-');
                string inputItem = inputLn[0];
                decimal inputPrice = decimal.Parse(inputLn[1]);

                shopItemPrice[inputItem] = inputPrice;
            }

            List<Customer> customers = new List<Customer>();
            string inputLine = Console.ReadLine();

            while (inputLine!="end of clients")
            {
                string[] inputLineArr = inputLine.Split('-');
                string customerName = inputLineArr[0];
                inputLineArr = inputLineArr[1].Split(',');
                string item = inputLineArr[0];
                int orders = int.Parse(inputLineArr[1]);

                if (shopItemPrice.ContainsKey(item))
                {
                    if (customers.Count(x => x.Name == customerName) == 0)
                    {
                        customers.Add(new Customer() { Name = customerName, ItemsOrders = new Dictionary<string, int>() });
                    }

                    var currentCustomer = customers.Find(x => x.Name == customerName);

                    if (currentCustomer.ItemsOrders.ContainsKey(item))
                    {
                        currentCustomer.ItemsOrders[item] += orders;
                    }
                    else
                    {
                        currentCustomer.ItemsOrders[item] = orders;
                    }

                }

                inputLine = Console.ReadLine();
            }

            decimal totalBill = 0;
            foreach (var customer in customers.OrderBy(x=>x.Name))
            {
                totalBill+=customer.printBill(shopItemPrice);
            }
            Console.WriteLine("Total bill: {0:f2}", totalBill);




        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public Dictionary<string,int> ItemsOrders { get; set; }

        public decimal printBill(Dictionary<string, decimal> shopItemPrice)
        {
            Console.WriteLine(Name);
            decimal sum = 0;
            foreach (var itemOrders in ItemsOrders)
            {
                Console.WriteLine("-- {0} - {1}",itemOrders.Key,itemOrders.Value);

                sum += shopItemPrice[itemOrders.Key] * itemOrders.Value;
            }

            Console.WriteLine("Bill: {0:F2}", sum);
            return sum;
        }
    }
}
