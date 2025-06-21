using Microsoft.Data.SqlClient;

using PhoneCatalog.Models;
using System.Data;

namespace PhoneCatalog.Repository;

public class PersonRepository
{
    private readonly Connection _connection;

    public PersonRepository(Connection connection)
    {
        _connection = connection;
    }

    public async Task<bool> CreateAsync(Person person)
    {
        string query = @"INSERT INTO Person (FirstName, LastName)
                        VALUES (@FirstName, @LastName)";

        await using(SqlConnection connection = new SqlConnection(_connection.DefaultConnection))
        {
            await connection.OpenAsync();

            await using(SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@FirstName", person.FirstName);
                command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = person.LastName;

                int affectedRows = await command.ExecuteNonQueryAsync();
                return affectedRows > 0;
            }
        }
    }
}
