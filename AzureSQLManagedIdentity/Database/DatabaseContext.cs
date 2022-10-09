using Microsoft.EntityFrameworkCore;

namespace AzureSQLManagedIdentity.Database
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
             : base(options)
        {

        }
    }
}
