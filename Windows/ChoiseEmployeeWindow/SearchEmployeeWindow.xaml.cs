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

namespace AirlineLenz.Windows.ChoiseEmployeeWindow
{
    /// <summary>
    /// Логика взаимодействия для SearchEmployeeWindow.xaml
    /// </summary>
    public partial class SearchEmployeeWindow : Window
    {

        private readonly AirlineLenzDbContext dbContext;
        public Crew Crew { get; set; }
        public SearchEmployeeWindow(AirlineLenzDbContext dbContext, Crew crew)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            DataContext = this;

            Crew = crew;

            RefreshEmployeeGrid();
        }

        private void RefreshEmployeeGrid()
        {
            var search = SearchTextBox.Text.ToLower();
            EmployeeGrid.ItemsSource = dbContext.Employees
                .Where(x => (x.FirstName.ToLower().Contains(search) || x.LastName.ToLower().Contains(search) || x.Patronymic.ToLower().Contains(search)) && x.EmployeeType != EmployeeType.Cashier)
                .ToList();
            EmployeeGrid.Items.Refresh();
        }

        private void ChoiseButtonClick(object sender, RoutedEventArgs e)
        {
            if (EmployeeGrid.SelectedItems.Count == 1)
            {
                if (Crew.Employees == null)
                {
                    Crew.Employees = new List<Employee>();
                }
                if (Crew.Employees.Any(x => x.Id == ((Employee)EmployeeGrid.SelectedItems[0]!).Id))
                {
                    MessageBox.Show("Данный сотрудник уже есть в экипаже");
                    return;
                }
                Crew.Employees.Add((Employee)EmployeeGrid.SelectedItems[0]!);
            }
            Close();
        }

        private void SearchButtonClick(object sender, RoutedEventArgs e)
        {
            RefreshEmployeeGrid();
        }
    }
}
