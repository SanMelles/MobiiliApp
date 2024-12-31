
public class WorkoutHistory
{
    public int Id { get; set; }
    public DateTime CompletedDate { get; set; }
    public List<Workout> Workouts { get; set; }
}