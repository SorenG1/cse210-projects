using System;

public class Product
{
    private string _name;
    private string _productId;
    private decimal _price;
    private int _quantity;

    public Product(string name, string productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Calculate total cost for this product (price * quantity)
    public decimal GetTotalCost()
    {
        return _price * _quantity;
    }

    // Getters
    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public decimal GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    // Setters
    public void SetName(string name)
    {
        _name = name;
    }

    public void SetProductId(string productId)
    {
        _productId = productId;
    }

    public void SetPrice(decimal price)
    {
        _price = price;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
}
