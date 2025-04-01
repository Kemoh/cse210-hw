class Customer
{
    private string _customerName;
    private Address _customerAddress;

    // Constructor to initialize the customer with name and address
    public Customer(string name, Address address)
    {
        _customerName = name;
        _customerAddress = address;
    }

    // Check if the customer is in the USA
    public bool IsInUSA()
    {
        return _customerAddress.IsInUSA();
    }

    // Get the customer's name
    public string GetName()
    {
        return _customerName;
    }

    // Get the customer's full address
    public string GetAddress()
    {
        return _customerAddress.GetFullAddress();
    }
}
