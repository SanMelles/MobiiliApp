using SQLite;

namespace MauiAppSolo.Models
{
    public class Workout
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public ICollection<Exercise> Exercises { get; set; } = new List<Exercise>();
    }
}
