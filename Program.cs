using ezbooking.Forms;
using ezbooking.Models;
using Microsoft.Extensions.DependencyInjection;

namespace ezbooking;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        // Configure services
        var services = new ServiceCollection();
        ConfigureServices(services);

        // Build service provider
        var serviceProvider = services.BuildServiceProvider();

        // Show the login form
        Application.Run(serviceProvider.GetRequiredService<LoginForm>());
    }

    static void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>();
        // Add your services here
        services.AddSingleton<LoginForm>();
        services.AddSingleton<AppForm>();
        services.AddScoped<AddUpdateBacSiForm>();
    }
}