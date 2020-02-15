using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAHastaneKayıtSistemi.Models
{
    public class Hekim : Insan
    {
        public string Unvan { get; set; }
        public string Uzmanlik { get; set; }

        public override string ToString()
        {
            return $"{Unvan}  {AdSoyad} - {Uzmanlik}";
        }

        
    }
}
