using System;
using System.Collections.Generic;

namespace OnlineOrderProcessing
{
    public enum OrderStatus
    {
        Created,
        Paid,
        Packed,
        Shipped,
        Delivered,
        Cancelled
    }

    public class Product
    {
        public int Id { get; }
        public string Name { get; }
        public decimal Price { get; }

        public Product(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }

    public class Customer
    {
        public int Id { get; }
        public string Name { get; }

        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public class OrderItem
    {
        public Product Product { get; }
        public int Quantity { get; }

        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public decimal Total => Product.Price * Quantity;
    }

    public class OrderStatusLog
    {
        public OrderStatus OldStatus { get; }
        public OrderStatus NewStatus { get; }
        public DateTime Timestamp { get; }

        public OrderStatusLog(OrderStatus oldStatus, OrderStatus newStatus)
        {
            OldStatus = oldStatus;
            NewStatus = newStatus;
            Timestamp = DateTime.Now;
        }
    }

    public delegate void OrderStatusChangedHandler(Order order, OrderStatus oldStatus, OrderStatus newStatus);

    public class Order
    {
        public int Id { get; }
        public Customer Customer { get; }
        public List<OrderItem> Items { get; } = new List<OrderItem>();
        public List<OrderStatusLog> StatusHistory { get; } = new List<OrderStatusLog>();
        public OrderStatus Status { get; private set; }

        public OrderStatusChangedHandler OnStatusChanged;

        public Order(int id, Customer customer)
        {
            Id = id;
            Customer = customer;
            Status = OrderStatus.Created;
        }

        public void AddItem(Product product, int qty)
        {
            Items.Add(new OrderItem(product, qty));
        }

        public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (var item in Items)
                total += item.Total;

            decimal tax = total * 0.10m;
            return total + tax;
        }

        public void ChangeStatus(OrderStatus newStatus)
        {
            if (!IsValidTransition(Status, newStatus))
            {
                Console.WriteLine("Invalid transition: " + Status + " -> " + newStatus);
                return;
            }

            var oldStatus = Status;
            Status = newStatus;
            StatusHistory.Add(new OrderStatusLog(oldStatus, newStatus));

            if (OnStatusChanged != null)
                OnStatusChanged(this, oldStatus, newStatus);
        }

        private bool IsValidTransition(OrderStatus current, OrderStatus next)
        {
            if (current == OrderStatus.Cancelled) return false;

            return current switch
            {
                OrderStatus.Created => next == OrderStatus.Paid || next == OrderStatus.Cancelled,
                OrderStatus.Paid => next == OrderStatus.Packed,
                OrderStatus.Packed => next == OrderStatus.Shipped,
                OrderStatus.Shipped => next == OrderStatus.Delivered,
                _ => false
            };
        }
    }

    public class CustomerNotification
    {
        public void Notify(Order order, OrderStatus oldStatus, OrderStatus newStatus)
        {
            Console.WriteLine(
                "Customer " + order.Customer.Name +
                ": Order " + order.Id +
                " changed from " + oldStatus +
                " to " + newStatus
            );
        }
    }

    public class LogisticsNotification
    {
        public void Notify(Order order, OrderStatus oldStatus, OrderStatus newStatus)
        {
            if (newStatus == OrderStatus.Shipped)
            {
                Console.WriteLine(
                    "Logistics: Order " + order.Id + " is ready for delivery"
                );
            }
        }
    }

    // ---------- REPORT ---------
    public static class OrderReport
    {
        public static void PrintOrder(Order order)
        {
            Console.WriteLine("\nOrder ID: " + order.Id + " | Customer: " + order.Customer.Name);

            foreach (var item in order.Items)
            {
                Console.WriteLine(
                    " - " + item.Product.Name +
                    " x " + item.Quantity +
                    " = " + item.Total
                );
            }

            Console.WriteLine("Total (incl tax): " + order.CalculateTotal());
            Console.WriteLine("Current Status: " + order.Status);

            Console.WriteLine("Status Timeline:");
            foreach (var log in order.StatusHistory)
            {
                Console.WriteLine(
                    " " + log.Timestamp +
                    " : " + log.OldStatus +
                    " -> " + log.NewStatus
                );
            }
        }
    }

    class Program
    {
        public static void Main()
        {
            var products = new Dictionary<int, Product>
            {
                {1, new Product(1, "Laptop", 50000)},
                {2, new Product(2, "Mouse", 500)},
                {3, new Product(3, "Keyboard", 1500)},
                {4, new Product(4, "Headset", 2000)},
                {5, new Product(5, "Monitor", 12000)}
            };

            var customer = new Customer(1, "Alice");

            var customerNotifier = new CustomerNotification();
            var logisticsNotifier = new LogisticsNotification();

            Order order = new Order(101, customer);
            order.AddItem(products[1], 1);
            order.AddItem(products[2], 2);

            order.OnStatusChanged += customerNotifier.Notify;
            order.OnStatusChanged += logisticsNotifier.Notify;

            order.ChangeStatus(OrderStatus.Paid);
            order.ChangeStatus(OrderStatus.Packed);
            order.ChangeStatus(OrderStatus.Shipped);
            order.ChangeStatus(OrderStatus.Delivered);

            order.ChangeStatus(OrderStatus.Paid); // invalid

            OrderReport.PrintOrder(order);

            Console.WriteLine("\nProgram completed");
        }
    }
}


