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
    /// Interaktionslogik für UserDiagram.xaml
    /// </summary>
    public partial class UserDiagram : Page
    {
        M120Entities m120;
        public UserDiagram()
        {
            InitializeComponent();


            using (m120 = new M120Entities())
            {
                var k1 = m120.Kundes.Count(c => c.Anrede == "Herr");
                var k2 = m120.Kundes.Count(x => x.Anrede == "Frau");

                if (k1 > 0 || k2 > 0)
                {
                    tblockHerren.Text = k1.ToString();
                    tblockHerren.Height = k1 * 20;

                    tblockFrauen.Text = k2.ToString();
                    tblockFrauen.Height = k2 * 20;
                }
                else if(k1 == 0)
                {
                    tblockHerren.Text = k1.ToString();
                    tblockHerren.Height = 0;
                }
                else if(k2 == 0)
                {
                    
                    tblockFrauen.Text = k2.ToString();
                    tblockFrauen.Height = 0;
                }
                
            }

        }
        
    }
}
