using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


namespace Api
{
    public class PersistenceContextFactory : IDesignTimeDbContextFactory<Context>
    {
        public Context CreateDbContext(string[] args)
        {
             var Config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
                
            var optionsBuilder = new DbContextOptionsBuilder<Context>();
            optionsBuilder.UseSqlServer(Config.GetConnectionString("database"), sqlopts =>
            {
                sqlopts.MigrationsHistoryTable("_MigrationHistory", Config.GetValue<string>("SchemaName"));
            });

            return new Context(optionsBuilder.Options, Config);
        }
    }
}