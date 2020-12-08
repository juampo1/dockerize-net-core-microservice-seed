using MySqlConnector;
using System;
using System.Data;

namespace Persistence.Repositories
{
    public class BaseRepository
    {
        private readonly string _connectionString;

        public BaseRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);
        }

        protected T Query<T>(Func<IDbConnection, T> data)
        {
            using(MySqlConnection mysqlConnection = new MySqlConnection(_connectionString))
            {
                mysqlConnection.Open();
                return data((IDbConnection) mysqlConnection);
            }
        }
    }
}
