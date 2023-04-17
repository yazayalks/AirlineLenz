using AirlineLenz.Models;
using AirlineLenz.Windows.ChoiseAirportWindow;
using AirlineLenz.Windows.CrewWindow;
using AirlineLenz.Windows.FlightWindow;
using AirlineLenz.Windows.LinerWindow;
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

namespace AirlineLenz.Windows.DepartureWindow
{
    /// <summary>
    /// Логика взаимодействия для EditDepartureWindow.xaml
    /// </summary>
    public partial class EditDepartureWindow : Window
    {
        private readonly AirlineLenzDbContext dbContext;
        public Departure Departure { get; set; }
        public bool IsNewDeparture { get; set; } = false;
        public EditDepartureWindow(AirlineLenzDbContext dbContext, Departure departure, bool isNewDeparture)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            DataContext = this;
            Departure = departure;
            IsNewDeparture = isNewDeparture;
            RefreshFlightGrid();

            //this.Closing += EditDepartureWindowClosing;
        }

        private void RefreshFlightGrid()
        {

            List<Flight> newFlights = new List<Flight>();
            if (Departure.Flight != null)
            {
                newFlights.Add(Departure.Flight);
            }

            FlightGrid.ItemsSource = newFlights.ToList();
            FlightGrid.Items.Refresh();
        }


        //private void EditDepartureWindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    var MainWindow = new MainWindow();
        //    MainWindow.Show();
        //}


        private void AddFlightButtonClick(object sender, RoutedEventArgs e)
        {
            var searchFlightWindow = new SearchFlightWindow(dbContext, Departure);
            searchFlightWindow.ShowDialog();
            RefreshFlightGrid();
        }

        private void SaveButton(object sender, RoutedEventArgs e)
        {
            if (Departure.Crew == null)
            {
                MessageBox.Show("Укажите экипаж");
                return;
            }
            if (Departure.Liner == null)
            {
                MessageBox.Show("Укажите авиалайнер");
                return;
            }
            if (Departure.Flight == null)
            {
                MessageBox.Show("Укажите рейс");
                return;
            }

            try
            {
                if (IsNewDeparture)
                {
                    dbContext.Departures.Add(Departure);
                }
                dbContext.SaveChanges();
                Close();
            }
            catch (DbUpdateException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

            private void AddCrewButtonClick(object sender, RoutedEventArgs e)
        {
            var searchCrewWindow = new SearchCrewWindow(dbContext, Departure);
            searchCrewWindow.ShowDialog();
            CrewTextBox.Text = Departure.Crew.Title;
        }

        private void AddLinerButtonClick(object sender, RoutedEventArgs e)
        {
            var searchLinerWindow = new SearchLinerWindow(dbContext, Departure);
            searchLinerWindow.ShowDialog();
            LinerTextBox.Text = Departure.Liner.Name;
        }
    }
}
