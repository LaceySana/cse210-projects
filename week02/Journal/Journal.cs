public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayJournal()
    {
        foreach (Entry item in _entries)
        {
            item.Display();
        }
    }

    public void SaveJournal(string filename)
    {
        
    }
}