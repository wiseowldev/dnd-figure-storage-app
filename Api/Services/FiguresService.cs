using Api.Context;
using Api.Models;

namespace Api.Services;

public class FiguresService(StorageContext context) {
    public Figure[] GetAllFigures() => context.Figures.ToArray();
    
    public Guid AddFigure(Figure figure) {
        var newFigure = figure with { id = Guid.NewGuid() };
        context.Figures.Add(newFigure);
        return newFigure.id;
    }

}