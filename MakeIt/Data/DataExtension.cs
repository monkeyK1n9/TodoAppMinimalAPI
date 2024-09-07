using System;
using Microsoft.EntityFrameworkCore;

namespace MakeIt.Data;

public static class DataExtension
{
    public static async Task MigrateDbAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<MakeItContext>();

        await dbContext.Database.MigrateAsync();
    }
}
