using MauiAppSolo.Models;
using MauiAppSolo.Data;

namespace MauiAppSolo;

public partial class MainPage : ContentPage
{
    private readonly WorkoutContext _database;

    public MainPage(WorkoutContext database)
    {
        InitializeComponent();
        _database = database;
    }

    private async void OnPlanWorkoutClicked(object sender, EventArgs e)
    {
        try
        {
            var workout = new Workout
            {
                Name = "New Workout",
                Date = DateTime.Now,
            };

            var workoutPage = new WorkoutPage
            {
                BindingContext = workout
            };

            await Navigation.PushAsync(workoutPage);
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"Unable to plan a workout: {ex.Message}", "OK");
        }
    }

    private async void OnViewHistoryClicked(object sender, EventArgs e)
    {
        try
        {
            var workouts = await _database.GetWorkoutsAsync();
            if (workouts == null || !workouts.Any())
            {
                await DisplayAlert("No Workouts", "No workout history found.", "OK");
                return;
            }

            var workoutHistoryPage = new WorkoutHistoryPage(workouts);
            await Navigation.PushAsync(workoutHistoryPage);
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"Unable to view workout history: {ex.Message}", "OK");
        }
    }

    private async void OnSettingsClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Settings", "Navigating to the Settings page...", "OK");
        // Navigate to the SettingsPage (replace with actual navigation logic)
    }
}
