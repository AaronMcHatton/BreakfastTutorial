using Microsoft.AspNetCore.Mvc;

namespace BreakfastTutorial.AddControllers;
using BreakfastTutorial.Contracts.Breakfast;
using BreakfastTutorial.Models;

[ApiController]
[Route("[controller]")]

public class BreakfastsController : ControllerBase
{
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
        return Ok(id);
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