public class Exercise
{
	public int Id { get; set; }
	public string Name { get; set; }
	public int Sets { get; set; }
	public int Reps { get; set; }
	public TimeSpan Duration { get; set; } // nt Plangi kestus
	public int WorkoutId { get; set; } // Seos Workout tabeliga (võõrvõti)
}
