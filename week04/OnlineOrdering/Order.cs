using System;
class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        products.Add(product);
    }
    public double GetTotalCost()
    {
        double total = 0;
        foreach (var product in products)
        {
            total += product.GetTotalCost();
        }
        double shippingCost = customer.IsInUSA() ? 5.0 : 35.0;
        return total + shippingCost;
    }
    public string GetPackingLabel()
    {
        string label = "Packing List:\n";
        foreach (var product in products)
        {
            label += $"- {product.GetPackingLabel}";
        }
        return label;
    }
    public string GetShippingLabel()
    {
        return $"Shipping To:\n{customer.GetName()}\n{customer.GetShippingAddress()}";
    }
} 