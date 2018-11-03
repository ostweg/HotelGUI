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

namespace HotelGUI
{
    /// <summary>
    /// Interaktionslogik für Menu2.xaml
    /// </summary>
    public partial class Menu2 : Window
    {
        public Menu2()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Do you really want to log out?", "Salü zeme", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                System.Environment.Exit(0);
            }
        }

        private void bClick(object sender, RoutedEventArgs e)
        {

        }

        private void b1Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
