using Npgsql;

namespace CarSale.DataAccess.Repositories;

public class BaseRepository
{
    protected readonly NpgsqlConnection _connection;

    public BaseRepository()
    {
        Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;
        _connection = new NpgsqlConnection("Host=localhost; Port=5432; Database = avto-bozor-new-db; User Id = postgres; Password = 9639;");
    }

}
