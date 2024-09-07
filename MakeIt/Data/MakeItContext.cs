using System;
using MakeIt.Entities;
using Microsoft.EntityFrameworkCore;

namespace MakeIt.Data;

public class MakeItContext(DbContextOptions<MakeItContext> options) : DbContext(options)
{
    public DbSet<Todo> Todos => Set<Todo>();
}
