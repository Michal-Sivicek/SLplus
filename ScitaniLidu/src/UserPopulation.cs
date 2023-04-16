using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScitaniLidu
{
    //Třída UserPopulation slouží k uchování informací o obyvatelstvu uživatelů. Třída obsahuje vlastnosti, které představují různé údaje o obyvatelstvu
    public class UserPopulation
    {
        public string jmeno { get; set; }
        public string prijmeni { get; set; }
        public string bydliste { get; set; }
        public string datum_narozeni { get; set; }
        public string telefonni_cislo { get; set; }
        public string email { get; set; }
        public string narodnost { get; set; }
        public string statni_obcanstvi { get; set; }
        public string vzdelani { get; set; }
    }
}
