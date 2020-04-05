using EducatioNow.Utils;
using Microsoft.Extensions.Options;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace EducatioNow.Data
{
    public class Repository
    {
        protected static IOptions<ConnectionStringOption> ConnectionStringOptions { get; private set; }

        public Repository(IOptions<ConnectionStringOption> connectionString)
        {
            ConnectionStringOptions = connectionString;
        }

        protected IDbConnection CreateOracleConnection() //string connectionName = "OracleConnection"
        {
            return new OracleConnection(ConnectionStringOptions.Value.OracleConnection);
        }
    }
}
