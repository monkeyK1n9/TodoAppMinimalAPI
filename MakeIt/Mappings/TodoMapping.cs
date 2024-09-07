using System;
using MakeIt.Dtos.TodoDtos;
using MakeIt.Entities;

namespace MakeIt.Mappings;

public static class TodoMapping
{
    public static TodoDto ToDto(this Todo todo)
    {
        return new TodoDto(
            todo.Id,
            todo.Name,
            todo.IsCompleted
        );
    }

    public static Todo ToEntity(this TodoDto todoDto, int id, DateTime createdAt)
    {
        return new Todo()
        {
            Id = id,
            Name = todoDto.Name,
            IsCompleted = todoDto.IsCompleted,
            CreatedAt = createdAt,
            LastModifiedAt = DateTime.Now
        };
    }

    public static Todo ToEntity(this CreateTodoDto createTodoDto)
    {
        return new Todo()
        {
            Name = createTodoDto.Name,
            IsCompleted = createTodoDto.IsCompleted,
            CreatedAt = DateTime.Now,
            LastModifiedAt = DateTime.Now
        };
    }

    public static Todo ToEntity(this UpdateTodoDto updateTodoDto, int id, DateTime createdAt)
    {
        return new Todo()
        {
            Id = id,
            Name = updateTodoDto.Name,
            IsCompleted = updateTodoDto.IsCompleted,
            CreatedAt = createdAt,
            LastModifiedAt = DateTime.Now
        };
    }
}
