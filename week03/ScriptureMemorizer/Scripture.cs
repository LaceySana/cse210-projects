public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        foreach (string word in text.Split(' '))
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            int randInt;
            do
            {
                randInt = random.Next(_words.Count);
            } while (_words[randInt].IsHidden());
            _words[randInt].Hide();
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText();

        foreach (Word w in _words)
        {
            displayText += " " + w.GetDisplayText();
        }
        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        bool allHidden = true;
        foreach (Word w in _words)
        {
            if (!(w.IsHidden()))
            {
                allHidden = false;
                return allHidden;
            }
        }
        // ShowAll();
        return allHidden;
    }

    // private void ShowAll()
    // {
    //     foreach (Word w in _words)
    //     {
    //         w.Show();
    //     }
    // }
}