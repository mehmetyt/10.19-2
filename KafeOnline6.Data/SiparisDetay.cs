﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeOnline6.Data
{
    public class SiparisDetay
    {
        public string UrunAd { get; set; } = string.Empty;
        public decimal BirimFiyati { get; set; }
        public int Adet { get; set; }
        public  string TutarTL { get { return Tutar().ToString("c2"); } }

        public decimal Tutar()
        {
            return Adet * BirimFiyati;
        }
    }
}
