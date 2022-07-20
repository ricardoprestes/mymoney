using CommunityToolkit.Mvvm.ComponentModel;

namespace MyMoney.ViewModels
{
    public partial class DashboardViewModel : BaseViewModel
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(BalanceFormated))]
        decimal balance;
        public string BalanceFormated => string.Format("R$ {0:###,###,###,##0.00}", Balance);

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(RevenuesFormated))]
        decimal revenues;
        public string RevenuesFormated => string.Format("R$ {0:###,###,###,##0.00}", Revenues);

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(ExpensesFormated))]
        decimal expenses;
        public string ExpensesFormated => string.Format("R$ {0:###,###,###,##0.00}", Expenses);

    }
}

