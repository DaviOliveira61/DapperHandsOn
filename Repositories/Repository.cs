using BaltaDataAccessHandsOn.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace BaltaDataAccessHandsOn.Repositories
{
    public class Repository<T> where T : class
    {
        // private readonly SqlConnection _connection;
        // public Repository(SqlConnection connection) => _connection = connection;
        public IEnumerable<T> Get() => Database.Connection.GetAll<T>();
        public T Get(int id) => Database.Connection.Get<T>(id);
        public void Create(T model) => Database.Connection.Insert<T>(model);
        public void Update(T model) => Database.Connection.Update<T>(model);
        public void Delete(T model) => Database.Connection.Delete<T>(model);
        public void Delete(int id)
        {
            var model = Database.Connection.Get<T>(id);
            Database.Connection.Delete<T>(model);
        }
    }
}