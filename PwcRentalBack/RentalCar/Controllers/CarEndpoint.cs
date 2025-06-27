using Carter;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentalCar.Application.Features.CarFeatures.Add;
using RentalCar.Application.Features.CarFeatures.Get;
using RentalCar.Domain;
using RentalCar.Domain.Dto.Car;
using RentalCar.Domain.Entities;

namespace RentalCar.Api.Controllers;
public class CarEndpoints : ICarterModule
{
    private static readonly CarMapper _mapper = new();

    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost("api/CreateCar", CreateCarAsync);
        app.MapGet("api/GetAllCar", GetCarsAsync);
        app.MapGet("api/GetCar", GetCarAsync);
        app.MapDelete("api/DeleteCar", DeleteCarAsync);
        app.MapPut("api/UpdateCar", UpdateCarAsync);
    }

    /*
    public static void MapCarEndpoints(this IEndpointRouteBuilder builder)
    {
        builder.MapPost( "api/CreateCar", CreateCarAsync);
        //async (Car car, ISender sender, CancellationToken cancellationToken) =>
        //{
        //    var carReturn = await sender.Send(new AddCarRequest(car), cancellationToken);
        //    return Results.Ok(carReturn);
        //    //return _mapper.CarToCarDto(carReturn);
        //});
        //Este comentario de arriba es otra forma de trabajar minimal API, usando el cuerpo del metodo en vez de una llamada al metodo
        builder.MapGet("api/GetAllCar", GetCarsAsync);
        builder.MapGet("api/GetCar", GetCarAsync);
        builder.MapDelete("api/DeleteCar", DeleteCarAsync);
        builder.MapPut("api/UpdateCar", UpdateCarAsync);
    }
    */
    public static async Task<IResult> CreateCarAsync([FromBody] CarInput carInput, ISender sender, CancellationToken cancellationToken)
    {
        var car = _mapper.CarInputToCar(carInput);
        var carReturn = await sender.Send(new AddCarRequest(car), cancellationToken);
        return Results.Ok(carReturn);
    }

    public static async Task<IResult> GetCarsAsync(ISender sender, CancellationToken cancellationToken)
    {
        var cars = await sender.Send(new GetAllCarRequest(), cancellationToken);
        return  Results.Ok(cars);
    }

    public static async Task<IResult> GetCarAsync(int id, ISender sender, CancellationToken cancellationToken)
    {
        var car = await sender.Send(new GetCarRequest(id), cancellationToken);
        return Results.Ok(car);
    }

    public static async Task<IResult> DeleteCarAsync([FromBody] Car car, ISender sender, CancellationToken cancellationToken)
    {
        var carModel = await sender.Send(new RemoveCarRequest(car), cancellationToken);
        return Results.Ok(carModel);
    }

    public static async Task<IResult> UpdateCarAsync([FromBody] Car car, ISender sender, CancellationToken cancellationToken)
    {
        var carModel = await sender.Send(new UpdateCarRequest(car), cancellationToken);
        return Results.Ok(carModel);
    }
}
