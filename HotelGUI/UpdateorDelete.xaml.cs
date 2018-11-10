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
        public string updatedMessage()
        {
            hiddenLabel2.Foreground = new SolidColorBrush(Colors.ForestGreen);
            return "Values have been updated";
        }
        private void updateValuesOnClick(object sender, RoutedEventArgs e)
        {
            using(e1 = new M120Entities())
            {
                k1 = e1.Kundes.FirstOrDefault(c => c.Name == tbLoad.Text);
                try
                {


                    if (k1.Anrede == "Frau" && l2.IsChecked == false)
                    {
                        k1.Anrede = "Herr";
                        hiddenLabel2.Content = updatedMessage();
                    }
                    else if (k1.Anrede == "Herr" && l1.IsChecked == false)
                    {
                        k1.Anrede = "Frau";
                        hiddenLabel2.Content = updatedMessage();
                    }
                    else if (tbName.Text != k1.Name)
                    {
                        k1.Name = tbName.Text;
                        hiddenLabel2.Content = updatedMessage();
                    }
                    else if (tbVorname.Text != k1.Vorname)
                    {
                        k1.Vorname = tbVorname.Text;
                        hiddenLabel2.Content = updatedMessage();
                    }
                    else if (tbPlz.Text != k1.PLZ.ToString())
                    {
                        k1.PLZ = Convert.ToInt16(tbPlz.Text);
                        hiddenLabel2.Content = updatedMessage();
                    }
                    else if (tbOrt.Text != k1.Ort)
                    {
                        k1.Ort = tbOrt.Text;
                        hiddenLabel2.Content = updatedMessage();
                    }
                    else if (tbEmail.Text != k1.Email)
                    {
                        k1.Email = tbEmail.Text;
                        hiddenLabel2.Content = updatedMessage();
                    }
                    else if (DateTime.Parse(tbBirthdate.SelectedDate.ToString()) != k1.Geburtsdatum)
                    {
                        k1.Geburtsdatum = DateTime.Parse(tbBirthdate.SelectedDate.ToString());
                        hiddenLabel2.Content = updatedMessage();
                    }
                    else
                    {
                        hiddenLabel2.Foreground = new SolidColorBrush(Colors.Yellow);
                        hiddenLabel2.Content = "Nothing Updated";
                    }
                    e1.SaveChanges();
                }
                catch(NullReferenceException x)
                {
                    MessageBox.Show(x.Message);
                }
                

            }
        }

        private void deleteValuesOnClick(object sender, RoutedEventArgs e)
        {
            using(e1 = new M120Entities())
            {
                k1 = e1.Kundes.FirstOrDefault(c => c.Name == tbLoad.Text);
                e1.Kundes.Remove(k1);
                e1.SaveChanges();
                hiddenLabel2.Foreground = new SolidColorBrush(Colors.ForestGreen);
                hiddenLabel2.Content = "Successfully deleted";
            }
        }
    }
}
