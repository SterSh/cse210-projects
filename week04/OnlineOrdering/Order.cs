class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();
    public Order(Customer customer)
    {
        _customer = customer;
    }
    public double CartTotal()
    {
        double subTotal = 0;
        foreach (Product product in _products)
        {
            subTotal += product.TotalCost();
        }

        double total = subTotal + ShippingCost();

        return total;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double ShippingCost()
    {
        if (_customer.InUSA())
        {
            return 5.00;
        }
        return 35.00;
    }

    public string PackingLabel()
    {
        string packingList = "";
        foreach (Product product in _products)
        {
            packingList += product.GetNameProductIdString();
        }
        return packingList;
    }

    public string ShippingLabel()
    {
        return _customer.GetCustomerString();
    }
}