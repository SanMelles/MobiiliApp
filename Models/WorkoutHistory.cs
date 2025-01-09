using SQLite;

namespace MauiAppSolo.Models
{
    public class WorkoutHistory
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public DateTime CompletedDate { get; set; }
        public List<Workout> Workouts { get; set; }
    }
}
