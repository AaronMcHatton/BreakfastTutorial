using Microsoft.AspNetCore.Mvc;

namespace BreakfastTutorial.AddControllers;
using BreakfastTutorial.Contracts.Breakfast;
using BreakfastTutorial.Models;
using BreakfastTutorial.Services.Breakfasts;

[ApiController]
[Route("[controller]")]

public class BreakfastsController : ControllerBase
{
    private readonly IBreakfastService _breakfastService;

    public BreakfastsController(IBreakfastService breakfastService)
    {
        _breakfastService = breakfastService;
    }

    [HttpPost]
    public IActionResult CreateBreakfast(CreateBreakfastRequest request)
    {
        var breakfast = new Breakfast(
            Guid.NewGuid(),
            request.name,
            request.description,
            request.startDateTime,
            request.endDateTime,
            DateTime.UtcNow,
            request.savory,
            request.sweet
        );

        // save to DB
        _breakfastService.CreateBreakfast(breakfast);

        var response = new BreakfastResponse(
            breakfast.id,
            breakfast.name,
            breakfast.description,
            breakfast.startDateTime,
            breakfast.endDateTime,
            breakfast.lastModifiedDateTime,
            breakfast.savory,
            breakfast.sweet
        );

        return CreatedAtAction(actionName: nameof(GetBreakfast),
        routeValues: new { id = breakfast.id },
        value: response);
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetBreakfast(Guid id)
    {
        Breakfast breakfast = _breakfastService.GetBreakfast(id);
        var response = new BreakfastResponse(
            breakfast.id,
            breakfast.name,
            breakfast.description,
            breakfast.startDateTime,
            breakfast.endDateTime,
            breakfast.lastModifiedDateTime,
            breakfast.savory,
            breakfast.sweet
        );
        return Ok(response);
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpsertBreakfast(Guid id, UpsertBreakfastRequest request)
    {
        return Ok(request);
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteBreakfast(Guid id)
    {
        return Ok(id);
    }
}