namespace dotnet_practice.Models;

public class BookStoreDatabaseSettings
{
    public string ConnectionString { get; set; } = null!;

    public string DatabaseName { get; } = "sample_analytics";

    public string BooksCollectionName { get; } = "books";
}
