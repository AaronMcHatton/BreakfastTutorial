namespace BreakfastTutorial.Services;
using BreakfastTutorial.Models;
using BreakfastTutorial.Services.Breakfasts;

public class BreakfastService : IBreakfastService
{
    private readonly Dictionary<Guid, Breakfast> _breakfasts = new();
    public void CreateBreakfast(Breakfast breakfast)
    {
        _breakfasts.Add(breakfast.id, breakfast);
    }

    public Breakfast GetBreakfast(Guid id)
    {
        return _breakfasts[id];
    }
}