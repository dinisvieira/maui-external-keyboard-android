namespace MauiAppExternalKeyboard
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }

        private void MainPage_OnLoaded(object? sender, EventArgs e)
        {
            _entry.Focus();
        }
    }
}
