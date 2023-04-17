
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

namespace AirlineLenz.Windows.LinerWindow
{
    /// <summary>
    /// Логика взаимодействия для SearchLinerWindow.xaml
    /// </summary>
    public partial class SearchLinerWindow : Window
    {
        private readonly AirlineLenzDbContext dbContext;
        public Departure Departure { get; set; }
  
        public SearchLinerWindow(AirlineLenzDbContext dbContext, Departure departure)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            DataContext = this;
        
            Departure = departure;

           
                RefreshLinerGrid();
        }

        private void RefreshLinerGrid()
        {
            var search = SearchTextBox.Text.ToLower();
            LinerGrid.ItemsSource = dbContext.Liners
                .Where(x => x.Name.ToLower().Contains(search))
                .ToList();
                LinerGrid.Items.Refresh();
        }

        private void SearchButtonClick(object sender, RoutedEventArgs e)
        {
            RefreshLinerGrid();
        }

        private void ChoiseButtonClick(object sender, RoutedEventArgs e)
        {
            if (LinerGrid.SelectedItems.Count == 1)
            {
                Departure.Liner = (Liner)LinerGrid.SelectedItems[0]!;
             
            }
            Close();
        }
    }
}
