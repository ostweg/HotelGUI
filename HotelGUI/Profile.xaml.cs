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
    /// Interaktionslogik für Profile.xaml
    /// </summary>
    public partial class Profile : Page
    {
        
        
        public Profile()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            c3.Content = new UpdateorDelete();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            c3.Content = new UserDiagram();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            c3.Content = new LoadUserData();
        }
    }
}
