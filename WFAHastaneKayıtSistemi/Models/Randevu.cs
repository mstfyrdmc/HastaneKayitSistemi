using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAHastaneKayıtSistemi.Models
{
    public class Randevu
    {
        public Hekim SeciliHekim { get; set; }
        public Il SeciliIl { get; set; }
        public Hastane SeciliHastane { get; set; }
        public Saat SeciliSaat { get; set; }
        
        
        public override string ToString()
        {
            return $" Hekimi : {SeciliHekim} ,İl: {SeciliIl},  Hastane: {SeciliHastane},  Saat: {SeciliSaat}";
        }

        
    }
}
