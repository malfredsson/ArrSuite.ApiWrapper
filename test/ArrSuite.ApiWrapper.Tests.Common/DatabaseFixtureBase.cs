using Microsoft.Data.Sqlite;

namespace ArrSuite.ApiWrapper.Tests.Common;

public class DatabaseFixtureBase : IDisposable
{
    protected SqliteConnection CreateConnection => new($"Data Source={_databaseFilePath}");

    private readonly string _databaseFilePath;
    
    protected DatabaseFixtureBase(string databaseName, string apiVersion)
    {
        _databaseFilePath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, apiVersion, "config", "database", databaseName);

        EnsureCleanDatabase();
    }

    private void EnsureCleanDatabase()
    {
        var sqliteTempFiles = new []
        {
            "shm", "wal"
        };
        
        File.Delete(_databaseFilePath);
        
        foreach (var tempFileSuffixed in sqliteTempFiles
                     .Select(sqliteTempFile => $"{_databaseFilePath}-{sqliteTempFile}"))
        {
            File.Delete(tempFileSuffixed);
        }

        var cleanDatabaseFilePath = $"{_databaseFilePath}-clean";
        
        File.Copy(cleanDatabaseFilePath, _databaseFilePath);
    }

    public void Dispose()
    {
        
    }
}
