
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

namespace AirlineLenz.Windows.CrewWindow
{
    /// <summary>
    /// Логика взаимодействия для SearchCrewWindow.xaml
    /// </summary>
    public partial class SearchCrewWindow : Window
    {
        private readonly AirlineLenzDbContext dbContext;
        public Departure Departure { get; set; }
   
        public SearchCrewWindow(AirlineLenzDbContext dbContext, Departure departure)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            DataContext = this;
            Departure = departure;

            RefreshCrewGrid();
        }

        private void RefreshCrewGrid()
        {
            var search = SearchTextBox.Text.ToLower();
            CrewGrid.ItemsSource = dbContext.Crews
                .Where(x => x.Title.ToLower().Contains(search))
                .ToList();
            CrewGrid.Items.Refresh();
        }

        private void ChoiseButtonClick(object sender, RoutedEventArgs e)
        {
            if (CrewGrid.SelectedItems.Count == 1)
            {
                Departure.Crew = (Crew)CrewGrid.SelectedItems[0]!;
          
            }
            Close();
        }

        private void SearchButtonClick(object sender, RoutedEventArgs e)
        {
            RefreshCrewGrid();
        }
    }
}
