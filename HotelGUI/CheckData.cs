using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelGUI
{
    class CheckData
    {
        /// <summary>
        /// Func that returns true or false based of params.
        /// </summary>
        M120Entities e1;
        GUIUSER g1;
        GUIUSER g2;
        
        public bool isUserInDB(string usn, string pw) {
           
            using(e1 = new M120Entities())
            {
                // TODO: Fix null ref on g1, g2 instances
                g1 = e1.GUIUSERs.FirstOrDefault(r => r.Gu_Benutzername == usn );
                g2 = e1.GUIUSERs.FirstOrDefault(p => p.GU_Password == pw);

                if (g1.Gu_Benutzername == usn && g2.GU_Password == pw)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                           

            }

        }
    }
}
