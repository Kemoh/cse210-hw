class Order
{
    private Customer _customer;
    private List<Product> _products;

    // Constructor to initialize the order with a customer
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    // Add a product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Calculate the total cost of the order (including products and shipping)
    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.TotalCostOfProduct();
        }

        // Shipping cost depends on whether the customer is in the USA
        double shippingCost = _customer.IsInUSA() ? 5 : 35;
        return totalCost + shippingCost;
    }

    // Get the packing label (list of product names and IDs)
    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += product.GetProductInfo() + "\n";
        }
        return packingLabel.TrimEnd();
    }

    // Get the shipping label (customer's name and full address)
    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress()}";
    }
}
