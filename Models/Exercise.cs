public class Exercise
{
	public int Id { get; set; }
	public string Name { get; set; }
	public int Sets { get; set; }
	public int Reps { get; set; }
	public double? Weight { get; set; }
	public int WorkoutId { get; set; } // Seos Workout tabeliga (v��rv�ti)
}
