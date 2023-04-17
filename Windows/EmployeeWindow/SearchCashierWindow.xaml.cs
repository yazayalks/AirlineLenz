using AirlineLenz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AirlineLenz.Windows.EmployeeWindow
{
    /// <summary>
    /// Логика взаимодействия для SearchCashierWindow.xaml
    /// </summary>
    public partial class SearchCashierWindow : Window
    {
        private readonly AirlineLenzDbContext dbContext;
        public Ticket Ticket { get; set; }
        public SearchCashierWindow(AirlineLenzDbContext dbContext, Ticket ticket)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            DataContext = this;

            Ticket = ticket;

            RefreshCashierGrid();
        }

        private void RefreshCashierGrid()
        {
            var search = SearchTextBox.Text.ToLower();
            CashierGrid.ItemsSource = dbContext.Employees
                .Where(x => (x.FirstName.ToLower().Contains(search) || x.LastName.ToLower().Contains(search) || x.Patronymic.ToLower().Contains(search)) && x.EmployeeType == EmployeeType.Cashier)
                .ToList();
            CashierGrid.Items.Refresh();
        }

        private void ChoiseButtonClick(object sender, RoutedEventArgs e)
        {
            if (CashierGrid.SelectedItems.Count == 1)
            {
               
                Ticket.Employee = (Employee)CashierGrid.SelectedItems[0]!;
            }
            Close();
        }

        private void SearchButtonClick(object sender, RoutedEventArgs e)
        {
            RefreshCashierGrid();
        }
    }
}
