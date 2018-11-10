using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace HotelGUI
{
    /// <summary>
    /// Interaktionslogik für LoadHotelData.xaml
    /// </summary>
    public partial class LoadHotelData : Page
    {
        public static M120Entities m11 = new M120Entities();
        public LoadHotelData()
        {
            InitializeComponent();
        }
        public void groupDataGrid()
        {
            //ICollectionView cv = CollectionViewSource.GetDefaultView(dataGrid.ItemsSource);
            
        }
        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = m11.Hotels.ToList();
                     
        }
    }
}
