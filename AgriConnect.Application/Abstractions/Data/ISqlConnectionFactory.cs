using System.Data;

namespace AgriConnect.Application.Abstractions.Data;


public interface ISqlConnectionFactory
{
    IDbConnection CreateConnection();
}