using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MauiAppSolo.ViewModels
{
    public class WorkoutViewModel : BaseViewModel
    {
        private string name;
        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        private DateTime date;
        public DateTime Date
        {
            get => date;
            set => SetProperty(ref date, value);
        }

        public ObservableCollection<Exercise> Exercises { get; set; } = new();

        public Command AddExerciseCommand { get; }
        public WorkoutViewModel()
        {
            AddExerciseCommand = new Command(OnAddExercise);
        }

        private void OnAddExercise()
        {
            // Logic to add an exercise
            Exercises.Add(new Exercise());
        }
    }
}