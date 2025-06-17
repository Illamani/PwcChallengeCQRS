using Carter;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentalCar.Application.Features.CustomerFeatures.Add;
using RentalCar.Application.Features.CustomerFeatures.Get;
using RentalCar.Domain.Entities;

namespace RentalCar.Api.Controllers;

public class CustomerEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost("api/CreateCustomer", CreateAsync);
        app.MapGet("api/GetAllCustomer", GetAllAsync);
        app.MapGet("api/GetCustomer", GetAsync);
        app.MapDelete("api/DeleteCustomer", DeleteAsync);
        app.MapPut("api/UpdateCustomer", UpdateAsync);
    }

    public static async Task<IResult> GetAsync(int id, ISender sender, CancellationToken cancellationToken)
    {
        var customer = await sender.Send(new GetCustomerRequest(id), cancellationToken);
        return Results.Ok(customer);
    }

    public static async Task<IResult> GetAllAsync(ISender sender, CancellationToken cancellationToken)
    {
        var customers = await sender.Send(new GetAllCustomerRequest(), cancellationToken);
        return Results.Ok(customers);
    }

    public static async Task<IResult> CreateAsync([FromBody] Customer customer, ISender sender, CancellationToken cancellationToken)
    {
        var customers = await sender.Send(new AddCustomerRequest(customer),cancellationToken);
        return Results.Ok(customers);
    }

    public static async Task<IResult> UpdateAsync([FromBody] Customer customer, ISender sender, CancellationToken cancellationToken)
    {
        var customers = await sender.Send(new UpdateCustomerRequest(customer), cancellationToken);
        return Results.Ok(customers);
    }

    public static async Task<IResult> DeleteAsync([FromBody] Customer customer, ISender sender, CancellationToken cancellationToken)
    {
        var customers = await sender.Send(new RemoveCarRequest(customer), cancellationToken);
        return Results.Ok(customers);
    }
}
