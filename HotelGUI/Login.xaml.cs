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
    /// Interaktionslogik für Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        CheckData d1 = new CheckData();
        public Login()
        {
            InitializeComponent();
        }
        
        private void onclickSubmit(object sender, RoutedEventArgs e)
        {
            string uncheckedUSN = lt1.Text;
            string uncheckedPW = lt2.Text;
             

            
           
            if(uncheckedUSN != "" && uncheckedPW != "" && uncheckedUSN != "Enter Username" && uncheckedPW != "Enter Password")
            {
               
                if (d1.isUserInDB(uncheckedUSN, uncheckedPW) == true){
                    label1.Foreground = new SolidColorBrush(Colors.Green);
                    lolxd.Foreground = new SolidColorBrush(Colors.Green);
                    HiddenMessage.Foreground = new SolidColorBrush(Colors.Green);
                    HiddenMessage.Content = "accepted";
                }
                else
                 {
                 HiddenMessage.Content = "false";
                 }
            }
            else
            {
                label1.Foreground = new SolidColorBrush(Colors.Red);
                lolxd.Foreground = new SolidColorBrush(Colors.Red);
                HiddenMessage.Foreground = new SolidColorBrush(Colors.Red);
                HiddenMessage.Content = " Username or Password cant be empty";
            }
            
           
            
        }
    }
}
