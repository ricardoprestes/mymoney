using CommunityToolkit.Mvvm.ComponentModel;

namespace MyMoney.ViewModels
{
    public abstract partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        bool isBusy;

        public bool IsNotBusy => !IsBusy;

        [ObservableProperty]
        string title;
    }
}

