namespace MiniTask.Core;

public record TaskDto(
    int Id,
    string Title,
    string? Description,
    string Status,
    DateTime CreatedAt
);