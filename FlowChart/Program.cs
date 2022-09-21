using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace FlowChart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();    
            Customer customer = new Customer();
            RegCustomer customer2 = new RegCustomer(20);
            company.Customers.Add(customer);
            company.Customers.Add(customer2);
            Order order = new Order();  
            OrderedItem oi=new OrderedItem { Qun=3};
            OrderedItem oi2=new OrderedItem { Qun=4};
            order.OrderedItem.Add(oi);
            order.OrderedItem.Add(oi2);
            Item item = new Item { Rate=10};
            Item item2 = new Item { Rate=20};   
            oi.Item = item;
            oi2.Item = item2;
            customer.Orders.Add(order);
            Console.WriteLine(company.GetTotalWorthOfOrdersPlaced());
        }
    }

    class Company
    {
        public List<Item> Items { get; set; }=new List<Item>();
        public List<Customer> Customers { get; set; }=new List<Customer>();   
        public double GetTotalWorthOfOrdersPlaced()
        {
            double totalWorth = 0;
            foreach (Customer cus in Customers)
            {
                totalWorth += cus.GetOrderWorth();
            }
            return totalWorth;
        }
    }
    class Item
    {
        public double Rate { get; set; }
        public string Description { get; set; }    
    }
    class Customer
    {
        public List<Order> Orders { get; set; } = new List<Order>();
        public virtual double GetOrderWorth()
        {
            double orderWorth = 0;
            foreach (Order o in Orders)
            {
                orderWorth += o.GetValue();
            }
            return orderWorth;  
        }

    }
    class RegCustomer:Customer
    {
        public RegCustomer(double discount)
        {
            Discount = discount;
        }

        public double Discount { get; set; }
        public override double GetOrderWorth()
        {
            double total=base.GetOrderWorth();
            total -= Discount;
            return total;
        }
    }
    class Order
    {
        public List<OrderedItem> OrderedItem { get; set; } = new List<OrderedItem>();
        public double GetValue()
        {
            double ov = 0;
            foreach (OrderedItem item in OrderedItem)
            {
                ov+=item.GetValue();
            }
            return ov;  
        }
    }
    class OrderedItem
    {
        public int Qun { get; set; }   
        public Item Item { get; set; } 
        public double GetValue()
        {
            return Qun * Item.Rate;
        }
    }
}
