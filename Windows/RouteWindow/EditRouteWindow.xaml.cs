using AirlineLenz.Models;
using AirlineLenz.Windows.ChoiseAirportWindow;

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
using System.Windows.Controls;
using Microsoft.EntityFrameworkCore;

namespace AirlineLenz.Windows.RouteWindow
{
    /// <summary>
    /// Логика взаимодействия для EditRouteWindow.xaml
    /// </summary>
    public partial class EditRouteWindow : Window
    {
        private readonly AirlineLenzDbContext dbContext;
        public Route Route { get; set; }
        public bool IsNewRoute { get; set; } = false;
        public EditRouteWindow(AirlineLenzDbContext dbContext, Route route, bool isNewRoute)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            DataContext = this;
            Route = route;
            IsNewRoute = isNewRoute;
           

            RefreshWayPointGrid();
            //this.Closing += EditRouteWindowClosing;
        }


        private void RefreshWayPointGrid()
        {
            WayPointGrid.ItemsSource = Route.WayPoints?.ToList();
            WayPointGrid.Items.Refresh();
        }

        //private void EditRouteWindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    var MainWindow = new MainWindow();
        //    MainWindow.Show();
        //}

        private void AddStartingPointButtonClick(object sender, RoutedEventArgs e)
        {
            AddAirport(StartingPointTextBox, "Starting");
        }

        private void AddEndingPointButtonClick(object sender, RoutedEventArgs e)
        {
            AddAirport(EndingPointTextBox, "Ending");
        }

        private void AddAirport(TextBox textBox, string routeType)
        {
                var searchAirportWindow = new SearchAirportWindow(dbContext, Route, routeType);
            searchAirportWindow.ShowDialog();
            if (routeType == "Starting")
            {
                textBox.Text = Route.StartingPoint.Name;
            }
            if (routeType == "Ending")
            {
                textBox.Text = Route.EndingPoint.Name;
            }
        }

        private void SaveButton(object sender, RoutedEventArgs e)
        {
            if (Route.StartingPoint == null)
            {
                MessageBox.Show("Укажите начальный пункт");
                return;
            }
            if (Route.EndingPoint == null)
            {
                MessageBox.Show("Укажите конечный пункт");
                return;
            }
            try
            {
                if (IsNewRoute)
                {
                        dbContext.Routes.Add(Route);
                }
                dbContext.SaveChanges();
                Close();
            }
            catch (DbUpdateException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void AddWayPointButtonClick(object sender, RoutedEventArgs e)
        {
            AddAirport(EndingPointTextBox, "Way");
            RefreshWayPointGrid();
        }

        private void DeleteWayPointButtonClick(object sender, RoutedEventArgs e)
        {
            if (WayPointGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < WayPointGrid.SelectedItems.Count; i++)
                {
                    if (WayPointGrid.SelectedItems[i] is Airport airport)
                    {
                        Route.WayPoints.Remove(airport);
                    }
                }

            }
            RefreshWayPointGrid();
        }
    }
}
