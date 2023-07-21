using BreakfastTutorial.Contracts.Breakfast;
using BreakfastTutorial.Models;

namespace BreakfastTutorial.Services.Breakfasts;

public interface IBreakfastService
{
    BreakfastResponse CreateBreakfast(Breakfast breakfast);

}