using MauiAppSolo.Models;
using MauiAppSolo.Data;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

namespace MauiAppSolo;

public partial class WorkoutPage : ContentPage
{
    private readonly WorkoutContext _database;
    private Workout _workout;
    public List<Exercise> AvailableExercises { get; set; }

    public WorkoutPage(WorkoutContext database)
    {
        InitializeComponent();
        _database = database;
        _workout = new Workout();
        BindingContext = this;

        LoadAvailableExercises();
    }

    private async void OnAddExerciseClicked(object sender, EventArgs e)
    {
        if (AvailableExercisesListView.SelectedItem != null)
        {
            var selectedExercise = (Exercise)AvailableExercisesListView.SelectedItem;
            _workout.Exercises.Add(selectedExercise);
            OnPropertyChanged(nameof(_workout.Exercises));
        }
    }

    private async Task LoadAvailableExercises()
    {
        try
        {
            AvailableExercises = await _database.GetExercisesAsync();
            OnPropertyChanged(nameof(AvailableExercises));
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"Failed to load exercises: {ex.Message}", "OK");
        }
    }

    private async void OnSaveWorkoutClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(WorkoutNameEntry.Text))
        {
            await DisplayAlert("Validation Error", "Workout name cannot be empty.", "OK");
            return;
        }

        _workout.Name = WorkoutNameEntry.Text;
        _workout.Date = DateTime.Now;

        try
        {
            await _database.SaveWorkoutAsync(_workout);
            await DisplayAlert("Success", "Workout saved successfully!", "OK");
            await Navigation.PopAsync();
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"Failed to save workout: {ex.Message}", "OK");
        }
    }
}