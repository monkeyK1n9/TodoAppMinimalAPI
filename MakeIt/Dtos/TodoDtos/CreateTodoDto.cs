using System.ComponentModel.DataAnnotations;

namespace MakeIt.Dtos.TodoDtos;

public record class CreateTodoDto(
    [Required][StringLength(100)] string Name,
    bool IsCompleted
);
