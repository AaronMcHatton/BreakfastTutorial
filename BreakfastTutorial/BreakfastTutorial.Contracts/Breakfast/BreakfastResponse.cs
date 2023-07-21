namespace BreakfastTutorial.Contracts.Breakfast;

public record CreateBreakfastResponse(
    Guid id,
    string name,
    string description,
    DateTime startDateTime,
    DateTime endDateTime,
    DateTime lastModifiedDateTime,
    List<string> savory,
    List<string> sweet
);