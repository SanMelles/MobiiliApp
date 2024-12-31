using Microsoft.EntityFrameworkCore;

public class WorkoutContext : DbContext
{
    public DbSet<Workout> Workouts { get; set; }
    public DbSet<Exercise> Exercises { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Filename=workout.db");
    }
}
