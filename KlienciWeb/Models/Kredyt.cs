using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KlienciWeb.Models
{
    public class Kredyt
    {
        public int IdTransakcji { get; set; }
        public int IdKlienta { get; set; }
        public decimal Kwota { get; set; }
        public string Waluta { get; set; }

    }
}