using MauiAppSolo.Models;
using MauiAppSolo.Data;

namespace MauiAppSolo;

public partial class WorkoutHistoryPage : ContentPage
{
    public WorkoutHistoryPage(List<Workout> workoutHistory)
    {
        WorkoutsListView.ItemsSource = workoutHistory;
    }
}
