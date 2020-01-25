using Microsoft.Data.Sqlite;
using System.Threading.Tasks;

namespace Issue19396
{
    public class Greeter
    {
        public async Task<string> GetGreeting()
        {
            using var connection = new SqliteConnection();
            connection.ConnectionString = "Data source = :memory:";

            await connection.OpenAsync();

            using var command = connection.CreateCommand();
            command.CommandText = "select 'Hello, world';";

            var output = await command.ExecuteScalarAsync();

            return output as string;
        }
    }
}
