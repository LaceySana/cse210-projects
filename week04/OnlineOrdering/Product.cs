public class Product
{
    private string _productName;
    private string _productID;
    private double _price;
    private int _quantity;

    public Product(string productName, string productID, double price, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public double GetTotalPrice()
    {
        double total = _price * _quantity;
        return total;
    }

    public string DisplayProductLabel()
    {
        string productInfo = $"\n  ------\n{_productName}\nID: {_productID}";

        return productInfo;
    }
}