using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_Odev2
{
    internal class Hasta
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TamAd { get; set; }
        public string Adres { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Meslek { get; set; }
        public string Cinsiyet { get; set; }

        public Image Foto { get; set; }

        public override string ToString()
        {
            return $" {TamAd} - {Telefon} - {Email} - {Meslek} - {Cinsiyet} - {Adres}";
        }
    }
    


}
