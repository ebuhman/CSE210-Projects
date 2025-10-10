using System.IO;

class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Prompt prompt)
    {
        string _question = prompt.randomPrompt();
        Console.WriteLine(_question);
        string _response = Console.ReadLine();

        Entry _newEntry = new Entry();
        _newEntry._entryDateTime = DateTime.Now.ToShortDateString();
        _newEntry._currentPrompt = _question;
        _newEntry._entryText = _response;

        _entries.Add(_newEntry);
    }
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.\n");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile()
    {
        Console.Write("Enter the filename to save to: ");
        string _filename = Console.ReadLine();

        using (StreamWriter _outputFile = new StreamWriter(_filename))
        {
            foreach (Entry entry in _entries)
            {
                // Split by | later
                _outputFile.WriteLine($"{entry._entryDateTime}|{entry._currentPrompt}|{entry._entryText}");
            }
        }

        Console.WriteLine($"Journal saved to '{_filename}'.\n");
    }
    public void LoadFromFile()
    {
        Console.Write("Enter the filename to load from: ");
        string _filename = Console.ReadLine();

        if (!File.Exists(_filename))
        {
            Console.WriteLine("File not found.\n");
            return;
        }

        _entries.Clear(); // Replace existing entries

        string[] lines = File.ReadAllLines(_filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            if (parts.Length == 3)
            {
                Entry entry = new Entry();
                entry._entryDateTime = parts[0];
                entry._currentPrompt = parts[1];
                entry._entryText = parts[2];
                _entries.Add(entry);
            }
        }

        Console.WriteLine($"Journal loaded from '{_filename}'.\n");
    }
}
