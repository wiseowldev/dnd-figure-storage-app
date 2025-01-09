using System.Net;
using Api.Models;
using Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FiguresController(FiguresService service) : ControllerBase {
    [HttpGet] 
    public async Task<Figure[]> GetFigures() => await service.GetAllFigures();
    
    [HttpGet("/{id}")] 
    public async Task<ActionResult<Figure>> GetFigure([FromRoute] string id) {
        var figure = await service.GetFigure(id);
        if (figure == null) return new StatusCodeResult((int)HttpStatusCode.NotFound);
        return new OkObjectResult(figure);
    }

    [HttpPost] 
    public async Task<Guid> AddFigure([FromBody] AddFigureDto dto) => await service.AddFigure(dto.ToFigure());

    [HttpDelete("/{id}")]
    public async Task DeleteFigure([FromRoute] string id) => await service.DeleteFigure(id);
}