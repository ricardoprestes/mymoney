using System;
using FluentAssertions;
using MyMoney.ViewModels;

namespace MyMoneyTests.ViewModels
{
    public class DashBoardViewModelTest
    {
        [Fact]
        public void ShouldBeDefaultValues()
        {
            var viewModel = new DashboardViewModel();

            viewModel.Balance.Should().Be(default);
            viewModel.Revenues.Should().Be(default);
            viewModel.Expenses.Should().Be(default);
        }
    }
}

