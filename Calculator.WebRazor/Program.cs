using Calculator.WebRazor;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Calling add http client to enable IHttpClientFactory usage in the application (to the container).
//builder.Services.AddHttpClient();

//Adding own httpClient with name
//builder.Services.AddHttpClient("CalculatorAPI", httpClient =>
//{
//    httpClient.BaseAddress = new Uri("http://localhost:5062");
//});

//builder.Services.AddHttpClient("WeatherForecastApi", httpClient =>
//{
//    httpClient.BaseAddress = new Uri("http://www.weatherforecast.com");
//});

// TODO clean up project namings xxx.yyy (e.g. CalculatorApi -> Calculator.WebApi)
//TODO extract API client to new project related to API server project (Calculator.WebApi.Client)

//TODO why it should not be in web application project
//TODO in new project create extension method for using here instead of following row - example in OCTOCAT
builder.Services.AddHttpClient<LocalhostCalculatorApiClient>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();