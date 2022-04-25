using System;
using System.Collections.Generic;
using System.Text;

namespace ÖdevBaslangic
{
    public class MusteriTemsilcisi
    {
        public int MusteriTemsilcisiTanimlayici { get; set; }
        public string TemsilciTuru { get; set; }
        public Boolean UygunMu { get; set; }

        public SimlpeArrayTypedQueue cagrilar = new SimlpeArrayTypedQueue(100);
    }
}
