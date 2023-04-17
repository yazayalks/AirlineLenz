using AirlineLenz.Files;
using AirlineLenz.Models;
using AirlineLenz.Utilities;
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

namespace AirlineLenz.Windows.LinerWindow
{
    /// <summary>
    /// Логика взаимодействия для EditLinerWindow.xaml
    /// </summary>
    public partial class EditLinerWindow : Window
    {
        private readonly AirlineLenzDbContext dbContext;
        public BitmapImage BitmapPhoto { get; set; }
        public Liner Liner { get; set; }
        public bool IsNewLiner { get; set; } = false;
        public List<LinerType> LinerTypeColumn { get; set; }
        public EditLinerWindow(AirlineLenzDbContext dbContext, Liner liner, bool isNewLiner)
        {
            InitializeComponent();
            DataContext = this;
            Liner = liner;
            IsNewLiner = isNewLiner;
            LinerTypeColumn = Enum.GetValues(typeof(LinerType)).Cast<LinerType>().ToList();
            this.dbContext = dbContext;
            PhotoImage.Source = BitmapPhoto;
          
            Photo.LoadPhoto(Liner.Photo ?? LinerPhoto.img, PhotoImage, liner);

            //this.Closing += EditLinerWindowClosing;

        }

        //private void EditLinerWindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    var MainWindow = new MainWindow();
        //    MainWindow.Show();
        //}


        private void SaveButton(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Liner.Name))
            {
                MessageBox.Show("Укажите имя");
                return;
            }
            try
            {
                if(IsNewLiner)
                {
                    dbContext.Liners.Add(Liner);
                }
     
                dbContext.SaveChanges();
                Close();
            }
            catch (DbUpdateException exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void AddPhotoButtonClick(object sender, RoutedEventArgs e)
        {
            Photo.AddPhoto(Liner, PhotoImage);
        }
    }
}
