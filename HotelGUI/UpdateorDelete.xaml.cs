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
    /// Interaktionslogik für UpdateorDelete.xaml
    /// </summary>
    public partial class UpdateorDelete : Page
    {
        M120Entities e1;
        CheckData cd1 = new CheckData();
        Kunde k1 = new Kunde();
        public UpdateorDelete()
        {
            InitializeComponent();
        }
      
        
        
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using(e1 = new M120Entities())
            {
                k1 = e1.Kundes.FirstOrDefault(c => c.Name == tbLoad.Text);
                if(k1 != null)
                {
                    hiddenLabel.Foreground = new SolidColorBrush(Colors.ForestGreen);
                    hiddenLabel.Content = "User Found";
                    if(k1.Anrede == "Frau")
                    {
                        l2.IsChecked = true;
                    }
                    else
                    {
                        l1.IsChecked = true;
                    }
                    tbName.Text = k1.Name;
                    tbVorname.Text = k1.Vorname;
                    tbPlz.Text = k1.PLZ.ToString();
                    tbOrt.Text = k1.Ort;
                    tbEmail.Text = k1.Email;
                    tbBirthdate.SelectedDate = DateTime.Parse(k1.Geburtsdatum.ToString());


                }else
                {
                    hiddenLabel.Foreground = new SolidColorBrush(Colors.PaleVioletRed);
                    hiddenLabel.Content = "User not Found";
                }
            }
        }
    }
}
