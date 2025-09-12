public class Entry
{
    public string _dateText;
    public string _promptText;
    public string _responseText;

    public void Display()
    {
        Console.WriteLine($"{_dateText}\n{_promptText}\n{_responseText}\n");
    }
}