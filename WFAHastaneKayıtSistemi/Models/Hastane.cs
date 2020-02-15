using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAHastaneKayıtSistemi.Models
{
    public class Hastane :Insan
    {
        public override string ToString()
        {
            return $"{AdSoyad}";
        }
    }
}
