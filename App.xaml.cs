using Microsoft.Maui.Controls;

namespace MauiAppSolo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }
            protected override Window CreateWindow(IActivationState activationState) =>
                new Window(new MainPage())
                {
                    Width = 600,
                    Height = 900,
                    X = 100,
                    Y = 100
                };
    }
}
