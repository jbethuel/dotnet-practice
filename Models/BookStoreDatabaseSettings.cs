namespace dotnet_practice.Models;

public class BookStoreDatabaseSettings
{
    private readonly string _connectionString;

    public BookStoreDatabaseSettings()
    {
        var config = new ConfigurationBuilder().AddUserSecrets<Program>().Build();
        string? connectionString = config["MONGODB_CONNECTION"];

        if (connectionString == null)
        {
            throw new Exception("No database connection");
        }

        _connectionString = connectionString;
    }

    public string ConnectionString()
    {
        return _connectionString;
    }

    public string DatabaseName { get; } = "sample_analytics";

    public string BooksCollectionName { get; } = "books";
}
