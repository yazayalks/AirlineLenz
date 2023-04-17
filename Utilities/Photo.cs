using AirlineLenz.Files;
using AirlineLenz.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows;
using System.Windows.Controls;

namespace AirlineLenz.Utilities
{
    public class Photo
    {
        public static BitmapImage BitmapPhoto { get; set; }
     
        public static void LoadPhoto(string base64, Image PhotoImage, Liner liner)
        {
            liner.Photo = base64;
            byte[] binaryData = Convert.FromBase64String(base64);
            BitmapPhoto = new BitmapImage();
            BitmapPhoto.BeginInit();
            BitmapPhoto.StreamSource = new MemoryStream(binaryData);
            BitmapPhoto.EndInit();
            PhotoImage.Source = BitmapPhoto;
        }
        public static void AddPhoto(Liner liner, Image PhotoImage)
        {

            // Create OpenFileDialog 
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();



            // Set filter for file extension and default file extension 
            dlg.DefaultExt = ".png";
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";


            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();


            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filePath = dlg.FileName;
                byte[] imageArray = System.IO.File.ReadAllBytes(filePath);
                string base64ImageRepresentation = Convert.ToBase64String(imageArray);
                liner.Photo = base64ImageRepresentation;
                LoadPhoto(liner.Photo ?? LinerPhoto.img, PhotoImage, liner);
            }
        }
    }
}
