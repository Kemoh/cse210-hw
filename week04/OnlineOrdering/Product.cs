class Product
{
    private string _productName;
    private int _productId;
    private double _productPrice;
    private int _productQuantity;

    // Constructor to initialize product details
    public Product(string name, int productId, double price, int quantity)
    {
        _productName = name;
        _productId = productId;
        _productPrice = price;
        _productQuantity = quantity;
    }

    // Calculate the total cost of the product (price * quantity)
    public double TotalCostOfProduct()
    {
        return _productPrice * _productQuantity;
    }

    // Get the product's information (name and ID)
    public string GetProductInfo()
    {
        return $"{_productName} (ID: {_productId})";
    }

}
