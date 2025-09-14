using System.IO;
using Microsoft.VisualBasic.FileIO;

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
        Console.WriteLine("\nSaving to file...");

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._dateText},\"{e._promptText}\",\"{e._responseText}\"");
            }
        }
    }

    public void LoadJournal(string filename)
    {
        Console.WriteLine("\nLoading file...");
        _entries = [];

        string[] lines = System.IO.File.ReadAllLines(filename);

        TextFieldParser parser = new TextFieldParser(filename);
        parser.HasFieldsEnclosedInQuotes = true;
        parser.SetDelimiters(",");

        foreach (string line in lines)
        {
            string[] parts = parser.ReadFields();

            Entry newEntry = new Entry();
            newEntry._dateText = parts[0];
            newEntry._promptText = parts[1];
            newEntry._responseText = parts[2];
            _entries.Add(newEntry);
        }
    }
}