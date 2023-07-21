namespace BreakfastTutorial.Models;

public class Breakfast
{
    public Guid id { get; }
    public string name { get; }
    public string description { get; }
    public DateTime startDateTime { get; }
    public DateTime endDateTime { get; }
    public DateTime lastModifiedDateTime { get; }
    public List<string> savory { get; }
    public List<string> sweet { get; }

    public Breakfast(
    Guid id,
    string name,
    string description,
    DateTime startDateTime,
    DateTime endDateTime,
    DateTime lastModifiedDateTime,
    List<string> savory,
    List<string> sweet
)
    { }


}