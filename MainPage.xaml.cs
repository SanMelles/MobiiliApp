namespace MauiAppSolo;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnPlanWorkoutClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Plan Workout", "Navigating to the Plan Workout page...", "OK");
        // Navigate to the PlanWorkoutPage (replace with actual navigation logic)
    }

    private async void OnViewHistoryClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Workout History", "Navigating to the Workout History page...", "OK");
        // Navigate to the WorkoutHistoryPage (replace with actual navigation logic)
    }

    private async void OnSettingsClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Settings", "Navigating to the Settings page...", "OK");
        // Navigate to the SettingsPage (replace with actual navigation logic)
    }
}
