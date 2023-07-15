namespace dotnet_practice.Models;

public class BookStoreDatabaseSettingsModel
{
    public string DatabaseName { get; } = "sample_analytics";

    public string BooksCollectionName { get; } = "books";
}
