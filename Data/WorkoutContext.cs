using SQLite;
using MauiAppSolo.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MauiAppSolo.Data
{
    public class WorkoutAppDbContext : IAsyncDisposable
    {
        private const string DbName = "WorkoutDb";
        private static string DbPath => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DbName);

        private SQLiteAsyncConnection _connection;
        private SQLiteAsyncConnection Database => (_connection ??= new SQLiteAsyncConnection(DbPath));

        // Create tables if they don't exist
        public async Task InitializeDatabaseAsync()
        {
            await Database.CreateTableAsync<Workout>();
            await Database.CreateTableAsync<Exercise>();
            await Database.CreateTableAsync<WorkoutHistory>();
        }

        // Add a workout
        public async Task<int> AddWorkoutAsync(Workout workout)
        {
            return await Database.InsertAsync(workout);
        }

        // Get all workouts
        public async Task<List<Workout>> GetAllWorkoutsAsync()
        {
            return await Database.Table<Workout>().ToListAsync();
        }

        // Get workout by id
        public async Task<Workout> GetWorkoutByIdAsync(int id)
        {
            return await Database.Table<Workout>().FirstOrDefaultAsync(w => w.Id == id);
        }

        // Get exercises for a specific workout
        public async Task<List<Exercise>> GetExercisesForWorkoutAsync(int workoutId)
        {
            return await Database.Table<Exercise>().Where(e => e.WorkoutId == workoutId).ToListAsync();
        }

        // Add exercise
        public async Task<int> AddExerciseAsync(Exercise exercise)
        {
            return await Database.InsertAsync(exercise);
        }

        // Delete workout
        public async Task<int> DeleteWorkoutAsync(Workout workout)
        {
            return await Database.DeleteAsync(workout);
        }

        // Dispose the connection
        public async ValueTask DisposeAsync()
        {
            if (_connection != null)
            {
                await _connection.CloseAsync();
            }
        }
    }
}
