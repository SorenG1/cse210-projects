using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal total = 0;
        
        // Add up all the product costs
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        // Add shipping - USA is cheaper
        if (_customer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        
        return total;
    }

    // Generate a packing label with all product details
    public string GetPackingLabel()
    {
        string label = "PACKING LABEL:\n";
        label += "==============\n";
        
        foreach (Product product in _products)
        {
            label += "Product: " + product.GetName() + "\n";
            label += "Product ID: " + product.GetProductId() + "\n";
            label += "Quantity: " + product.GetQuantity() + "\n";
            label += "\n";
        }
        
        return label;
    }

    // Generate a shipping label with customer information
    public string GetShippingLabel()
    {
        string label = "SHIPPING LABEL:\n";
        label += "===============\n";
        label += "Customer: " + _customer.GetName() + "\n";
        label += "Address:\n";
        label += _customer.GetAddress().GetFullAddress() + "\n";
        
        return label;
    }

    // Getters
    public List<Product> GetProducts()
    {
        return _products;
    }

    public Customer GetCustomer()
    {
        return _customer;
    }

    // Setters
    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }
}
