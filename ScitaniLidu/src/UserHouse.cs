using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScitaniLidu
{
    //Třída UserHouse slouží k uchování informací o domácnostech uživatelů. Třída obsahuje vlastnosti, které představují různé údaje o domácnosti
    public class UserHouse
    {
        public string jmeno_prijmeni { get; set; }
        public string obec { get; set; }
        public string cislo_domu { get; set; }
        public string ulice { get; set; }
        public string psc { get; set; }
        public string obydlenost_domu { get; set; }
        public string rok_vystavby { get; set; }
        public string material_zdi { get; set; }
        public string pocet_podlazi { get; set; }
    }
}
