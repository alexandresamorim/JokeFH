using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace JokeFH.Infra.Data.Repository
{
    public class RepositoryBase : IDisposable
    {
        public IDbConnection Connection
        {
            get
            {

                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
                var connectionString = configuration.GetConnectionString("DefaultConnection");

                return new SqlConnection(connectionString);
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}