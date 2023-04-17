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

namespace AirlineLenz.Windows.AirportWindow
{
    /// <summary>
    /// Логика взаимодействия для EditAirportWindow.xaml
    /// </summary>
    public partial class EditAirportWindow : Window
    {
        private readonly AirlineLenzDbContext dbContext;
        public Airport Airport { get; set; }
        public bool IsNewAirport { get; set; }
        public EditAirportWindow(AirlineLenzDbContext dbContext, Airport airport, bool isNewAirport)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            DataContext = this;
            Airport = airport;
            IsNewAirport = isNewAirport;

            //this.Closing += EditAirportWindowClosing;
        }

        //private void EditAirportWindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    var MainWindow = new MainWindow();
        //    MainWindow.Show();
        //}


        private void SaveButton(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Airport.Name))
            {
                MessageBox.Show("Укажите название");
                return;
            }
            if (string.IsNullOrEmpty(Airport.City))
            {
                MessageBox.Show("Укажите город");
                return;
            }
            if (string.IsNullOrEmpty(Airport.Country))
            {
                MessageBox.Show("Укажите страну");
                return;
            }
            try
            {
                if (IsNewAirport)
                {
                    dbContext.Airports.Add(Airport);
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
