using MinimalApi;
using MinimalApi.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<UzduotisDb>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddRazorPages();


var app = builder.Build();


app.MapGet("/topten", Operations.GetTopTen);
app.MapGet("/topten/{n}", Operations.GetTopTen);

app.MapGet("/abovemean", Operations.GetAboveMean);
app.MapGet("/abovemean/{n}", Operations.GetAboveMean);



app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();