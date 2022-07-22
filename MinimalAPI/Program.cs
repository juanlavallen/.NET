using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MinimalAPI.Models;
using MinimalAPI.Data;
using MinimalAPI.Dtos;

var builder = WebApplication.CreateBuilder(args);

var dbConnect = builder.Configuration.GetConnectionString("DbConnection");

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(dbConnect)
);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("api/commands", async (ICommandRepo repo, IMapper mapper) => {
    var commands = await repo.GetAllCommands();
    return Results.Ok(mapper.Map<IEnumerable<CommandReadDto>>(commands));
});

app.MapGet("api/commands/{id}", async (ICommandRepo repo, IMapper mapper, int id) => {
    var command = await repo.GetCommandById(id);
    if (command != null)
    {
        return Results.Ok(mapper.Map<CommandReadDto>(command));
    }
    return Results.NotFound();
});

app.MapPost("api/commands", async (ICommandRepo repo, IMapper mapper, CommandCreateDto command) => {
    var commandModel = mapper.Map<Command>(command);
    await repo.CreateCommand(commandModel);
    await repo.SaveChanges();

    var commandReadDto = mapper.Map<CommandReadDto>(commandModel);

    return Results.Created($"api/commands{commandReadDto.Id}", commandReadDto);
});

app.MapPut("api/commands/{id}", async (ICommandRepo repo, IMapper mapper, int id, CommandUpdateDto commandUpdate) => {
    var command = await repo.GetCommandById(id);
    if (command == null)
    {
        return Results.NotFound();
    }

    mapper.Map(commandUpdate, command);
    await repo.SaveChanges();

    return Results.NoContent();
});

app.MapDelete("api/commands/{id}", async (ICommandRepo repo, IMapper mapper, int id) => {
    var command = await repo.GetCommandById(id);
    if(command == null) 
    {
        return Results.NotFound();
    }

    repo.DeleteCommand(command);
    await repo.SaveChanges();

    return Results.NoContent();
});

app.Run();
