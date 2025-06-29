using BezorgApp.Data;
using BezorgApp.MVVM.Model;
using BezorgApp.MVVM.View;
using System.Threading.Tasks;

namespace BezorgApp
{
    public partial class MainPage : ContentPage
    {

        private readonly SQLite_Connection sQLite_Connection;
        private int _editOrderId;

        public MainPage(SQLite_Connection connection)
        {
            InitializeComponent();
            sQLite_Connection = connection;
            Task.Run(async () => listView.ItemsSource = await sQLite_Connection.GetOrders());
        }

        //private void InitializeComponent()
        //{
        //    throw new NotImplementedException();
        //}

        private async void saveButton_Clicked(object sender, EventArgs e)
        {
            if (_editOrderId == 0)
            {
                // Add an Order
                await sQLite_Connection.Create(new Order
                {
                    Name = nameEntryField.Text,
                    QrCode = qrcodeEntryField.Text,
                    Status = statusEntryField.Text
                });
            }
            else
            {
                // Edit Order
                await sQLite_Connection.Update(new Order
                {
                    Id = _editOrderId,
                    Name = nameEntryField.Text,
                    QrCode = qrcodeEntryField.Text,
                    Status = statusEntryField.Text
                });

                _editOrderId = 0;
            }

            nameEntryField.Text = string.Empty;
            qrcodeEntryField.Text = string.Empty;
            statusEntryField.Text = string.Empty;

            listView.ItemsSource = await sQLite_Connection.GetOrders();

        }

        private async void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var order = (Order)e.Item;
            var action = await DisplayActionSheet("Action", "Cancel", null, "Edit", "Delete");

            switch (action)
            {
                case "Edit":
                    _editOrderId = order.Id;
                    nameEntryField.Text = order.Name;
                    qrcodeEntryField.Text = order.QrCode;
                    statusEntryField.Text = order.Status;
                    break;
                case "Delete":
                    await sQLite_Connection.Delete(order);
                    listView.ItemsSource = await sQLite_Connection.GetOrders();
                    break;
            }
        }

        private async void OnOpenCameraClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Scan_page());
        }
    }
}
