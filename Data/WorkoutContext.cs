using SQLite;
using MauiAppSolo.Models;

namespace MauiAppSolo.Data;

public class WorkoutContext
{
    private readonly SQLiteAsyncConnection _database;

    public WorkoutContext(string dbPath)
    {
        _database = new SQLiteAsyncConnection(dbPath);
        InitializeDatabaseAsync().ConfigureAwait(false); // Asynchronously initialize database tables
    }

    private async Task InitializeDatabaseAsync()
    {
        try
        {
            await _database.CreateTableAsync<Workout>();
            await _database.CreateTableAsync<Exercise>();
            await _database.CreateTableAsync<ExerciseInfo>();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error initializing database: {ex.Message}");
        }
    }

    public async Task<List<Workout>> GetWorkoutsAsync()
    {
        try
        {
            return await _database.Table<Workout>().ToListAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error fetching workouts: {ex.Message}");
            return new List<Workout>();
        }
    }

    public async Task<int> SaveWorkoutAsync(Workout workout)
    {
        try
        {
            return workout.Id == 0
                ? await _database.InsertAsync(workout)
                : await _database.UpdateAsync(workout);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving workout: {ex.Message}");
            return 0; // Return 0 to indicate failure
        }
    }

    public async Task<int> DeleteWorkoutAsync(Workout workout)
    {
        try
        {
            return await _database.DeleteAsync(workout);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error deleting workout: {ex.Message}");
            return 0; // Return 0 to indicate failure
        }
    }

    public async Task<Workout> GetWorkoutByIdAsync(int id)
    {
        try
        {
            return await _database.FindAsync<Workout>(id);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error fetching workout by ID: {ex.Message}");
            return null;
        }
    }
}
