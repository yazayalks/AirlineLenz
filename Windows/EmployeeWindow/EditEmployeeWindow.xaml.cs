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

namespace AirlineLenz.Windows.EmployeeWindow
{
    /// <summary>
    /// Логика взаимодействия для EditEmployeeWindow.xaml
    /// </summary>
    public partial class EditEmployeeWindow : Window
    {

        private readonly AirlineLenzDbContext dbContext;
        public Employee Employee { get; set; }
        public bool IsNewEmployee { get; set; }
        public List<EmployeeType> EmployeeTypeColumn { get; set; }

        public EditEmployeeWindow(AirlineLenzDbContext dbContext, Employee employee, bool isNewEmployee)
        {
            InitializeComponent();
            EmployeeTypeColumn = Enum.GetValues(typeof(EmployeeType)).Cast<EmployeeType>().ToList();
            this.dbContext = dbContext;
            DataContext = this;
            Employee = employee;
            IsNewEmployee = isNewEmployee;

            //this.Closing += EditEmployeeWindowClosing;
        }

        //private void EditEmployeeWindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    var MainWindow = new MainWindow();
        //    MainWindow.Show();
        //}

        private void SaveButton(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Employee.FirstName))
            {
                MessageBox.Show("Укажите имя");
                return;
            }
            if (string.IsNullOrEmpty(Employee.LastName))
            {
                MessageBox.Show("Укажите фамилию");
                return;
            }
            if (string.IsNullOrEmpty(Employee.Patronymic))
            {
                MessageBox.Show("Укажите отчество");
                return;
            }
            try
            {
                if (IsNewEmployee)
                {
                    dbContext.Employees.Add(Employee);
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
