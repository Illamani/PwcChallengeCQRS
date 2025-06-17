using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentalCar.Application.Features.CustomerFeatures.Add;
using RentalCar.Application.Features.CustomerFeatures.Get;
using RentalCar.Domain.Entities;

namespace RentalCar.Api.Controllers;

public static class CustomerEndpoint
{
    public static void MapCustomerEndpoints(this IEndpointRouteBuilder builder)
    {
        builder.MapPost("api/CreateCustomer", CreateAsync);
        builder.MapGet("api/GetAllCustomer", GetAllAsync);
        builder.MapGet("api/GetCustomer", GetAsync);
        builder.MapDelete("api/DeleteCustomer", DeleteAsync);
        builder.MapPut("api/UpdateCustomer", UpdateAsync);
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
