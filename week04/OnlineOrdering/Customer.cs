public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool DoesLiveInUSA()
    {
        if (_address.IsInUsa())
        {
            return true;
        }
        return false;
    }

    public string DisplayCustomerInfo()
    {
        string customerInfo = $"\n  ------\n{_name} \n{_address.FormatAddress()}";

        return customerInfo;
    }
}
