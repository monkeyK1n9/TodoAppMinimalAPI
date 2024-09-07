using System;

namespace MakeIt.Entities;

public class Todo
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool IsCompleted { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime LastModifiedAt { get; set; } = DateTime.Now;
}
