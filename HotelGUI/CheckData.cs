using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics.Contracts;
using System.IO;
using System.Drawing;

namespace HotelGUI
{
    class CheckData
    {
        /// <summary>
        /// Func that returns true or false based of params.
        /// </summary>
        M120Entities e1;
        Menu2 m1;
        GUIUSER g1 = new GUIUSER();
        GUIUSER g2 = new GUIUSER();
       // public byte[] Content { get; set; }


        //Saves Image to DB
        public byte[] SaveImageToByte(Image image, string desc)
        {
            MemoryStream m1 = new MemoryStream();
            image.Save(m1, System.Drawing.Imaging.ImageFormat.Gif);
            saveImageToDb(m1.ToArray(), desc);
            return m1.ToArray();
        }
        //returns Image from DB
       /* public Image bytearray()
        {
            MemoryStream m2 = new MemoryStream();
            Image returnImage = Image.FromStream(m2);
            return returnImage;
        }*/
       public void saveImageToDb(byte[] img, string description)
        {
            using(e1 = new M120Entities()){

                HotelBild b1 = new HotelBild
                {
                    Beschreibung = description,
                    Bild = img
                };
                e1.HotelBilds.Add(b1);
                e1.SaveChanges();
            }
        }
        public bool isUserInDB(string usn, string pw) {
           
            using(e1 = new M120Entities())
            {
                
                g1 = e1.GUIUSERs.FirstOrDefault(r => r.Gu_Benutzername == usn );
                g2 = e1.GUIUSERs.FirstOrDefault(p => p.GU_Password == pw);

             
                if (g1.Gu_Benutzername == usn && g2.GU_Password == pw /*&& g1 != null && g2 != null*/)
                {
                    m1 = new Menu2();
                    m1.Show();
                   
                    return true;
                }
                else
                {
                    return false;
                }
               
               
                
            }


        }
        public void saveUserToDB(string anrede,string vorname,string name,string namezusatz,string strassennr, short plz, string ort,string telefon, string mobile, string email,string web, DateTime geburtsdatum, string passnr, long nationalität, string usn, string pw)
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
                    GUIUSER g1 = new GUIUSER
                    {
                        Gu_Benutzername = usn,
                        GU_Password = pw,
                    };

                     m1 = new Menu2();
                    m1.Show();
                    e1.GUIUSERs.Add(g1);
                    e1.Kundes.Add(k1);
                    e1.SaveChanges();
                }
                
           
          
        }
   
    }
}
