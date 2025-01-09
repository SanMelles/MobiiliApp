using Microsoft.Maui.Controls;

namespace MauiAppSolo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
