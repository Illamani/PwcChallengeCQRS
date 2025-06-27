using Carter;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentalCar.Application.Features.RentalFeatures.Add;
using RentalCar.Application.Features.RentalFeatures.Get;
using RentalCar.Domain.Dto.Rental;
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
        app.MapGet("api/CheckAvailability", CheckAvailabilityAsync);
        app.MapGet("api/GetRentalWithRelations", GetAllWithRelationAsync);
        app.MapDelete("api/DeleteRental", DeleteAsync);
        app.MapPut("api/UpdateRental", UpdateAsync);
    }

    public static async Task<IResult> CreateAsync([FromBody] RentalInput input, ISender sender, CancellationToken cancellationToken)
    {
        var rental = _mapper.RentalInputToRental(input);
        var rentals = await sender.Send(new AddRentalRequest(rental), cancellationToken);
        return Results.Ok(rentals);
    }

    public static async Task<IResult> CheckAvailabilityAsync([FromBody] RentalInput input, ISender sender, CancellationToken cancellationToken)
    {
        var rental = _mapper.RentalInputToRental(input);
        var disponibility = await sender.Send(new GetRentalByDateRequest(rental), cancellationToken);
        if (!disponibility)
            return Results.BadRequest("This Car has already been rented for this period of time");

        return Results.Ok("This car is available for this period of time");
    }

    public static async Task<IResult> RegisterRentalAsync([FromBody] RentalInput input, ISender sender, CancellationToken cancellationToken)
    {
        var rental = _mapper.RentalInputToRental(input);
        var disponibility = await sender.Send(new GetRentalByDateRequest(rental), cancellationToken);
        if (!disponibility)
            return Results.BadRequest("This Car has already been rented for this period of time");

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

    public static async Task<IResult> DeleteAsync([FromBody] RentalInput input, ISender sender, CancellationToken cancellationToken)
    {
        var rental = _mapper.RentalInputToRental(input);
        var disponibility = await sender.Send(new GetRentalByDateRequest(rental), cancellationToken);
        if (disponibility)
            return Results.BadRequest("There is not reservation to cancel");

        var rentals = await sender.Send(new RemoveRentalRequest(rental), cancellationToken);
        return Results.Ok(rentals);
    }

    public static async Task<IResult> UpdateAsync([FromBody] RentalInput input, ISender sender, CancellationToken cancellationToken)
    {
        var rental = _mapper.RentalInputToRental(input);
        var disponibility = await sender.Send(new GetRentalByDateRequest(rental), cancellationToken);
        if (disponibility)
            return Results.BadRequest("There is not reservation to modify");

        var rentals = await sender.Send(new UpdateRentalRequest(rental), cancellationToken);
        return Results.Ok(rentals);
    }
}
