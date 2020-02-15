using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAHastaneKayıtSistemi.Models
{
    public class Saat
    {
        
        public string Saatler { get; set; }
        
        public override string ToString()
        {
            return $"{Saatler}";
        }
    }
}
