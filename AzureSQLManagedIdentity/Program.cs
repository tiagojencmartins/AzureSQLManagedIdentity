using AzureSQLManagedIdentity.Database;
using Microsoft.EntityFrameworkCore;

namespace AzureSQLManagedIdentity
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<DatabaseContext>(
                    options => options.UseSqlServer(builder.Configuration.GetConnectionString("Database")));

            builder.Services.AddControllers();

            var app = builder.Build();

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}