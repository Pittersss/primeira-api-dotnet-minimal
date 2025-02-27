using Microsoft.AspNetCore.Mvc;
using MinimalApi.DTOs;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapPost("/login", (LoginDTO loginDTO) =>
{
    if(loginDTO.Email == "adm@teste.com" && loginDTO.Senha == "123456")
    {
        return Results.Ok("Funcionou");
    }
    else{
        return Results.Unauthorized();
    }
});
app.Run();
