var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer()
    .AddSwaggerGen()
    .AddDependencies(); 


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseSwagger()
    .UseSwaggerUI()
    .UseAuthorization()
    .UseGraphQLGraphiQL();

app.MapControllers();

try
{
    Log.Information("Configuring application...");

    app.RunAsync().ConfigureAwait(false);
}
catch (Exception ex)
{
    Log.Fatal(ex, "Program terminated unexpectedly!");    
}
finally
{
    Log.CloseAndFlush();    
}



