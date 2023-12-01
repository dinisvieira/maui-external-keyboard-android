using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiAppExternalKeyboard
{
    public partial class MainPageViewModel : ObservableObject
    {
        private string _message = string.Empty;
        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }

        private string _entryValue = string.Empty;
        public string EntryValue
        {
            get => _entryValue;
            set => SetProperty(ref _entryValue, value);
        }

        public ICommand SubmitCommand { get; }

        public MainPageViewModel()
        {
            SubmitCommand = new AsyncRelayCommand(async () =>
            {
                Message = $"Submit called, text value: '{_entryValue}'";
            });
        }
    }
}
