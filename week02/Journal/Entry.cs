using System;
public class Entry
{
    public String _prompt;
    public String _response;
    public String _date;

    public Entry(String prompt, String response, String date)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
    }
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine();
    }
    public String ToFileString()
    {
        return $"{_date}|{_prompt}|{_response}";
    }
    public static Entry FromFileString(String fileString)
    {
        var parts = fileString.Split('|');
        return new Entry(parts[1], parts[2], parts[0]);
    }

}