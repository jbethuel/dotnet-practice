class DatabaseUtils
{
    private IConfiguration _configuration;

    public DatabaseUtils(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string GetDatabaseConnectionString()
    {
        var connectionString = _configuration.GetSection("MongoDB_ConnectionString").Value;

        if (connectionString is null)
        {
            throw new Exception("No database connection");
        }

        return connectionString;
    }
}
