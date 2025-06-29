using BezorgApp.MVVM.View;

namespace BezorgApp
{
    public partial class App : Application
    {
        public App(MainPage mainPage)
        {
            InitializeComponent();

            MainPage = mainPage;
        }
    }
}