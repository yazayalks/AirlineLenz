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

namespace AirlineLenz.Windows.AccessRightWindow
{
    /// <summary>
    /// Логика взаимодействия для EditAccessRightWindow.xaml
    /// </summary>
    public partial class EditAccessRightWindow : Window
    {
        private readonly AirlineLenzDbContext dbContext;

        public List<AccessRight> AccessRights { get; set; }
        public List<FormType> FormTypeColumn { get; set; }
        public User User { get; set; }
        public EditAccessRightWindow(AirlineLenzDbContext dbContext, User user)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            DataContext = this;
            User = user;
            UserEmailTextBox.Text = user.Email;
            FormTypeColumn = Enum.GetValues(typeof(FormType)).Cast<FormType>().ToList();
            AccessRights = User.AccessRights.ToList();
            AccessRightGrid.ItemsSource = AccessRights;
        }

        private void SaveAccessRightButtonClick(object sender, RoutedEventArgs e)
        {
            try
            {
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
