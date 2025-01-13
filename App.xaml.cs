using MauiAppSolo.Data;
using Microsoft.Maui.Controls;

namespace MauiAppSolo
{
    public partial class App : Application
    {
        private readonly WorkoutContext _workoutContext;

        public App()
        {
            InitializeComponent();

            // Initialize the WorkoutContext with the database path
            var dbPath = Path.Combine(FileSystem.AppDataDirectory, "workouts.db3");
            _workoutContext = new WorkoutContext(dbPath);
        }

        protected override Window CreateWindow(IActivationState activationState) =>
            new Window(new NavigationPage(new MainPage(_workoutContext)))
            {
                Width = 600,
                Height = 900,
                X = 100,
                Y = 100
            };
    }
}
