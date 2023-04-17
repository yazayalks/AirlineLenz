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

namespace AirlineLenz.Windows.RouteWindow
{
    /// <summary>
    /// Логика взаимодействия для SearchRouteWindow.xaml
    /// </summary>
    public partial class SearchRouteWindow : Window
    {
        private readonly AirlineLenzDbContext dbContext;
        public Flight Flight { get; set; }
        public SearchRouteWindow(AirlineLenzDbContext dbContext, Flight flight)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            DataContext = this;

            Flight = flight;

            RefreshRouteGrid();
        }

        private void RefreshRouteGrid()
        {
            var search = SearchTextBox.Text.ToLower();
            RouteGrid.ItemsSource = dbContext.Routes
                .Where(x => x.StartingPoint.Name.ToLower().Contains(search) || x.EndingPoint.Name.ToLower().Contains(search) || x.Id.ToString().Contains(search))
                .ToList();
            RouteGrid.Items.Refresh();
        }

        private void ChoiseButtonClick(object sender, RoutedEventArgs e)
        {
            if (RouteGrid.SelectedItems.Count == 1)
            {
               
                Flight.Route = ((Route)RouteGrid.SelectedItems[0]!);
            }
            Close();
        }

        private void SearchButtonClick(object sender, RoutedEventArgs e)
        {
            RefreshRouteGrid();
        }
    }
}
