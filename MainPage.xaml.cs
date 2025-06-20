using BezorgApp.MVVM.View;

namespace BezorgApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnOpenCameraClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Scan_page());
        }
    }
}
