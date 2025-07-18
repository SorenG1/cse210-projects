using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Check if customer lives in USA (for shipping cost calculation)
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    // Getters
    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    // Setters
    public void SetName(string name)
    {
        _name = name;
    }

    public void SetAddress(Address address)
    {
        _address = address;
    }
}
