using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            string separator = "~|~";
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}{separator}{entry._promptText}{separator}{entry._entryText}");
            }
        }
    }
    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            _entries.Clear();
            string[] lines = System.IO.File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                Entry entry = new Entry();
                string[] parts = line.Split("~|~");

                entry._date = parts[0];
                entry._promptText = parts[1];
                entry._entryText = parts[2];

                AddEntry(entry);
            }
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }

    }

}