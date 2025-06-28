using BezorgApp.Data;
using BezorgApp.MVVM.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BezorgApp.MVVM.ViewModel
{
    public partial class MainPageViewModel : ObservableObject
    {
        //private readonly SQLiteConnection _connection;

        //private readonly ObservableCollection<OrderViewModel> _orders;
        //public IEnumerable<OrderViewModel> Orders => _orders;

        //[ObservableProperty]
        //private string _name = string.Empty;
        //[ObservableProperty]
        //private string _qrCode = string.Empty;
        //[ObservableProperty]
        //private string _status = string.Empty;

        //public MainPageViewModel(SQLiteConnection connection)
        //{
        //    _orders = new ObservableCollection<OrderViewModel>();
        //    _connection = connection;
        //    LoadOrderCommand.Execute(null);
        //}

        //[RelayCommand]
        //private async Task LoadOrder()
        //{
        //    ISQLiteAsyncConnection database = _connection.CreateConnection();
        //    List<OrderDb> orderDb = await database.Table<OrderDb>().ToListAsync();

        //    foreach (OrderDb db in orderDb)
        //    {
        //        _orders.Add(
        //            new OrderViewModel(new Model.Order(db.Id, db.Name, db.QrCode, db.Status),
        //            HandleOrderSave,
        //            HandleOrderDelete));
        //    }
        //}

        //[RelayCommand]
        //private async Task CreateOrder()
        //{
        //    ISQLiteAsyncConnection database = _connection.CreateConnection();
        //    OrderDb orderDb = new OrderDb();
        //    {
        //        orderDb.Name = _name;
        //        orderDb.QrCode = _qrCode;
        //        orderDb.Status = _status;
        //    }

        //    await database.InsertAsync(orderDb);

        //    _orders.Add(
        //        new OrderViewModel(
        //            new Order(orderDb.Id, orderDb.Name, orderDb.QrCode, orderDb.Status),
        //            HandleOrderSave,
        //            HandleOrderDelete));
        //    Name = string.Empty;
        //    QrCode = string.Empty;
        //    Status = string.Empty;
        //}

        //private async Task HandleOrderSave(OrderViewModel order)
        //{
        //    ISQLiteAsyncConnection database = _connection.CreateCommand();
        //    OrderDb orderDb = new OrderDb()
        //    {
        //        Id = order.Id,
        //        Name = order.Name,
        //        QrCode = order.QrCode,
        //        Status = order.Status
        //    };

        //    await database.UpdateAsync(orderDb);
        //}

        //private async Task HandleOrderDelete(OrderViewModel order)
        //{
        //    ISQLiteAsyncConnection database = _connection.CreateConnection();
        //    OrderDb orderDb = new OrderDb()
        //    {
        //        Id = order.Id,
        //        Name = order.Name,
        //        QrCode = order.QrCode,
        //        Status = order.Status
        //    };

        //    await database.DeleteAsync(orderDb);

        //    _orders.Remove(order);
        //}
    }
}
