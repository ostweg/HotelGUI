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

namespace HotelGUI
{
    /// <summary>
    /// Interaktionslogik für Hotels.xaml
    /// </summary>
    public partial class Hotels : Page
    {
        public Hotels()
        {
            InitializeComponent();
        }

        private void gotosavemenu(object sender, RoutedEventArgs e)
        {
            PopUpSaveMenu popupSave = new PopUpSaveMenu();
            popupSave.Show();
            
        }
    }
}
