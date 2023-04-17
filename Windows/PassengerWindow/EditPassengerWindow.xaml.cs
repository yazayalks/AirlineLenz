using AirlineLenz.Models;
using DocumentFormat.OpenXml.Drawing.Charts;
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

namespace AirlineLenz.Windows.PassengerWindow
{
    /// <summary>
    /// Логика взаимодействия для AddPassengerWindow.xaml
    /// </summary>

    public partial class EditPassengerWindow : Window
    {
        private readonly AirlineLenzDbContext dbContext;
        public Passenger Passenger { get; set; }
        public Passenger CopyPassenger { get; set; } = new Passenger();
        public bool IsNewPassenger { get; set; } = false;
        public EditPassengerWindow(AirlineLenzDbContext dbContext, Passenger passenger, bool isNewPassenger)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            DataContext = this;
            Passenger = passenger;
    
            IsNewPassenger = isNewPassenger;

            //this.Closing += EditPassengerWindowClosing;
        }

        //private void EditPassengerWindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    Passenger = dbContext.Passengers.FirstOrDefault(p => p.Id == Passenger.Id);
        //}


        private void SaveButton(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Passenger.FirstName))
            {
                MessageBox.Show("Укажите имя");
                return;
            }
            if (string.IsNullOrEmpty(Passenger.LastName))
            {
                MessageBox.Show("Укажите фамилию");
                return;
            }
            if (string.IsNullOrEmpty(Passenger.Patronymic))
            {
                MessageBox.Show("Укажите отчество");
                return;
            }
            if (Passenger.PassportSeries.ToString() == null || Passenger.PassportSeries.ToString() == "0")
            {
                MessageBox.Show("Укажите серию");
                return;
            }
            if ((Passenger.PassportId.ToString() == null) || Passenger.PassportId.ToString() == "0")
            {
                MessageBox.Show("Укажите номер");
                return;
            }
            if (string.IsNullOrEmpty(Passenger.IssuedBy))
            {
                MessageBox.Show("Укажите кем выдан паспорт");
                return;
            }
            try
            {
                if (IsNewPassenger)
                {
                    dbContext.Passengers.Add(Passenger);
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
