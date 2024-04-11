public class Order
{
    private List<Product> _productsList;
    private Customer _customer;

    public Order(List<Product> productsList, Customer customer)
    {
        _productsList = productsList;
        _customer = customer;
    }

    public double TotalCost()
    {
        double sumTotal = 0;
        foreach (Product p in _productsList)
        {
            sumTotal += p.TotalCost();
        }

        double shippingCost;
        if (_customer.CustomerInUSA())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        double oTotalCost = sumTotal + shippingCost; 
        return oTotalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product p in _productsList)
        {
            string productInfo = $"{p.GetProductName()} ({p.GetProductID()})";
            packingLabel += $"\n{productInfo}";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"\n{_customer.GetCustomerName()}\n{_customer.GetCustomerAddress()}";
    }
}