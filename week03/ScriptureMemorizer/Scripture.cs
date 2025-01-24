using System;
public class Scripture
{
  private ScriptureReference _reference;
  private List<Word> _words;
  public Scripture( ScriptureReference reference, string text)
  {
    _reference = reference;
    _words = text.Split(' ').Select(Word => new Word(Word)).ToList();

  }
  public string GetDisplayText()
  {
    string wordText = string.Join(" ", _words.Select(Word => Word.GetDisplayText()));
    return $"{_reference.GetDisplayText()}\n{wordText}";
  }
  public bool HideRandomWords(int count)
  {
    var visibleWords = _words.Where(word => !word.IsHidden()).ToList();
    if (visibleWords.Count == 0)
    {
        return false;
    }
    Random random = new Random();
    for (int i = 0; i < count && visibleWords.Count > 0; i++)
    {
        int index = random.Next(visibleWords.Count);
        visibleWords[index].Hide();
        visibleWords.RemoveAt(index);
    }
    return true;
  }
}