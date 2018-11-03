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
        GUIUSER g1 = new GUIUSER();
        GUIUSER g2 = new GUIUSER();
        
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
        public void saveUserToDB(string anrede,string vorname,string name,string namezusatz,string strassennr, short plz, string ort,string telefon, string mobile, string email,string web, DateTime geburtsdatum, string passnr, long nationalität)
        {
            if(anrede != "" && vorname !="" && name !="" && plz != 0 && ort != "" && email != "" && geburtsdatum != null)
            {
                using(e1 = new M120Entities())
                {
                    Kunde k1 = new Kunde
                    {
                        Anrede = anrede,
                        Vorname = vorname,
                        Name = name,
                        NameZusatz = namezusatz,
                        StrasseNr = strassennr,
                        PLZ = plz,
                        Ort = ort,
                        Telefon = telefon,
                        Mobile = mobile,
                        Email = email,
                        Web = web,
                        Geburtsdatum = geburtsdatum,
                        PassNr = passnr,
                        Nationalitaet = nationalität

                    };
                    e1.Kundes.Add(k1);
                    e1.SaveChanges();
                }

            }
               
        }
   
    }
}
