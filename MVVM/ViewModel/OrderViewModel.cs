using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BezorgApp.MVVM.ViewModel
{
    public partial class OrderViewModel : ObservableObject
    {
        //private readonly Func<OrderViewModel, Task> _onSave;
        //private readonly Func<OrderViewModel, Task> _onDelete;

        //public int Id { get; set; }
        //public string? Name { get; set; }
        //public string? QrCode { get; set; }
        //public string? Status { get; set; }
        //public bool IsEditing { get; set; }

        //public string DisplayId => $"Order {Id}";

        //[ObservableProperty]
        //private string _name;
        //[ObservableProperty]
        //private string _qrCode;
        //[ObservableProperty]
        //private string _status;

        //[ObservableProperty]
        //private bool _isEditing;

        //public OrderViewModel(Model.Order order, Func<OrderViewModel, Task> onSave, Func<OrderViewModel, Task> onDelete)
        //{
        //    _onSave = onSave;
        //    _onDelete = onDelete;

        //}

        //[RelayCommand]
        //private void EditOrder()
        //{
        //    IsEditing = true;
        //}

        //[RelayCommand]
        //private async Task SaveOrder()
        //{
        //    IsEditing = false;

        //    await _onSave(this);
        //}

        //[RelayCommand]
        //private async Task DeleteOrder()
        //{
        //    await _onDelete(this);
        //}

    }
}