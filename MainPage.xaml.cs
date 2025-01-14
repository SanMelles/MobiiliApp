using MauiAppSolo.Data;
using Microsoft.Maui.Controls;

namespace MauiAppSolo;

public partial class MainPage : ContentPage
{
    private readonly WorkoutContext _workoutContext;

    public MainPage(WorkoutContext workoutContext)
    {
        InitializeComponent();
        _workoutContext = workoutContext;

        // Example: Fetch workouts and display in a ListView
        // (Replace with your actual UI implementation)
        var workouts = _workoutContext.GetWorkoutsAsync().Result;
        // ... (bind workouts to a ListView)
    }

    private async void OnPlanWorkoutClicked(object sender, EventArgs e)
    {
        var workoutPage = new WorkoutPage(_workoutContext);
        await Navigation.PushAsync(workoutPage);
    }

    private async void OnViewHistoryClicked(object sender, EventArgs e)
    {
        var workouts = await _workoutContext.GetWorkoutsAsync();
        var workoutHistoryPage = new WorkoutHistoryPage(workouts);
        await Navigation.PushAsync(workoutHistoryPage);
    }

    private async void OnSettingsClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Settings", "Navigating to the Settings page...", "OK");
        // Navigate to the SettingsPage (replace with actual navigation logic)
    }
}