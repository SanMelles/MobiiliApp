using SQLite;

namespace MauiAppSolo.Models
{
    public class Workout
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public List<Exercise> Exercises { get; set; }

        public Workout()
        {
            Exercises = new List<Exercise>();
        }
    }

    public class Exercise
    {
        public string Name { get; set; }
        public List<ExerciseInfo> ExerciseInfos { get; set; }

        public Exercise()
        {
            ExerciseInfos = new List<ExerciseInfo>();
        }
    }

    public class ExerciseInfo
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Reps { get; set; }
        public int Sets { get; set; }
        public double? Weight { get; set; }
        public int WorkoutId { get; set; }
    }
}