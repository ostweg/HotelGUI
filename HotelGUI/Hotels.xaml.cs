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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.IO;

namespace HotelGUI
{
    /// <summary>
    /// Interaktionslogik für Hotels.xaml
    /// </summary>
    public partial class Hotels : Page
    {
        CheckData ch1 = new CheckData();
        public static M120Entities m11 = new M120Entities();
        List<HotelBild> l2 = m11.HotelBilds.ToList();
       
        public byte[] byteimagedata;
        public Hotels()
        {
            InitializeComponent();
            iterateThroughList();
            
        }
        //TODO: Iterate through all images and give them out
        public void iterateThroughList()
        {
            //https://stackoverflow.com/questions/41998142/converting-system-drawing-image-to-system-windows-media-imagesource-with-no-resu
            foreach (HotelBild bild in l2)
            {
                
                /*System.Drawing.Image b1 = ch1.bytearray(bild.Bild);
                var b2 = Encoding.Default.GetString(bild.Bild);
                l1.Source = new BitmapImage(new Uri(b2));*/

                
                
            }
           
        }
        private void gotosavemenu(object sender, RoutedEventArgs e)
        {
            
            
        }

        private void frame1_Loaded(object sender, RoutedEventArgs e)
        {
            //frame1.Content = new ShowHotels();
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            

        }

        private void ribbonButton3Click(object sender, RoutedEventArgs e)
        {
            frame1.Content = new AddHotels();
            
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            frame1.Content = new LoadHotelData();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            frame1.Content = new UpdateHotel();
        }
    }
}
