using BreakfastTutorial.Contracts.Breakfast;
using BreakfastTutorial.Models;

namespace BreakfastTutorial.Services.Breakfasts;

public interface IBreakfastService
{
    void CreateBreakfast(Breakfast breakfast);
    Breakfast GetBreakfast(Guid id);
}