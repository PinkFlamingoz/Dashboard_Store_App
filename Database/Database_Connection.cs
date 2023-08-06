using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Dashboard_Store_App.Database
{
    public abstract class Database_Connection
    {
        // Property to hold the connection string
        protected readonly string connection_string;

        // Constructor
        public Database_Connection(IConfiguration configuration)
        {
            // Get connection string and throw an error with null-coalescing operator (??) if the connection string is null
            connection_string = configuration.GetConnectionString("MyDatabase") ?? throw new InvalidOperationException("Connection string is not initialized in the configuration.");
        }

        // Create and return a connection
        protected SqlConnection Get_Connection()
        {
            // Create a new SqlConnection object using the connection string
            return new SqlConnection(connection_string);
        }
    }
}