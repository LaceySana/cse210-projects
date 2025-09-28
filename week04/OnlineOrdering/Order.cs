public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer, params Product[] products)
    {
        _customer = customer;
        foreach (Product prod in products)
        {
            _products.Add(prod);
        }
    }

    private double GetShippingCost()
    {
        double shippingCost = 5.00;

        bool inUSA = _customer.DoesLiveInUSA();

        if (inUSA != true)
        {
            shippingCost = 35.00;
        }
        return shippingCost;
    }

    public double CalculateTotalCost()
    {
        double totalProductCost = 0;

        foreach (Product prod in _products)
        {
            totalProductCost += prod.GetTotalPrice();
        }

        double totalCost = totalProductCost + GetShippingCost();
        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "\nPacking Label: ";

        foreach (Product prod in _products)
        {
            packingLabel += prod.DisplayProductLabel();
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"\nShipping Label: {_customer.DisplayCustomerInfo()}";
    }
}