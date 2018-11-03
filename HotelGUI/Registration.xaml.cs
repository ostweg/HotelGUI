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
    /// Interaktionslogik für Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        CheckData d2 = new CheckData();
        public Registration()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string uncheckedAnrede;

            if (r1 == null)
            {
                uncheckedAnrede = "Frau";
            }
            else
            {
                uncheckedAnrede = "Herr";
            }

            string uncheckedVorname= tb1.Text;
            string uncheckedName = tb2.Text;
            string uncheckedNameZ = tb3.Text;
            string uncheckedStrassenNr = tb4.Text;
            short uncheckedPlz = Convert.ToInt16(tb5.Text);
            string uncheckedOrt = tb6.Text;
            string uncheckedTelefon = tb7.Text;
            string uncheckedMobile = tb8.Text;
            string uncheckedEmail = tb9.Text;
            string uncheckedWeb = tb10.Text;
            DateTime uncheckedGeburtsdatum = Convert.ToDateTime(tb11.Text);
            string uncheckedPassNr = tb12.Text;
            long uncheckedNationalität = Convert.ToInt32(tb13.Text);

            d2.saveUserToDB(uncheckedAnrede, uncheckedVorname, uncheckedName, uncheckedNameZ, uncheckedStrassenNr, uncheckedPlz, uncheckedOrt,
                uncheckedTelefon, uncheckedMobile, uncheckedEmail, uncheckedWeb, uncheckedGeburtsdatum, uncheckedPassNr, uncheckedNationalität);
            

        }
    }
}
