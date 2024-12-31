public class MainPageViewModel : BaseViewModel
{
    public Command NavigateToWorkoutCommand { get; }
    public Command NavigateToHistoryCommand { get; }

    public MainPageViewModel()
    {
        NavigateToWorkoutCommand = new Command(async () =>
            await Shell.Current.GoToAsync(nameof(WorkoutPage)));
        NavigateToHistoryCommand = new Command(async () =>
            await Shell.Current.GoToAsync(nameof(HistoryPage)));
    }
}
