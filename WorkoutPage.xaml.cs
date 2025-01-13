using MauiAppSolo.Models;
using System.Collections.ObjectModel;
using MauiAppSolo.Data;

namespace MauiAppSolo
{
    public partial class WorkoutPage : ContentPage
    {
        private readonly WorkoutContext _database;

        public WorkoutPage()
        {
            _database = new WorkoutContext(Path.Combine(FileSystem.AppDataDirectory, "workouts.db3"));
        }

        private async void SaveWorkout(object sender, EventArgs e)
        {
            if (BindingContext is Workout workout)
            {
                await _database.SaveWorkoutAsync(workout);
                await DisplayAlert("Success", "Workout saved!", "OK");
                await Navigation.PopAsync();  // Go back to the previous page
            }
        }
    }

}
