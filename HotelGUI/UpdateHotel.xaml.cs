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
    /// Interaktionslogik für UpdateHotel.xaml
    /// </summary>
    public partial class UpdateHotel : Page
    {
        M120Entities e1;
        CheckData cd1 = new CheckData();
        Hotel k1 = new Hotel();
        Land k2 = new Land();
        public UpdateHotel()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (e1 = new M120Entities())
            {
                try
                {
                    k1 = e1.Hotels.FirstOrDefault(c => c.Name == tbLoad.Text);
                    k2 = e1.Lands.FirstOrDefault(c => c.LandID == k1.Land);

                    if (k1 != null)
                    {
                        hiddenLabel.Foreground = new SolidColorBrush(Colors.ForestGreen);
                        hiddenLabel.Content = "Hotel found";

                        tbOrt.Text = k1.Ort;
                        tbLand.Text = k2.Name;
                        tbSterne.Text = k1.Sterne.ToString();
                        tbManager.Text = k1.Manager;
                        tbAnzahlZimmer.Text = k1.AnzahlZimmer.ToString();
                        tbEmail.Text = k1.Email;
                        tbTäglicheKosten.Text = k1.TagesPreis.ToString();


                    }
                    else
                    {
                        hiddenLabel.Foreground = new SolidColorBrush(Colors.PaleVioletRed);
                        hiddenLabel.Content = "Hotel not found";
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No user found");
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
            using (e1 = new M120Entities())
            {
                k1 = e1.Hotels.FirstOrDefault(c => c.Name == tbLoad.Text);
                k2 = e1.Lands.FirstOrDefault(c => c.LandID == k1.Land);
                try
                {


                    if (tbOrt.Text != k1.Ort)
                    {
                        k1.Ort = tbOrt.Text;
                        hiddenLabel2.Content = updatedMessage();
                    }
                    else if (tbLand.Text != k2.Name)
                    {
                        k1.Land = k2.LandID;
                        hiddenLabel2.Content = updatedMessage();
                    }
                    else if (tbSterne.Text != k1.Sterne.ToString())
                    {
                        k1.Sterne = Convert.ToByte(tbSterne.Text);
                        hiddenLabel2.Content = updatedMessage();
                    }
                    else if (tbManager.Text != k1.Manager)
                    {
                        k1.Manager = tbManager.Text;
                        hiddenLabel2.Content = updatedMessage();
                    }
                    else if (tbAnzahlZimmer.Text != k1.AnzahlZimmer.ToString())
                    {
                        k1.AnzahlZimmer = Convert.ToInt16(tbAnzahlZimmer);
                        hiddenLabel2.Content = updatedMessage();
                    }
                    else if (tbEmail.Text != k1.Email)
                    {
                        k1.Email = tbEmail.Text;
                        hiddenLabel2.Content = updatedMessage();
                    }
                    else if (tbEmail.Text != k1.Email)
                    {
                        k1.TagesPreis = Convert.ToInt16(tbTäglicheKosten.Text);
                        hiddenLabel2.Content = updatedMessage();
                    }
                    
                    else
                    {
                        hiddenLabel2.Foreground = new SolidColorBrush(Colors.Yellow);
                        hiddenLabel2.Content = "Nothing Updated";
                    }
                    e1.SaveChanges();
                }
                catch (NullReferenceException x)
                {
                    MessageBox.Show(x.Message);
                }


            }
            

        }
       

        private void deleteValuesOnClick(object sender, RoutedEventArgs e)
        {
            using (e1 = new M120Entities())
            {
                k1 = e1.Hotels.FirstOrDefault(c => c.Name == tbLoad.Text);
                e1.Hotels.Remove(k1);
                e1.SaveChanges();
                hiddenLabel2.Foreground = new SolidColorBrush(Colors.ForestGreen);
                hiddenLabel2.Content = "Successfully deleted";
            }
        }
    }
}
