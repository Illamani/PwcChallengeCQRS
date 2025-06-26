using Carter;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentalCar.Application.Features.RentalFeatures.Add;
using RentalCar.Application.Features.RentalFeatures.Get;
using RentalCar.Domain.Dto.Rental;
using RentalCar.Domain.Entities;
using RentalCar.Domain.Mapper;

namespace RentalCar.Api.Controllers;

public class RentalEndpoint : ICarterModule
{
    private static readonly RentalMapper _mapper = new();

    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost("api/CreateRental", CreateAsync);
        app.MapPost("api/RegisterRental", RegisterRentalAsync);
        app.MapGet("api/GetAllRentals", GetAllAsync);
        app.MapGet("api/GetRental", GetAsync);
        app.MapDelete("api/DeleteRental", DeleteAsync);
        app.MapPut("api/UpdateRental", UpdateAsync);
    }

    public static async Task<IResult> CreateAsync([FromBody] RentalInput input, ISender sender, CancellationToken cancellationToken)
    {
        var rental = _mapper.RentalInputToRental(input);
        var rentals = await sender.Send(new AddRentalRequest(rental), cancellationToken);
        return Results.Ok(rentals);
    }

    public static async Task<IResult> RegisterRentalAsync([FromBody] RentalInput input, ISender sender, CancellationToken cancellationToken)
    {
        var rental = _mapper.RentalInputToRental(input);
        var disponibility = await sender.Send(new GetRentalByDateRequest(rental), cancellationToken);
        if (!disponibility)
            return Results.Conflict();

        return Results.Ok(rental);
    }

    public static async Task<IResult> GetAllWithRelationAsync(ISender sender, CancellationToken cancellationToken)
    {
        var rental = await sender.Send(new GetAllWithRelationsRequest(), cancellationToken);
        return Results.Ok(rental);
    }

    public static async Task<IResult> GetAsync(int id, ISender sender, CancellationToken cancellationToken)
    {
        var rental = await sender.Send(new GetRentalRequest(id), cancellationToken);
        return Results.Ok(rental);
    }

    public static async Task<IResult> GetAllAsync(ISender sender, CancellationToken cancellationToken)
    {
        var rentals = await sender.Send(new GetAllRentalRequest(), cancellationToken);
        return Results.Ok(rentals);
    }

    public static async Task<IResult> DeleteAsync([FromBody] Rental rental, ISender sender, CancellationToken cancellationToken)
    {
        var rentals = await sender.Send(new RemoveRentalRequest(rental), cancellationToken);
        return Results.Ok(rentals);
    }

    public static async Task<IResult> UpdateAsync([FromBody] Rental rental, ISender sender, CancellationToken cancellationToken)
    {
        var rentals = await sender.Send(new UpdateRentalRequest(rental), cancellationToken);
        return Results.Ok(rentals);
    }
}
