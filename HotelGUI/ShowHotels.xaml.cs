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
using System.Collections.ObjectModel;

namespace HotelGUI
{
    /// <summary>
    /// Interaktionslogik für ShowHotels.xaml
    /// </summary>
    public partial class ShowHotels : UserControl
    {
        public ObservableCollection<HotelBild> Pics;

        public HotelBild Description { get; set; }
        

        
        public ShowHotels()
        {
            InitializeComponent();
        }
    }
}
