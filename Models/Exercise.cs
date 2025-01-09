using SQLite;

namespace MauiAppSolo.Models
{
    public class Exercise
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
        public double? Weight { get; set; }
        public int WorkoutId { get; set; } // Foreign key
        public Workout Workout { get; set; } // Navigation property
    }

}

