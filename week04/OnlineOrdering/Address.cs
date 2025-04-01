class Address
{
    // Declare the member varioables
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // Constructor to initialize the address details
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // Check if the address is in the USA
    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";
    }

    // Get the full address formatted with newlines
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}
