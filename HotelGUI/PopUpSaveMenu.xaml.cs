using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;

using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Drawing;

namespace HotelGUI
{
    /// <summary>
    /// Interaktionslogik für PopUpSaveMenu.xaml
    /// </summary>
    public partial class PopUpSaveMenu : Window
    {
        private string filePath;
       
       
        CheckData checkData = new CheckData();
        
        public PopUpSaveMenu()
        {
            InitializeComponent();
        }

        private void openDialog(object sender, RoutedEventArgs e)
        {
            OpenFileDialog o1 = new OpenFileDialog();
            o1.Filter = "Bilder(.jpg,.png)|*.png;*.jpg";
            if(o1.ShowDialog() == true)
            {
                filePath = o1.FileName;
                img1.Source = new BitmapImage(new Uri(filePath));
                if(tbdesc.Text.Trim().Length == 0)
                {
                    tbdesc.Text = System.IO.Path.GetFileName(filePath);
                }
                //checkData.SaveImageToByte(o1.FileName);
               
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Clear image
            tbdesc.Clear();
            img1.Source = new BitmapImage(new Uri("C:\\Daten\\404\\HotelGUI\\noimg.png"));
            filePath = "";
        }

        private void saveImage(object sender, RoutedEventArgs e)
        {
            //Save Image
            if(tbdesc.Text != "")
            {
                if(filePath != "")
                {
                    //checkData.SaveImageToByte(new Image(filePath),tbdesc.Text);
                }
                else
                {
                    labelhidden.Foreground = new SolidColorBrush(Colors.PaleVioletRed);
                    labelhidden.Content = "Path can't be empty";

                }
            }
            else
            {
                labelhidden.Foreground = new SolidColorBrush(Colors.PaleVioletRed);
                labelhidden.Content = "Description can't be empty";
            }
            
        }
    }
}
