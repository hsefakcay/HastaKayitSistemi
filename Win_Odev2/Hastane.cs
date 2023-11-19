using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_Odev2
{
    internal class Hastane
    {
        // Hastane genel bilgileri
        public string HastaneAdi { get; set; }
        public string Hastaneİli { get; set; }
        public string HastaneIlce { get; set; }

        public string HastaneTelefon { get; set; }

        // Hastanenin poliklinikleri
        public List<string> Poliklinikler { get; set; }


        public string poliklinlerStringHali;

        public override string ToString()
        {

            foreach (var item in Poliklinikler)
            {
                poliklinlerStringHali += (item.ToString() +"/");
            }
            return $" {HastaneAdi} - {Hastaneİli} - {HastaneIlce} - {HastaneTelefon} - {poliklinlerStringHali}";
        }
    }
}
