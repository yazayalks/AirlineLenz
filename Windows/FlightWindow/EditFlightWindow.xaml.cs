using AirlineLenz.Models;
using AirlineLenz.Windows.RouteWindow;
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

namespace AirlineLenz.Windows.FlightWindow
{
    /// <summary>
    /// Логика взаимодействия для EditFlightWindow.xaml
    /// </summary>
    public partial class EditFlightWindow : Window
    {
        private readonly AirlineLenzDbContext dbContext;
        public Flight Flight { get; set; }
        public bool IsNewFlight { get; set; } = false;
        public EditFlightWindow(AirlineLenzDbContext dbContext, Flight flight, bool isNewFlight)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            DataContext = this;
            Flight = flight;
            IsNewFlight = isNewFlight;
            RefreshRouteGrid();

            //this.Closing += EditFlightWindowClosing;
        }

        //private void EditFlightWindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    var MainWindow = new MainWindow();
        //    MainWindow.Show();
        //}

        private void RefreshRouteGrid()
        {

            List<Route> newRoutes = new List<Route>();
            if (Flight.Route != null)
            {
                newRoutes.Add(Flight.Route);
            }

            RouteGrid.ItemsSource = newRoutes.ToList();
            RouteGrid.Items.Refresh();
        }



        private void AddRouteButtonClick(object sender, RoutedEventArgs e)
        {
            var searchRouteWindow = new SearchRouteWindow(dbContext, Flight);
            searchRouteWindow.ShowDialog();
            RefreshRouteGrid();
        }

        private void SaveButton(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(Flight.Title))
            {
                MessageBox.Show("Укажите название рейса");
                return;
            }
            if (Flight.Route == null)
            {
                MessageBox.Show("Выберите маршрут");
                return;
            }

            try
            {
                if (IsNewFlight)
                {
                    dbContext.Flights.Add(Flight);
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
