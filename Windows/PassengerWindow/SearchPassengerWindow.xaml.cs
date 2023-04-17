using AirlineLenz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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

namespace AirlineLenz.Windows.PassengerWindow
{
    /// <summary>
    /// Логика взаимодействия для SearchPassengerWindow.xaml
    /// </summary>
    public partial class SearchPassengerWindow : Window
    {
        private readonly AirlineLenzDbContext dbContext;
        public Ticket Ticket { get; set; }
        public SearchPassengerWindow(AirlineLenzDbContext dbContext, Ticket ticket)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            DataContext = this;

            Ticket = ticket;

            RefreshPassengerGrid();
        }

        private void RefreshPassengerGrid()
        {
            var search = SearchTextBox.Text.ToLower();
            PassengerGrid.ItemsSource = dbContext.Passengers
                .Where(x => x.FirstName.ToLower().Contains(search) || x.LastName.ToLower().Contains(search) || x.Patronymic.ToLower().Contains(search) || x.PassportId.ToString().Contains(search) || x.PassportSeries.ToString().Contains(search))
                .ToList();
            PassengerGrid.Items.Refresh();
        }

        private void ChoiseButtonClick(object sender, RoutedEventArgs e)
        {
            if (PassengerGrid.SelectedItems.Count == 1)
            {

                Ticket.Passenger = (Passenger)PassengerGrid.SelectedItems[0]!;
            }
            Close();
        }

        private void SearchButtonClick(object sender, RoutedEventArgs e)
        {
            RefreshPassengerGrid();
        }

    }
}
