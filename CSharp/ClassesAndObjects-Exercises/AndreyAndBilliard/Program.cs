using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyAndBilliard
{
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> ProductAndQuantity { get; set; }
        public decimal Bill { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int numProducts = int.Parse(Console.ReadLine());

            Dictionary<string, decimal> shop = new Dictionary<string, decimal>();
            for (int i = 0; i < numProducts; i++)
            {
                string[] product = Console.ReadLine().Split('-').ToArray();
                if (shop.ContainsKey(product[0]))
                {
                    shop[product[0]] = decimal.Parse(product[1]);
                }
                else
                {
                    shop.Add(product[0], decimal.Parse(product[1]));
                }
            }

            List<Customer> customers = new List<Customer>();
            string cust = Console.ReadLine();
            while (cust != "end of clients")
            {
                string[] customerOrder = cust.Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = customerOrder[0];
                string product = customerOrder[1];
                int quantity = int.Parse(customerOrder[2]);

                if (shop.ContainsKey(product))
                {
                    if (!customers.Any(x => x.Name == name))
                    {
                        Customer customer = new Customer();
                        customer.Name = name;
                        Dictionary<string, int> temp = new Dictionary<string, int>();
                        temp.Add(product, quantity);
                        customer.ProductAndQuantity = temp;
                        customer.Bill = customer.Bill + quantity * shop[product];
                        customers.Add(customer);
                    }
                    else
                    {

                        Customer customer = customers.Where(x => x.Name == name).First();
                        if (customer.ProductAndQuantity.ContainsKey(product))
                        {
                            customer.ProductAndQuantity[product] += quantity;
                            customer.Bill = customer.Bill + quantity * shop[product];
                        }
                        else
                        {
                            customer.ProductAndQuantity.Add(product, quantity);
                            customer.Bill = customer.Bill + quantity * shop[product];
                        }
                    }

                    

                }
                cust = Console.ReadLine();
            }



                var total = customers.Sum(x => x.Bill);
                customers = customers.Distinct().OrderBy(x => x.Name).ToList();
            foreach (var customer in customers)
            {
                Console.WriteLine("{0}", customer.Name);
                foreach (var productAndQuantity in customer.ProductAndQuantity)
                {
                    Console.WriteLine("-- {0} - {1}", productAndQuantity.Key, productAndQuantity.Value);
                }
                Console.WriteLine("Bill: {0:F2}", customer.Bill);
            }
            Console.WriteLine("Total bill: {0:F2}", total);
        }
    }
}
