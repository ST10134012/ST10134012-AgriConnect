using System.Data;
using AgriConnect.Application.Abstractions.Data;
using Microsoft.Data.SqlClient;

namespace AgriConnect.Infrastructure.Data;

internal sealed class SqlConnectionFactory(string connectionString) : ISqlConnectionFactory
{
    public IDbConnection CreateConnection()
    {
        var connection = new SqlConnection(connectionString);
        connection.Open();

        return connection;
    }
} 