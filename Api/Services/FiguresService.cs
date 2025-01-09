using Api.Context;
using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Services;

public class FiguresService(StorageContext context) {
    public async Task<Figure[]> GetAllFigures() => await context.Figures.ToArrayAsync();
    
    public async Task<Figure?> GetFigure(string id) => await context.Figures.FirstOrDefaultAsync(f => f.id.ToString() == id);

    public async Task<Guid> AddFigure(Figure figure) {
        var newFigure = figure with { id = Guid.NewGuid() };
        await context.Figures.AddAsync(newFigure);
        return newFigure.id;
    }

}