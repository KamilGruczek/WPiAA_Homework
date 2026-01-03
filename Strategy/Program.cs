using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Strategy.Interfaces;
using Strategy.PhotoStrategies;
using Strategy.Services;

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration(o => o.AddJsonFile("appsettings.json", false, false).AddUserSecrets<Program>())
.ConfigureServices((_, services) =>
{
    services.AddSingleton<ICallApiService, CallApiService>();
    services.AddSingleton<IRedactionService, RedactionService>();
    services.AddSingleton<PexelsStrategy>();
    services.AddSingleton<PixabayStrategy>();
    services.AddSingleton<Application>();
})
.Build();

var app = host.Services.GetRequiredService<Application>();
await app.RunAsync();

internal class Application(IRedactionService redactionService, PexelsStrategy pexelsStrategy, PixabayStrategy pixabayStrategy)
{
    public async Task RunAsync()
    {
        //Accepted values: backgrounds, fashion, nature, science, education, feelings, health, people, religion, places, animals, industry, computer, food, sports, transportation, travel, buildings, business, music
        var categories = new List<string> { "backgrounds", "fashion", "nature", "science", "education", "feelings", "health", "people", "religion", "places", "animals", "industry", "computer", "food", "sports", "transportation", "travel", "buildings", "business", "music" };
        Console.WriteLine("Hello in Strategy App.");
        Console.WriteLine("Available categories:");
        foreach (var cat in categories)
        {
            Console.WriteLine($"- {cat}");
        }
        Console.WriteLine("Enter category name to get photos:");
        var category = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(category))
        {
            Console.WriteLine("Category name cannot be empty.");
            Console.ReadKey();
            return;
        }

        if (!categories.Contains(category))
        {
            Console.WriteLine("Invalid category name.");
            Console.ReadKey();
            return;
        }

        redactionService.SetStrategy(pexelsStrategy);
        var photos = await redactionService.GetPhotosAsync(category);
        if (photos == null || !photos.Any())
        {
            Console.WriteLine("Could not retrieve photos. Please check the category name and try again.");
            Console.ReadKey();
            return;
        }

        Console.WriteLine($"Pexels Photos in {category}:");
        foreach (var photo in photos)
        {
            Console.WriteLine($"- {photo}");
        }
        redactionService.SetStrategy(pixabayStrategy);
        photos = await redactionService.GetPhotosAsync(category);
        if (photos == null || !photos.Any())
        {
            Console.WriteLine("Could not retrieve photos. Please check the category name and try again.");
            Console.ReadKey();
            return;
        }

        Console.WriteLine($"Pixabay Photos in {category}:");
        foreach (var photo in photos)
        {
            Console.WriteLine($"- {photo}");
        }

        Console.WriteLine("Have a beautiful day!");
        Console.ReadKey();
    }
}