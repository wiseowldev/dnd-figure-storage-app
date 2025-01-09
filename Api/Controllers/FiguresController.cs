using Api.Models;
using Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FiguresController(FiguresService service) : ControllerBase {
    [HttpGet] public Figure[] GetFigures() => service.GetAllFigures();
    [HttpPost] public Guid AddFigure([FromBody] AddFigureDto dto) => service.AddFigure(dto.ToFigure());
}