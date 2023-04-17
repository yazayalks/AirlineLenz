using AirlineLenz.Models;
using AirlineLenz.Windows.DepartureWindow;
using AirlineLenz.Windows.EmployeeWindow;
using AirlineLenz.Windows.PassengerWindow;
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

namespace AirlineLenz.Windows.TicketWindow
{
    /// <summary>
    /// Логика взаимодействия для EditTicketWindow.xaml
    /// </summary>
    public partial class EditTicketWindow : Window
    {
        private readonly AirlineLenzDbContext dbContext;
        public Ticket Ticket { get; set; }
        public bool IsNewTicket { get; set; } = false;
        public List<ServiceType> ServiceClassColumn { get; set; }
        public EditTicketWindow(AirlineLenzDbContext dbContext, Ticket ticket, bool isNewTicket)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            DataContext = this;
            Ticket = ticket;
            IsNewTicket = isNewTicket;
            ServiceClassColumn = Enum.GetValues(typeof(ServiceType)).Cast<ServiceType>().ToList();

            RefreshCashierGrid();
            RefreshDepartureGrid();
            RefreshPassengerGrid();

            //this.Closing += EditTicketWindowClosing;
        }

        //private void EditTicketWindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    var MainWindow = new MainWindow();
        //    MainWindow.Show();
        //}


        private void RefreshCashierGrid()
        {

            List<Employee> newEmployee = new List<Employee>();
            if (Ticket.Employee != null)
            {
                newEmployee.Add(Ticket.Employee);
            }

            CashierGrid.ItemsSource = newEmployee.ToList();
            CashierGrid.Items.Refresh();
        }  
        private void RefreshDepartureGrid()
        {

            List<Departure> newDeparture = new List<Departure>();
            if (Ticket.Departure != null)
            {
                newDeparture.Add(Ticket.Departure);
            }

            DepartureGrid.ItemsSource = newDeparture.ToList();
            DepartureGrid.Items.Refresh();
        }   
        private void RefreshPassengerGrid()
        {

            List<Passenger> newPassenger = new List<Passenger>();
            if (Ticket.Passenger != null)
            {
                newPassenger.Add(Ticket.Passenger);
            }

            PassengerGrid.ItemsSource = newPassenger.ToList();
            PassengerGrid.Items.Refresh();
        }


        private void AddDepartureButtonClick(object sender, RoutedEventArgs e)
        {
            var searchDepartureWindow = new SearchDepartureWindow(dbContext, Ticket);
            searchDepartureWindow.ShowDialog();
            RefreshDepartureGrid();
        }

        private void AddCashierButtonClick(object sender, RoutedEventArgs e)
        {
            var SearchCashierWindow = new SearchCashierWindow(dbContext, Ticket);
            SearchCashierWindow.ShowDialog();
            RefreshCashierGrid();
        }

        private void AddPassengerButtonClick(object sender, RoutedEventArgs e)
        {
            var searchPassengerWindow = new SearchPassengerWindow(dbContext, Ticket);
            searchPassengerWindow.ShowDialog();
            RefreshPassengerGrid();

        }

        private void SaveButton(object sender, RoutedEventArgs e)
        {
            if (Ticket.Departure == null)
            {
                MessageBox.Show("Укажите вылет");
                return;
            }
            if (Ticket.Passenger == null)
            {
                MessageBox.Show("Укажите пассажира");
                return;
            }
            if (Ticket.Employee == null)
            {
                MessageBox.Show("Укажите кассира");
                return;
            }
            if (string.IsNullOrEmpty(Ticket.Place))
            {
                MessageBox.Show("Укажите место");
                return;
            }
            if ((Ticket.CheckoutNumber.ToString() == null) || Ticket.CheckoutNumber.ToString() == "0")
            {
                MessageBox.Show("Укажите кассу");
                return;
            }
            try
            {
                if (IsNewTicket)
                {
                    dbContext.Tickets.Add(Ticket);
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
