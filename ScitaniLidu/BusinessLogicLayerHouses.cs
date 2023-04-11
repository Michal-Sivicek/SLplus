using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScitaniLidu
{
    using Microsoft.VisualBasic.ApplicationServices;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ScitaniLidu
    {
        public class BusinessLogicLayerHouses
        {
            public bool InsertHouse(string jmeno_prijmeni, string obec, string cislo_domu, string ulice, string psc, string obydlenost_domu, string rok_vystavby, string material_zdi, string pocet_podlazi)
            {
                //vytvoření objektu domu s daty
                UserHouse house = new UserHouse();
                house.jmeno_prijmeni = jmeno_prijmeni;
                house.obec = obec;
                house.cislo_domu = cislo_domu;
                house.ulice = ulice;
                house.psc = psc;
                house.obydlenost_domu = obydlenost_domu;
                house.rok_vystavby = rok_vystavby;
                house.material_zdi = material_zdi;
                house.pocet_podlazi = pocet_podlazi;

                //volání metody pro vložení domu do databáze
                DataAccessLayerHouses DAL = new DataAccessLayerHouses();
                bool result = DAL.InsertHouse(house);

                return result;
            }
        }
    }

}
