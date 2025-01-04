
namespace MauiAppSolo.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private string welcomeMessage;

        public string WelcomeMessage
        {
            get => welcomeMessage;
            set => SetProperty(ref welcomeMessage, value);
        }

        public MainPageViewModel()
        {
            WelcomeMessage = "Welcome to Workout Tracker!";
        }
    }
}
