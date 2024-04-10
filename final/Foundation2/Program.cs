using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Popular Drive", "Cool City", "Awesome", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        List<Product> productsList1 = new List<Product>();
        Product product1 = new Product("Shoes", "111-1111-11111", 20, 1);
        Product product2 = new Product("Hat", "222-2222-22222", 10, 2);
        Product product3 = new Product("Shirt", "333-3333-33333", 15, 3);
        productsList1.Add(product1);
        productsList1.Add(product2);
        productsList1.Add(product3);
        Order order1 = new Order(productsList1, customer1);


        Address address2 = new Address("456 Unknown Street", "Mysterious City", "Hidden", "Secret Country");
        Customer customer2 = new Customer("Jane Doe", address2);
        
        List<Product> productsList2 = new List<Product>();
        Product product4 = new Product("Pants", "444-4444-44444", 40, 4);
        Product product5 = new Product("Socks", "555-5555-55555", 3, 5);
        Product product6 = new Product("Necklace", "666-6666-66666", 25, 6);
        productsList2.Add(product4);
        productsList2.Add(product5);
        productsList2.Add(product6);
        Order order2 = new Order(productsList2, customer2);

        List<Order> orders = new List<Order>
        {
            order1,
            order2
        };

        foreach (Order o in orders)
        {
            Console.WriteLine($"\nPacking Label: \n{o.GetPackingLabel()}\n");
            Console.WriteLine("~~~~~~~~~~~~~");
            Console.WriteLine($"\nShipping Label: \n{o.GetShippingLabel()}\n");
            Console.WriteLine("~~~~~~~~~~~~~");
            Console.WriteLine($"\nOrder Total: \n${o.TotalCost()}\n");
            Console.WriteLine("~~~~~~~~~~~~~");
        }
    }
}