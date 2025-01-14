using SQLite;
using System;
using System.Collections.Generic;

namespace MauiAppSolo.Models
{
    // Workout class
    public class Workout
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }

        // List of Exercises related to this workout
        public List<Exercise> Exercises { get; set; }

        public Workout()
        {
            Exercises = new List<Exercise>();
        }
    }

    // Exercise class
    public class Exercise
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }  // Unique ID for Exercise
        public string Name { get; set; }  // Name of the exercise

        // Foreign key that links Exercise to Workout
        public int WorkoutId { get; set; }

        // List of ExerciseInfo related to this exercise
        public List<ExerciseInfo> ExerciseInfos { get; set; }

        public Exercise()
        {
            ExerciseInfos = new List<ExerciseInfo>();
        }
    }

    // ExerciseInfo class (each set/reps entry for an exercise)
    public class ExerciseInfo
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Reps { get; set; }
        public int Sets { get; set; }
        public double? Weight { get; set; }

        // Foreign key linking ExerciseInfo to Exercise
        public int ExerciseId { get; set; }
    }
}
