using Carter;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentalCar.Application.Features.ServiceModelFeatures.Add;
using RentalCar.Application.Features.ServiceModelFeatures.Get;
using RentalCar.Domain.Entities;

namespace RentalCar.Api.Controllers;

public class ServiceModelEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost("api/CreateService", CreateAsync);
        app.MapGet("api/GetAllService", GetAllAsync);
        app.MapGet("api/GetService", GetAsync);
        app.MapDelete("api/DeleteService", DeleteAsync);
        app.MapPut("api/UpdateService", UpdateAsync);
    }

    public static async Task<IResult> GetAsync(int id, ISender sender, CancellationToken cancellationToken)
    {
        var service = await sender.Send(new GetServiceRequest(id), cancellationToken);
        return Results.Ok(service);
    }

    public static async Task<IResult> GetAllAsync(ISender sender, CancellationToken cancellationToken)
    {
        var services = await sender.Send(new GetAllServiceRequest(), cancellationToken);
        return Results.Ok(services);
    }

    public static async Task<IResult> CreateAsync([FromBody] ServiceModel service, ISender sender, CancellationToken cancellationToken)
    {
        var services = await sender.Send(new AddServiceRequest(service), cancellationToken);
        return Results.Ok(services);
    }

    public static async Task<IResult> DeleteAsync([FromBody]ServiceModel service, ISender sender, CancellationToken cancellationToken)
    {
        var services = await sender.Send(new RemoveServiceRequest(service), cancellationToken);
        return Results.Ok(services);
    }

    public static async Task<IResult> UpdateAsync([FromBody] ServiceModel service, ISender sender, CancellationToken cancellationToken)
    {
        var services = await sender.Send(new UpdateServiceRequest(service), cancellationToken);
        return Results.Ok(services);
    }
}
