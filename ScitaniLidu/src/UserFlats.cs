using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScitaniLidu
{
    //Třída UserFlats slouží k uchování informací o bytových jednotkách uživatelů. Třída obsahuje vlastnosti, které představují různé údaje o bytové jednotce
    public class UserFlats
    {
        public string jmeno { get; set; }
        public string obec { get; set; }
        public string cislo_domu { get; set; }
        public string ulice { get; set; }
        public string psc { get; set; }
        public string obydlenost_bytu { get; set; }
        public string velikost_bytu { get; set; }
        public string podlazi_bytu { get; set; }
        public string pocet_lidi { get; set; }
    }
}
