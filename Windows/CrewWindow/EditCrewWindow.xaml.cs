using AirlineLenz.Models;
using AirlineLenz.Windows.ChoiseAirportWindow;
using AirlineLenz.Windows.ChoiseEmployeeWindow;
using Microsoft.EntityFrameworkCore;
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

namespace AirlineLenz.Windows.CrewWindow
{
    /// <summary>
    /// Логика взаимодействия для EditCrewWindow.xaml
    /// </summary>
    public partial class EditCrewWindow : Window
    {
        private readonly AirlineLenzDbContext dbContext;
        public Crew Crew { get; set; }
        public bool IsNewCrew{ get; set; } = false;
        public EditCrewWindow(AirlineLenzDbContext dbContext, Crew crew, bool isNewCrew)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            DataContext = this;
            Crew = crew;
            IsNewCrew = isNewCrew;
            RefreshFlightCrewtGrid();

            //this.Closing += EditCrewWindowClosing;
        }

        //private void EditCrewWindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    var MainWindow = new MainWindow();
        //    MainWindow.Show();
        //}


        private void RefreshFlightCrewtGrid()
        {
            FlightCrewGrid.ItemsSource = Crew.Employees?.ToList();
            FlightCrewGrid.Items.Refresh();
        }

        private void DeleteEmployeeButtonClick(object sender, RoutedEventArgs e)
        {
            if (FlightCrewGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < FlightCrewGrid.SelectedItems.Count; i++)
                {
                    if (FlightCrewGrid.SelectedItems[i] is Employee employee)
                    {
                        Crew.Employees.Remove(employee);
                    }
                }
            }
            RefreshFlightCrewtGrid();
        }

        private void AddEmployeeButtonClick(object sender, RoutedEventArgs e)
        {
            var SearchEmployeeWindow = new SearchEmployeeWindow(dbContext, Crew);
            SearchEmployeeWindow.ShowDialog();
            RefreshFlightCrewtGrid();
        }

    

        private void SaveButton(object sender, RoutedEventArgs e)
        {
            if (Crew.Title == null)
            {
                MessageBox.Show("Укажите название экипажа");
                return;
            }
     
            try
            {
                if (IsNewCrew)
                {
                    dbContext.Crews.Add(Crew);
                }
                dbContext.SaveChanges();
                Close();
            }
            catch (DbUpdateException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
