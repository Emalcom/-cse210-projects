using System;
public class Journal
{
  private List<Entry> _entries = new List<Entry>();
  public void AddEntry(String prompt, String response, String date)
  {
    _entries.Add(new Entry(prompt, response, date));
  }  
   public void DisplayJournal()
   {
    foreach (var entry in _entries)
    {
        entry.Display();
    }
   }
   /*public void UpdateResponse(int index, string newResponse)
   {
    if (index >= 0 && index < _entries.Count)
    {
      _entries[index]._response = newResponse;
      Console.WriteLine("Response updated successfully!");
    }
    else{
      Console.WriteLine("Invalid entry index!");
    }
   }
   public void DeleteEntry(int index)
   {
    if (index >= 0 && index < _entries.Count)
    {
      _entries.RemoveAt(index);
      Console.WriteLine("Entry deleted successfully!");
    }
    else{
      Console.WriteLine("Invalid entry index!");
    }
   }*/
   public void DisplayJournalWithIndexes()
   {
    for (int i = 0; i < _entries.Count; i++)
    {
      Console.WriteLine($"{i}: {_entries[i]._date} - {_entries[i]._prompt} - {_entries[i]._response} ");

    }
   }
   public bool IsValidIndex(int index)
   {
    return index >= 0 && index < _entries.Count;
   }
   public void EditResponse(int index, String newResponse)
   {
    _entries[index] = new Entry(_entries[index]._prompt, newResponse, _entries[index]._date);

   }
   public void DeleteEntry(int index)
   {
    _entries.RemoveAt(index);
   }
   public void SaveToFile(String filename)
   {
    using (StreamWriter writer = new StreamWriter(filename))
    {
      foreach (var entry in _entries)
      {
        writer.WriteLine(entry.ToFileString());
      }
    }
   }
   public void LoadFromFile(String filename)
   {
    if (File.Exists(filename))
    {
      _entries.Clear();
      var lines = File.ReadAllLines(filename);
      foreach (var line in lines)
      {
        _entries.Add(Entry.FromFileString(line));
      }
    }
    else
    {
      Console.WriteLine("File not found!");
    }
   }
}