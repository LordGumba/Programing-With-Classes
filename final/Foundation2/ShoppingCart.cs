using System;

class ShoppingCart
{
    static void Main(string[] args)
    {
        // Create customer and address
        Address address1 = new Address
        {
            Street = "123 Main St",
            City = "New York",
            StateProvince = "NY",
            Country = "USA"
        };

        Customer customer1 = new Customer
        {
            Name = "John Doe",
            Address = address1
        };

        // Create products
        Product product1 = new Product
        {
            Name = "Product 1",
            ProductId = "P1",
            Price = 10,
            Quantity = 2
        };

        Product product2 = new Product
        {
            Name = "Product 2",
            ProductId = "P2",
            Price = 20,
            Quantity = 3
        };

        // Create an order and add products
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // Display packing label, shipping label, and total cost
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.CalculateTotalCost());
    }
}