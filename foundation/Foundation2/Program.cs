using System;

public class Address
{
    private string street;
    private string city;
    private string state;
    private string country;

    // Constructor
    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    // Method to check if the address is in the USA
    public bool IsInUSA()
    {
        return country == "USA";
    }

    // Method to get the full address as a string
    public string GetFullAddress()
    {
        return $"{street}\n{city}, {state}\n{country}";
    }
}

public class Product
{
    private string name;
    private string productId;
    private double price;
    private int quantity;

    // Constructor
    public Product(string name, string productId, double price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    // Method to calculate the total cost of the product
    public double GetTotalCost()
    {
        return price * quantity;
    }

    // Getter for the product name
    public string GetName()
    {
        return name;
    }

    // Getter for the product id
    public string GetProductId()
    {
        return productId;
    }
}

public class Customer
{
    private string name;
    private Address address;

    // Constructor
    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    // Method to check if the customer is in the USA
    public bool IsInUSA()
    {
        return address.IsInUSA();
    }

    // Getter for the customer's name
    public string GetName()
    {
        return name;
    }

    // Getter for the customer's address
    public Address GetAddress()
    {
        return address;
    }
}

public class Order
{
    private List<Product> products;
    private Customer customer;

    // Constructor
    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    // Method to add a product to the order
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    // Method to calculate the total cost of the order (including shipping)
    public double GetTotalPrice()
    {
        double totalCost = 0;

        // Add up the total cost of all products
        foreach (var product in products)
        {
            totalCost += product.GetTotalCost();
        }

        // Add the shipping cost based on the customer's location
        double shippingCost = customer.IsInUSA() ? 5.0 : 35.0;
        totalCost += shippingCost;

        return totalCost;
    }

    // Method to generate the packing label
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    // Method to generate the shipping label
    public string GetShippingLabel()
    {
        string label = $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}\n";
        return label;
    }
}

public class Program
{
    public static void Main()
    {
        // Create addresses
        Address address1 = new Address("123 Oak St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("Alice", address1);
        Customer customer2 = new Customer("Bob", address2);

        // Create products
        Product product1 = new Product("Laptop", "A123", 799.99, 1);
        Product product2 = new Product("Mouse", "B456", 19.99, 2);
        Product product3 = new Product("Keyboard", "C789", 49.99, 1);
        
        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product2);

        // Display packing and shipping labels, and total prices for each order
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():F2}\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():F2}\n");
    }
}
