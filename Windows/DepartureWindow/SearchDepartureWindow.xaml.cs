using AirlineLenz.Models;
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
    /// Логика взаимодействия для SearchDepartureWindow.xaml
    /// </summary>
    public partial class SearchDepartureWindow : Window
    {
        private readonly AirlineLenzDbContext dbContext;
        public Ticket Ticket { get; set; }
        public SearchDepartureWindow(AirlineLenzDbContext dbContext, Ticket ticket)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            DataContext = this;

            Ticket = ticket;

            RefreshDepartureGrid();
        }


        private void RefreshDepartureGrid()
        {
            var search = SearchTextBox.Text.ToLower();
            DepartureGrid.ItemsSource = dbContext.Departures
                .Where(x => x.Crew.Title.ToLower().Contains(search) || x.Flight.Title.ToLower().Contains(search) || x.Liner.Name.ToLower().Contains(search) || x.Flight.Route.StartingPoint.Name.ToLower().Contains(search) 
                || x.Flight.Route.StartingPoint.Name.ToLower().Contains(search) || x.Flight.Route.StartingPoint.City.ToLower().Contains(search) || x.Flight.Route.StartingPoint.Country.ToLower().Contains(search)
                || x.Flight.Route.EndingPoint.Name.ToLower().Contains(search) || x.Flight.Route.EndingPoint.City.ToLower().Contains(search) || x.Flight.Route.EndingPoint.Country.ToLower().Contains(search))
                .ToList();
            DepartureGrid.Items.Refresh();
        }

        private void ChoiseButtonClick(object sender, RoutedEventArgs e)
        {
            
                if (DepartureGrid.SelectedItems.Count == 1)
                {

                    Ticket.Departure = (Departure)DepartureGrid.SelectedItems[0]!;
                }
                Close();
            }

        private void SearchButtonClick(object sender, RoutedEventArgs e)
        {
            RefreshDepartureGrid();
        }
    }
}
