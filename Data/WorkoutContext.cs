using SQLite;
using MauiAppSolo.Models;


namespace MauiAppSolo.Data
{
    public class WorkoutContext
    {
        private readonly SQLiteAsyncConnection _database;

        public WorkoutContext(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
        }

        public async Task InitializeDatabaseAsync()
        {
            await _database.CreateTableAsync<Workout>();
            await _database.CreateTableAsync<Exercise>();
            await _database.CreateTableAsync<ExerciseInfo>();
        }

        public Task<List<Workout>> GetWorkoutsAsync()
        {
            return _database.Table<Workout>().ToListAsync();
        }

        public Task<int> SaveWorkoutAsync(Workout workout)
        {
            if (workout.Id != 0)
            {
                return _database.UpdateAsync(workout);
            }
            else
            {
                return _database.InsertAsync(workout);
            }
        }

        public Task<int> DeleteWorkoutAsync(Workout workout)
        {
            return _database.DeleteAsync(workout);
        }
    }
}
