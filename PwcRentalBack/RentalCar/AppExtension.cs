using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using RentalCar.Persistence.Context;

namespace RentalCar.Api;

public static class AppExtension
{
    public static void ConfigureErrorHandler(this IApplicationBuilder app)
    {
        app.UseExceptionHandler(appError =>
        {
            appError.Run(async context =>
            {
                context.Response.StatusCode = 500;
                context.Response.ContentType = "application/json";

                var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                if (contextFeature is null)
                    return;

                Console.WriteLine($"Error : {contextFeature.Error}");
                await context.Response.WriteAsJsonAsync(new
                    {
                        StatusCode = context.Response.StatusCode,
                        Message = "Internal Server Error"
                    });
            });
        });
    }

    public static void ConfigureSwagger(this WebApplication app)
    {
        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
            return;

        app.UseSwagger();

        app.UseSwaggerUI();
    }

    public static void AddInitialMigration(this WebApplication app)
    {
        //Permite la migracion al iniciar el proyecto
        using var scope = app.Services.CreateScope();
        var dataContext = scope.ServiceProvider.GetRequiredService<RentalContext>();
        dataContext.Database.Migrate();
    }
}
