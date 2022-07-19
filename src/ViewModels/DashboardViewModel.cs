using CommunityToolkit.Mvvm.ComponentModel;

namespace MyMoney.ViewModels
{
    public partial class DashboardViewModel : BaseViewModel
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(BalanceFormated))]
        decimal balance;

        public string BalanceFormated => string.Format("R$ {0:###,###,###,##0.00}", Balance);

        public DashboardViewModel()
        {
            Balance = 999999;
        }
    }
}

