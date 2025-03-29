

var builder = WebApplication.CreateBuilder(args);

// Add controllers service
builder.Services.AddControllers();

var app = builder.Build();

// Enable routing for controllers
app.UseRouting();
app.UseAuthorization();
app.MapControllers();

app.Run();


// var builder = WebApplication.CreateBuilder(args);

// // Enable CORS
// builder.Services.AddCors(options =>
// {
//     options.AddPolicy("AllowAll", policy =>
//     {
//         policy.AllowAnyOrigin()
//               .AllowAnyMethod()
//               .AllowAnyHeader();
//     });
// });

// var app = builder.Build();

// app.UseCors("AllowAll");
// app.UseAuthorization();
// app.MapControllers();
// app.Run();


