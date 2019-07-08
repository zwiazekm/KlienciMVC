using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KlienciWeb.Models
{
    public class Klient
    {
        public int IdKlienta { get; set; }
        public string Nazwa { get; set; }
        public string NIP { get; set; }
        public DateTime DataModyfikacji { get; set; }

    }


}