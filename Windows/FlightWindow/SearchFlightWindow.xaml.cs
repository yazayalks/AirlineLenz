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

namespace AirlineLenz.Windows.FlightWindow
{
    /// <summary>
    /// Логика взаимодействия для SearchFlightWindow.xaml
    /// </summary>
    public partial class SearchFlightWindow : Window
    {
        private readonly AirlineLenzDbContext dbContext;
        public Departure Departure { get; set; }
        public SearchFlightWindow(AirlineLenzDbContext dbContext, Departure departure)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            DataContext = this;
            Departure = departure;

            RefreshFlightGrid();
        }
        private void RefreshFlightGrid()
        {
            var search = SearchTextBox.Text.ToLower();
            FlightGrid.ItemsSource = dbContext.Flights
                .Where(x => x.Route.StartingPoint.Name.ToLower().Contains(search) || x.Route.EndingPoint.Name.ToLower().Contains(search) || x.Route.Id.ToString().Contains(search))
                .ToList();
            FlightGrid.Items.Refresh();
        }
        private void ChoiseButtonClick(object sender, RoutedEventArgs e)
        {
            if (FlightGrid.SelectedItems.Count == 1)
            {

                Departure.Flight = ((Flight)FlightGrid.SelectedItems[0]!);
            }
            Close();
        }

        private void SearchButtonClick(object sender, RoutedEventArgs e)
        {
            RefreshFlightGrid();
        }
    }
}
