using AirlineLenz.Models;
using AirlineLenz.Utilities;
using AirlineLenz.Windows.AccessRightWindow;
using AirlineLenz.Windows.AirportWindow;
using AirlineLenz.Windows.CrewWindow;
using AirlineLenz.Windows.DepartureWindow;
using AirlineLenz.Windows.EmployeeWindow;
using AirlineLenz.Windows.FlightWindow;
using AirlineLenz.Windows.LinerWindow;
using AirlineLenz.Windows.PassengerWindow;
using AirlineLenz.Windows.RouteWindow;
using AirlineLenz.Windows.TicketWindow;
using Aspose.Cells;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;




namespace AirlineLenz.Windows;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly AirlineLenzDbContext dbContext;

    public List<Passenger> Passengers { get; set; }
    public List<Liner> Liners { get; set; }
    public List<Airport> Airports { get; set; }
    public List<Airport> currentAirports { get; set; }
    public List<Employee> Employees { get; set; }
    public List<Route> Routes { get; set; }
    public List<Crew> Crews { get; set; }
    public List<Departure> Departures { get; set; }
    public List<Ticket> Tickets { get; set; }
    public User User { get; set; }
    public List<UserType> UserTypes { get; set; }

    public MainWindow(AirlineLenzDbContext dbContext, User user)
    {
        InitializeComponent();
        this.dbContext = dbContext;
        this.DataContext = this;
        User = user;

        if (User.UserType != UserType.admin)
        {
            AdminTabItem.Visibility = Visibility.Hidden;
        }

        var PassengerFormAccessRight = user.AccessRights.Single(x => x.Form == FormType.PassengerForm);
        AccessRightForm(PassengerFormAccessRight, PassengerTabItem, PassengerGridItem, AddPassengerButton, EditPassengerButton, DeletePassengerButton);

        var LinerFormAccessRight = user.AccessRights.Single(x => x.Form == FormType.LinerForm);
        AccessRightForm(LinerFormAccessRight, LinerTabItem, LinerGridItem, AddLinerButton, EditLinerButton, DeleteLinerButton);

        var AirportFormAccessRight = user.AccessRights.Single(x => x.Form == FormType.AirportForm);
        AccessRightForm(AirportFormAccessRight, AirportTabItem, AirportGridItem, AddAirportButton, EditAirportButton, DeleteAirportButton);

        var RouteFormAccessRight = user.AccessRights.Single(x => x.Form == FormType.RouteForm);
        AccessRightForm(RouteFormAccessRight, RouteTabItem, RouteGridItem, AddRouteButton, EditRouteButton, DeleteRouteButton);

        var EmployeeFormAccessRight = user.AccessRights.Single(x => x.Form == FormType.EmployeeForm);
        AccessRightForm(EmployeeFormAccessRight, EmployeeTabItem, EmployeeGridItem, AddEmployeeButton, EditEmployeeButton, DeleteEmployeeButton);

        var CrewFormAccessRight = user.AccessRights.Single(x => x.Form == FormType.CrewForm);
        AccessRightForm(CrewFormAccessRight, CrewTabItem, CrewGridItem, AddCrewButton, EditCrewButton, DeleteCrewButton);

        var FlightFormAccessRight = user.AccessRights.Single(x => x.Form == FormType.FlightForm);
        AccessRightForm(FlightFormAccessRight, FlightTabItem, FlightGridItem, AddFlightButton, EditFlightButton, DeleteFlightButton);

        var DepartureFormAccessRight = user.AccessRights.Single(x => x.Form == FormType.DepartureForm);
        AccessRightForm(DepartureFormAccessRight, DepartureTabItem, DepartureGridItem, AddDepartureButton, EditDepartureButton, DeleteDepartureButton);

        var TicketFormAccessRight = user.AccessRights.Single(x => x.Form == FormType.TicketForm);
        AccessRightForm(TicketFormAccessRight, TicketTabItem, TicketGridItem, AddTicketButton, EditTicketButton, DeleteTicketButton);


        RefreshPassengerGrid();
        RefreshLinerGrid();
        RefreshAirportGrid();
        RefreshEmployeeGrid();
        RefreshRouteGrid();
        RefreshCrewGrid();
        RefreshFlightGrid();
        RefreshDepartureGrid();
        RefreshTicketGrid();
        RefreshUserGrid();


        this.Closing += MainWindow_Closing;
    }

    private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
    {
        var authWindow = new AuthWindow();
        authWindow.Show();
    }
    private void AccessRightForm(AccessRight accessRight, TabItem tabItem, Grid grid, Button addButton, Button editButton, Button deleteButton)
    {
        if (!accessRight.Read)
        {
            tabItem.Visibility = Visibility.Hidden;
            grid.Visibility = Visibility.Hidden;
        }
        addButton.IsEnabled = accessRight.Write;
        editButton.IsEnabled = accessRight.Edit;
        deleteButton.IsEnabled = accessRight.Delete;
    }

    private void RefreshUserGrid()
    {
        var userTypes = Enum.GetValues(typeof(UserType)).Cast<UserType>().ToList();
        UserTypeColumn.ItemsSource = userTypes;
        UserGrid.ItemsSource = dbContext.Users.Include(x => x.AccessRights).ToList();
        UserGrid.Items.Refresh();
    }
    private void RefreshPassengerGrid()
    {
        var search = SearchTextBox.Text.ToLower();
        PassengerGrid.ItemsSource = dbContext.Passengers
            .Where(x => x.FirstName.ToLower().Contains(search) || x.LastName.ToLower().Contains(search) || x.Patronymic.ToLower().Contains(search) || x.IssuedBy.ToLower().Contains(search) || x.PassportId.ToString().Contains(search) || x.PassportSeries.ToString().Contains(search))
            .ToList();

        PassengerGrid.Items.Refresh();
    }

    private void RefreshAirportGrid()
    {
        Airports = dbContext.Airports.ToList();
        AirportGrid.ItemsSource = Airports;

        AirportGrid.Items.Refresh();
    }

    private void RefreshFlightGrid()
    {
        FlightGrid.ItemsSource = dbContext.Flights
            .ToList();
        FlightGrid.Items.Refresh();
    }
    private void RefreshCrewGrid()
    {
        CrewGrid.ItemsSource = dbContext.Crews
            .AsSplitQuery()
            .Include(x => x.Employees)
            .ToList();
        CrewGrid.Items.Refresh();
    }

    private void RefreshTicketGrid()
    {
        TicketGrid.ItemsSource = dbContext.Tickets
            .AsSplitQuery()
            .Include(x => x.Departure)
            .ToList();
        TicketGrid.Items.Refresh();
        var a = TicketGrid.ItemsSource;
    }

    private void RefreshDepartureGrid()
    {
        DepartureGrid.ItemsSource = dbContext.Departures
            .AsSplitQuery()
            .Include(x => x.Crew)
            .Include(x => x.Liner)
            .Include(x => x.Flight)
            .ToList();
        CrewGrid.Items.Refresh();
    }
    private void RefreshRouteGrid()
    {
        RouteGrid.ItemsSource = dbContext.Routes
            .AsSplitQuery()
            .Include(x => x.StartingPoint)
            .Include(x => x.EndingPoint)
            .Include(x => x.WayPoints)
            .ToList();

        RouteGrid.Items.Refresh();
    }
    private void RefreshEmployeeGrid()
    {
        Employees = dbContext.Employees.ToList();
        EmployeeGrid.ItemsSource = Employees;

        EmployeeGrid.Items.Refresh();
    }

    private void RefreshLinerGrid()
    {
        LinerGrid.ItemsSource = dbContext.Liners.ToList();
        LinerGrid.Items.Refresh();
    }

    private void EditPassengerButtonClick(object sender, RoutedEventArgs e)
    {
        if (PassengerGrid.SelectedItems.Count > 0)
        {
            var EditPassengerWindow = new EditPassengerWindow(dbContext, (Passenger)PassengerGrid.SelectedItems[0]!, false);
            EditPassengerWindow.ShowDialog();
            //Close();
            dbContext.Entry((Passenger)PassengerGrid.SelectedItems[0]!).Reload();
            RefreshPassengerGrid();
        }
        else
        {
            MessageBox.Show("Выберете пассажира для редактирования");
            return;
        }
    }

    private void AddPassengerButtonClick(object sender, RoutedEventArgs e)
    {
        Passenger newPassenger = new Passenger();
        var AddPassengerWindow = new EditPassengerWindow(dbContext, newPassenger, true);
        AddPassengerWindow.ShowDialog();
        //Close();
        RefreshPassengerGrid();
       
    }

    private void DeletePassengerButtonClick(object sender, RoutedEventArgs e)
    {
        if (PassengerGrid.SelectedItems.Count > 0)
        {
            for (int i = 0; i < PassengerGrid.SelectedItems.Count; i++)
            {
                if (PassengerGrid.SelectedItems[i] is Passenger passenger)
                {
                    dbContext.Passengers.Remove(passenger);
                }
            }
        }
        else
        {
            MessageBox.Show("Выберете пассажира для удаления");
            return;
        }

        dbContext.SaveChanges();
        RefreshPassengerGrid();
    }


    private void SearchPassengerButtonClick(object sender, RoutedEventArgs e)
    {
        RefreshPassengerGrid();
    }

    private void ExportPassengerButtonClick(object sender, RoutedEventArgs e)
    {
        var l = new List<Passenger>((IEnumerable<Passenger>)PassengerGrid.ItemsSource);

        var myExportList = new List<ExportPassenger>();

        foreach (var item in l)
        {
            myExportList.Add(new ExportPassenger()
            {
                Id = item.Id.ToString(),
                FirstName = item.FirstName,
                LastName = item.LastName,
                Patronymic = item.Patronymic,
                PassportSeries = item.PassportSeries.ToString(),
                PassportId = item.PassportId.ToString(),
                IssuedBy = item.IssuedBy,
                DateOfIssue = item.DateOfIssue.ToString(),

            });
        }

        using (XLWorkbook wb = new XLWorkbook())
        {
            wb.Worksheets.Add(Common.ToDataTable(myExportList));

            Stream streamF = File.Create("export.xlsx");
            wb.SaveAs(streamF);
            streamF.Close();
        }


        Aspose.Cells.Workbook workbook = new Aspose.Cells.Workbook("export.xlsx");
        workbook.Save("export.docx", SaveFormat.Docx);
        MessageBox.Show("Успешно");
    }

    private void AddLinerButtonClick(object sender, RoutedEventArgs e)
    {
        Liner newLiner = new Liner();
        var AddLinerWindow = new EditLinerWindow(dbContext, newLiner, true);
        AddLinerWindow.ShowDialog();
        RefreshLinerGrid();

    }

    private void EditLinerButtonClick(object sender, RoutedEventArgs e)
    {
        if (LinerGrid.SelectedItems.Count > 0)
        {
            var EditLinerWindow = new EditLinerWindow(dbContext, (Liner)LinerGrid.SelectedItems[0]!, false);
            EditLinerWindow.ShowDialog();
            //Close();
            dbContext.Entry((Liner)LinerGrid.SelectedItems[0]!).Reload();
            RefreshLinerGrid();
        }
        else
        {
            MessageBox.Show("Выберете авиалайнер для редактирования");
            return;
        }

    }

    private void DeleteLinerButtonClick(object sender, RoutedEventArgs e)
    {
        if (LinerGrid.SelectedItems.Count > 0)
        {
            for (int i = 0; i < LinerGrid.SelectedItems.Count; i++)
            {
                if (LinerGrid.SelectedItems[i] is Liner liner)
                {
                    dbContext.Liners.Remove(liner);
                }
            }
        }
        else
        {
            MessageBox.Show("Выберете авиалайнер для удаления");
            return;
        }

        dbContext.SaveChanges();
        RefreshLinerGrid();
    }



    private void SaveButtonClick(object sender, RoutedEventArgs e)
    {
        try
        {
            dbContext.SaveChanges();
        }
        catch (DbUpdateException exception)
        {
            MessageBox.Show(exception.Message);
        }
    }

    private void AddEmployeeButtonClick(object sender, RoutedEventArgs e)
    {
        Employee newEmployee = new Employee();
        var AddEmployeeWindow = new EditEmployeeWindow(dbContext, newEmployee, true);
        AddEmployeeWindow.ShowDialog();
        RefreshEmployeeGrid();
    }

    private void EditEmployeeButtonClick(object sender, RoutedEventArgs e)
    {
        if (EmployeeGrid.SelectedItems.Count > 0)
        {
            var EditEmployeeWindow = new EditEmployeeWindow(dbContext, (Employee)EmployeeGrid.SelectedItems[0]!, false);
            EditEmployeeWindow.ShowDialog();
            dbContext.Entry((Employee)EmployeeGrid.SelectedItems[0]!).Reload();
            RefreshEmployeeGrid();
        }
        else
        {
            MessageBox.Show("Выберете сотрудника для редактирования");
            return;
        }

    }

    private void DeleteEmployeeButtonClick(object sender, RoutedEventArgs e)
    {
        if (EmployeeGrid.SelectedItems.Count > 0)
        {
            for (int i = 0; i < EmployeeGrid.SelectedItems.Count; i++)
            {
                if (EmployeeGrid.SelectedItems[i] is Employee employee)
                {
                    dbContext.Employees.Remove(employee);
                }
            }
        }
        else
        {
            MessageBox.Show("Выберете сотрудника для удаления");
            return;
        }

        dbContext.SaveChanges();
        RefreshEmployeeGrid();
    }

    private void AddRouteButtonClick(object sender, RoutedEventArgs e)
    {
        Route newRoute = new Route();
        var EditRouteWindow = new EditRouteWindow(dbContext, newRoute, true);
        EditRouteWindow.ShowDialog();
        RefreshRouteGrid();
    }

    private void EditRouteButtonClick(object sender, RoutedEventArgs e)
    {
        if (RouteGrid.SelectedItems.Count > 0)
        {
            var EditRouteWindow = new EditRouteWindow(dbContext, (Route)RouteGrid.SelectedItems[0]!, false);
            EditRouteWindow.ShowDialog();
            dbContext.Entry((Route)RouteGrid.SelectedItems[0]!).Reload();
            RefreshRouteGrid();
        }
        else
        {
            MessageBox.Show("Выберете маршрут для редактирования");
            return;
        }
    }

    private void DeleteRouteButtonClick(object sender, RoutedEventArgs e)
    {
        if (RouteGrid.SelectedItems.Count > 0)
        {
            for (int i = 0; i < RouteGrid.SelectedItems.Count; i++)
            {
                if (RouteGrid.SelectedItems[i] is Route route)
                {
                    dbContext.Routes.Remove(route);
                }
            }
        }
        else
        {
            MessageBox.Show("Выберете маршрут для удаления");
            return;
        }

        dbContext.SaveChanges();
        RefreshRouteGrid();
    }

    private void AddAirportButtonClick(object sender, RoutedEventArgs e)
    {
        Airport newAirport = new Airport();
        var EditAirportWindow = new EditAirportWindow(dbContext, newAirport, true);
        EditAirportWindow.ShowDialog();
        RefreshAirportGrid();

    }

    private void EditAirportButtonClick(object sender, RoutedEventArgs e)
    {
        if (AirportGrid.SelectedItems.Count > 0)
        {
            var EditAirportWindow = new EditAirportWindow(dbContext, (Airport)AirportGrid.SelectedItems[0]!, false);
            EditAirportWindow.ShowDialog();
            dbContext.Entry((Airport)AirportGrid.SelectedItems[0]!).Reload();
            RefreshAirportGrid();
        }
        else
        {
            MessageBox.Show("Выберете аэропорт для редактирования");
            return;
        }

    }

    private void DeleteAirportButtonClick(object sender, RoutedEventArgs e)
    {
        if (AirportGrid.SelectedItems.Count > 0)
        {
            for (int i = 0; i < AirportGrid.SelectedItems.Count; i++)
            {
                if (AirportGrid.SelectedItems[i] is Airport airport)
                {
                    dbContext.Airports.Remove(airport);
                }
            }
        }
        else
        {
            MessageBox.Show("Выберете аэропорт для удаления");
            return;
        }

        dbContext.SaveChanges();
        RefreshAirportGrid();

    }

    private void AddCrewButtonClick(object sender, RoutedEventArgs e)
    {
        Crew newCrew = new Crew();
        var EditCrewWindow = new EditCrewWindow(dbContext, newCrew, true);
        EditCrewWindow.ShowDialog();
        RefreshRouteGrid();
    }

    private void EditCrewButtonClick(object sender, RoutedEventArgs e)
    {
        if (CrewGrid.SelectedItems.Count > 0)
        {
            var editCrewWindow = new EditCrewWindow(dbContext, (Crew)CrewGrid.SelectedItems[0]!, false);
            editCrewWindow.ShowDialog();
            dbContext.Entry((Crew)CrewGrid.SelectedItems[0]!).Reload();
            RefreshCrewGrid();
        }
        else
        {
            MessageBox.Show("Выберете экипаж для редактирования");
            return;
        }

    }

    private void DeleteCrewButtonClick(object sender, RoutedEventArgs e)
    {
        if (CrewGrid.SelectedItems.Count > 0)
        {
            for (int i = 0; i < CrewGrid.SelectedItems.Count; i++)
            {
                if (CrewGrid.SelectedItems[i] is Crew crew)
                {
                    dbContext.Crews.Remove(crew);
                }
            }
        }
        else
        {
            MessageBox.Show("Выберете экипаж для удаления");
            return;
        }

        dbContext.SaveChanges();
        RefreshCrewGrid();
    }

    private void AddFlightButtonClick(object sender, RoutedEventArgs e)
    {
        Flight newFlight = new Flight();
        var editFlightWindow = new EditFlightWindow(dbContext, newFlight, true);
        editFlightWindow.ShowDialog();
        RefreshFlightGrid();

    }

    private void EditFlightButtonClick(object sender, RoutedEventArgs e)
    {
        if (FlightGrid.SelectedItems.Count > 0)
        {
            var EditFlightWindow = new EditFlightWindow(dbContext, (Flight)FlightGrid.SelectedItems[0]!, false);
            EditFlightWindow.ShowDialog();
            dbContext.Entry((Flight)FlightGrid.SelectedItems[0]!).Reload();
            RefreshFlightGrid();
        }
        else
        {
            MessageBox.Show("Выберете рейс для редактирования");
            return;
        }

    }

    private void DeleteFlightButtonClick(object sender, RoutedEventArgs e)
    {
        if (FlightGrid.SelectedItems.Count > 0)
        {
            for (int i = 0; i < FlightGrid.SelectedItems.Count; i++)
            {
                if (FlightGrid.SelectedItems[i] is Flight flight)
                {
                    dbContext.Flights.Remove(flight);
                }
            }
        }
        else
        {
            MessageBox.Show("Выберете рейс для удаления");
            return;
        }

        dbContext.SaveChanges();
        RefreshFlightGrid();
    }

    private void AddDepartureButtonClick(object sender, RoutedEventArgs e)
    {
        Departure newDeparture = new Departure();
        var editDepartureWindow = new EditDepartureWindow(dbContext, newDeparture, true);
        editDepartureWindow.ShowDialog();
        RefreshDepartureGrid();

    }

    private void EditDepartureButtonClick(object sender, RoutedEventArgs e)
    {
        if (DepartureGrid.SelectedItems.Count > 0)
        {
            var editDepartureWindow = new EditDepartureWindow(dbContext, (Departure)DepartureGrid.SelectedItems[0]!, false);
            editDepartureWindow.ShowDialog();
            dbContext.Entry((Departure)DepartureGrid.SelectedItems[0]!).Reload();
            RefreshDepartureGrid();
        }
        else
        {
            MessageBox.Show("Выберете вылет для редактирования");
            return;
        }
    }


    private void DeleteDepartureButtonClick(object sender, RoutedEventArgs e)
    {
        if (DepartureGrid.SelectedItems.Count > 0)
        {
            for (int i = 0; i < DepartureGrid.SelectedItems.Count; i++)
            {
                if (DepartureGrid.SelectedItems[i] is Departure departure)
                {
                    dbContext.Departures.Remove(departure);
                }
            }
        }
        else
        {
            MessageBox.Show("Выберете вылет для удаления");
            return;
        }

        dbContext.SaveChanges();
        RefreshDepartureGrid();
    }

    private void DeleteTicketButtonClick(object sender, RoutedEventArgs e)
    {
        if (TicketGrid.SelectedItems.Count > 0)
        {
            for (int i = 0; i < TicketGrid.SelectedItems.Count; i++)
            {
                if (TicketGrid.SelectedItems[i] is Ticket ticket)
                {
                    dbContext.Tickets.Remove(ticket);
                }
            }
        }
        else
        {
            MessageBox.Show("Выберете билет для удаления");
            return;
        }
        dbContext.SaveChanges();
        RefreshTicketGrid();
    }

    private void EditTicketButtonClick(object sender, RoutedEventArgs e)
    {


        if (TicketGrid.SelectedItems.Count > 0)
        {
            var editTicketWindow = new EditTicketWindow(dbContext, (Ticket)TicketGrid.SelectedItems[0]!, false);
            editTicketWindow.ShowDialog();
            dbContext.Entry((Ticket)TicketGrid.SelectedItems[0]!).Reload();
            RefreshTicketGrid();
        }
        else
        {
            MessageBox.Show("Выберете билет для редактирования");
            return;
        }
    }

    private void AddTicketButtonClick(object sender, RoutedEventArgs e)
    {
        Ticket newTicket = new Ticket();
        var editTicketWindow = new EditTicketWindow(dbContext, newTicket, true);
        editTicketWindow.ShowDialog();
        RefreshTicketGrid();
    }

    private void EditAccessRightButtonClick(object sender, RoutedEventArgs e)
    {
        if (UserGrid.SelectedItems.Count > 0)
        {
            var editAccessRightWindow = new EditAccessRightWindow(dbContext, (User)UserGrid.SelectedItems[0]!);
            editAccessRightWindow.ShowDialog();
            dbContext.Entry((User)UserGrid.SelectedItems[0]!).Reload();
            RefreshUserGrid();
        } 
        else
        {
                MessageBox.Show("Выберете пользователя для редактирования прав");
                return;
        }
    }

    private void DeleteUserButtonClick(object sender, RoutedEventArgs e)
    {
        if (UserGrid.SelectedItems.Count > 0)
        {
            for (int i = 0; i < UserGrid.SelectedItems.Count; i++)
            {
                if (UserGrid.SelectedItems[i] is User user)
                {
                    if (user.UserType != UserType.admin) {
                    dbContext.Users.Remove(user);
                    } else
                    {
                        MessageBox.Show("Вы не можете удалить администратора");
                        return;
                    }
                }
            }
        }
        else
        {
            MessageBox.Show("Выберете пользователя для удаления");
            return;
        }

        dbContext.SaveChanges();
        RefreshTicketGrid();
    }

    private void RecoverPasswordButtonClick(object sender, RoutedEventArgs e)
    {
        var oldPassword = OldPasswordTexBox.Password;
        var newPassword = NewPasswordTexBox.Password;
        var confirmPassword = ConfirmPasswordTexBox.Password;

        if (oldPassword == String.Empty)
        {
            MessageBox.Show("Старый может быть пустым");
            return;
        }
        if (newPassword == String.Empty)
        {
            MessageBox.Show("Новый пароль не может быть пустым");
            return;
        }
        if (confirmPassword == String.Empty)
        {
            MessageBox.Show("Подтвержение пароля не может быть пустым");
            return;
        }
        if (newPassword.Length < 5)
        {
            MessageBox.Show("Новый пароль не может быть меньше 5 символов");
            return;
        }
        if (confirmPassword.Length < 5)
        {
            MessageBox.Show("Подтвержение пароля не может быть меньше 5 символов");
            return;
        }

        if (User.Password == PasswordEncrypter.GetHash(oldPassword))
        {
            if (newPassword == confirmPassword)
            {
                var PasswordHash = PasswordEncrypter.GetHash(newPassword);
                User.Password = PasswordHash;
                dbContext.SaveChanges();
                OldPasswordTexBox.Password = string.Empty;
                NewPasswordTexBox.Password = string.Empty;
                ConfirmPasswordTexBox.Password = string.Empty;
                MessageBox.Show("Пароль успешно изменён!");

            }
            else
            {
                MessageBox.Show("Новые пароли не совпадают");
            }

        }
        else
        {
            MessageBox.Show("Старый пароль неправильный");
        }

    }
}




