using MauiAppSolo.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls;

namespace MauiAppSolo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Register WorkoutContext as a singleton service
            var services = new ServiceCollection();
            services.AddSingleton<WorkoutContext>();

            // Build the service provider
            ServiceProvider = services.BuildServiceProvider();

            MainPage = new AppShell();
        }

        public static IServiceProvider ServiceProvider { get; private set; }

        protected override Window CreateWindow(IActivationState activationState)
        {
            // Resolve WorkoutContext from the service provider
            var workoutContext = ServiceProvider.GetRequiredService<WorkoutContext>();

            return new Window(new NavigationPage(new MainPage(workoutContext)))
            {
                Width = 600,
                Height = 900,
                X = 100,
                Y = 100
            };
        }
    }
}
