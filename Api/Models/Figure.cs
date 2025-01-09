namespace Api.Models;

public record Figure(
    Guid id,
    string name,
    int storageBox,
    int subLocation,
    string image //base64 encoded image
);

public record AddFigureDto(
    string name,
    int storageBox,
    int subLocation,
    string image
) {
    public Figure ToFigure() {
        return new Figure(
            Guid.NewGuid(),
            name,
            storageBox,
            subLocation,
            image
        );
    }
}