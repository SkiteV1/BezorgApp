using BezorgApp.MVVM.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BezorgApp.Data
{
    public class SQLite_Connection
    {
        private const string DB_NAME = "bezorg_app_db.db3";
        private readonly SQLiteAsyncConnection _connection;

        public SQLite_Connection()
        {
            _connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, DB_NAME));
            _connection.CreateTableAsync<Order>();
        }

        public async Task<List<Order>> GetOrders()
        {
            return await _connection.Table<Order>().ToListAsync();
        }

        public async Task<Order> GetById(int id)
        {
            return await _connection.Table<Order>().Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task Create(Order order)
        {
            await _connection.InsertAsync(order);
        }

        public async Task Update(Order order)
        {
            await _connection.UpdateAsync(order);
        }

        public async Task Delete(Order order)
        {
            await _connection.DeleteAsync(order);
        }

    }
}
