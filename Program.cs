using CafeteriaAromaGrao;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapPost("/pedido/calcular", (PedidoRequest request) =>
{
    Pedido pedido = new Pedido();

    double total = pedido.CalcularTotal(request.Valor, request.Quantidade);

    return Results.Ok(new
    {
        total = total
    });
});

app.Run();

public class PedidoRequest
{
    public double Valor { get; set; }
    public int Quantidade { get; set; }
}