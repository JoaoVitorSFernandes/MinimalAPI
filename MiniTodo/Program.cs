using MiniTodo.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>();

var app = builder.Build();

app.MapGet("/", () => {
    var todo = new Todo(Guid.NewGuid(), "Ir a academia", false);
    return Results.Ok(todo);
});


app.Run();
