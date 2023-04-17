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
using System.Windows.Controls;

namespace AirlineLenz.Windows.ChoiseAirportWindow
{
    /// <summary>
    /// Логика взаимодействия для SearchAirportWindow.xaml
    /// </summary>
    public partial class SearchAirportWindow : Window
    {
        private readonly AirlineLenzDbContext dbContext;
        public Route Route { get; set; }
        public string RouteType { get; set; }
      
        
        public SearchAirportWindow(AirlineLenzDbContext dbContext, Route route, string routeType)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            DataContext = this;
          
            Route = route;
            RouteType = routeType;
            RefreshAirportGrid();
        }

        private void RefreshAirportGrid()
        {
            var search = SearchTextBox.Text.ToLower();
            AirportGrid.ItemsSource = dbContext.Airports
                .Where(x => x.City.ToLower().Contains(search) || x.Country.ToLower().Contains(search) || x.Name.ToLower().Contains(search))
                .ToList();
            AirportGrid.Items.Refresh();
        }


      

        private void SearchButtonClick(object sender, RoutedEventArgs e)
        {
            RefreshAirportGrid();
        }

      


        private void ChoiseButtonClick(object sender, RoutedEventArgs e)
        {
            if (AirportGrid.SelectedItems.Count == 1)
            {
                  
                        if (RouteType == "Starting")
                        {
                            Route.StartingPoint = (Airport)AirportGrid.SelectedItems[0]!;
                     
                    }
                if (RouteType == "Ending")
                {
                            Route.EndingPoint = (Airport)AirportGrid.SelectedItems[0]!;
                   
                }
                if (RouteType == "Way")
                {
                    if(Route.WayPoints == null)
                    {
                        Route.WayPoints = new List<Airport>();
                    }
                    if (Route.WayPoints.Any(x => x.Id == ((Airport)AirportGrid.SelectedItems[0]!).Id))
                    {
                        MessageBox.Show("Данный промежуточный пункт уже присутствует");
                        return;
                    }
                    Route.WayPoints.Add((Airport)AirportGrid.SelectedItems[0]!);
                    
                }

            }
            Close();
        }
      
    }
}
