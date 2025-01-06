using System.Windows.Input;
using MauiAppSolo.ViewModels;

namespace MauiAppSolo.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public ICommand NavigateToWorkoutCommand { get; }
        public ICommand NavigateToHistoryCommand { get; }

        public MainPageViewModel()
        {
            // Commands with valid lambdas or method references
            NavigateToWorkoutCommand = new Command(() => NavigateToWorkout());
            NavigateToHistoryCommand = new Command(() => NavigateToHistory());
        }

        private void NavigateToWorkout()
        {
            // TODO: Add navigation logic here
            Console.WriteLine("Navigating to Workout Page...");
        }

        private void NavigateToHistory()
        {
            // TODO: Add navigation logic here
            Console.WriteLine("Navigating to History Page...");
        }
    }
}
