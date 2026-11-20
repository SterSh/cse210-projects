class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }
    public bool InUSA()
    {
        if (_country == "USA" || _country == "United States")
        {
            return true;
        }
        return false;
    }

    public string GetAddressString()
    {
        string address = _streetAddress + "\n" + _city + ", " + _state + "\n" + _country;
        return address;
    }
}