using System.Text;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double total = 0;
        foreach (Product p in _products)
        {
            total += p.GetTotalCost();
        }

        total += _customer.LivesInUSA() ? 5.00 : 35.00;
        return total;
    }

    public string GetPackingLabel()
    {
        StringBuilder sb = new StringBuilder();
        foreach (Product p in _products)
        {
            sb.AppendLine(p.GetPackingInfo());
        }
        return sb.ToString();
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}
