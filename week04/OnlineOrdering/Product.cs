class Product
{
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;

    public Product(string name, int productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public string GetNameProductIdString()
    {
        return _name + ": " + _productId + "\n";
    }

    public double TotalCost()
    {
        return _price * _quantity;
    }
}