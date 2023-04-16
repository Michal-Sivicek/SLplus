using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScitaniLidu
{
    public class BusinessLogicLayer
    {
        /// <summary>
        /// Tato metoda slouží k vytvoření nového uživatele a jeho vložení do databáze.
        /// Metoda přijímá několik parametrů, které obsahují údaje o novém uživateli
        /// (jeho jméno, příjmení, adresa bydliště, datum narození, telefonní číslo, email, národnost, státní občanství a vzdělání).
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        /// <param name="bydliste"></param>
        /// <param name="datum_narozeni"></param>
        /// <param name="telefonni_cislo"></param>
        /// <param name="email"></param>
        /// <param name="narodnost"></param>
        /// <param name="statni_obcanstvi"></param>
        /// <param name="vzdelani"></param>
        /// <returns></returns>
        public bool InsertUser(string jmeno, string prijmeni, string bydliste, string datum_narozeni, string telefonni_cislo, string email, string narodnost, string statni_obcanstvi, string vzdelani)
        {
            //vytvoření objektu uživatele s daty
            UserPopulation user = new UserPopulation();
            user.jmeno = jmeno;
            user.prijmeni = prijmeni;
            user.bydliste = bydliste;
            user.datum_narozeni = datum_narozeni;
            user.telefonni_cislo = telefonni_cislo;
            user.email = email;
            user.narodnost = narodnost;
            user.statni_obcanstvi = statni_obcanstvi;
            user.vzdelani = vzdelani;

            //volání metody pro vložení uživatele do databáze
            DataAccessLayer DAL = new DataAccessLayer();
            bool result = DAL.InsertUser(user);

            return result;
        }

        /// <summary>
        /// Tato metoda slouží k vytvoření nového domu a jeho vložení do databáze.
        /// Metoda přijímá několik parametrů, které obsahují údaje o novém domu
        /// (jméno a příjmení majitele, obec, číslo domu, ulice, PSČ, obydlenost domu, rok výstavby, materiál zdí a počet podlaží).
        /// </summary>
        /// <param name="jmeno_prijmeni"></param>
        /// <param name="obec"></param>
        /// <param name="cislo_domu"></param>
        /// <param name="ulice"></param>
        /// <param name="psc"></param>
        /// <param name="obydlenost_domu"></param>
        /// <param name="rok_vystavby"></param>
        /// <param name="material_zdi"></param>
        /// <param name="pocet_podlazi"></param>
        /// <returns></returns>
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
            DataAccessLayer DAL = new DataAccessLayer();
            bool result = DAL.InsertHouse(house);

            return result;
        }


        /// <summary>
        /// Tato metoda vkládá nový záznam o bytu do databáze.
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="obec"></param>
        /// <param name="cislo_domu"></param>
        /// <param name="ulice"></param>
        /// <param name="psc"></param>
        /// <param name="obydlenost_bytu"></param>
        /// <param name="velikost_bytu"></param>
        /// <param name="podlazi_bytu"></param>
        /// <param name="pocet_lidi"></param>
        /// <returns></returns>
        public bool InsertFlats(string jmeno, string obec, string cislo_domu, string ulice, string psc, string obydlenost_bytu, string velikost_bytu, string podlazi_bytu, string pocet_lidi)
        {
            //vytvoření objektu domu s daty
            UserFlats flats = new UserFlats();
            flats.jmeno = jmeno;
            flats.obec = obec;
            flats.cislo_domu = cislo_domu;
            flats.ulice = ulice;
            flats.psc = psc;
            flats.obydlenost_bytu = obydlenost_bytu;
            flats.velikost_bytu = velikost_bytu;
            flats.podlazi_bytu = podlazi_bytu;
            flats.pocet_lidi = pocet_lidi;

            //volání metody pro vložení domu do databáze
            DataAccessLayer DAL = new DataAccessLayer();
            bool result = DAL.InsertFlats(flats);

            return result;
        }

        /// <summary>
        /// Tato metoda načítá a vrací seznam všech uživatelů v databázi. Nejprve vytvoří objekt DataAccessLayer, který slouží k interakci s databází.
        /// Poté zavolá metodu GetAllUsers v objektu DAL a vrátí výsledek této metody, což je seznam uživatelů v databázi.
        /// </summary>
        /// <returns></returns>
        public List<UserPopulation> GetAllUsers()
        {
            DataAccessLayer DAL = new DataAccessLayer();
            return DAL.GetAllUsers();
        }

        /// <summary>
        /// Tato metoda načítá a vrací seznam všech domů v databázi. Nejprve vytvoří objekt DataAccessLayer, který slouží k interakci s databází.
        /// Poté zavolá metodu GetAllUsers v objektu DAL a vrátí výsledek této metody, což je seznam uživatelů v databázi.
        /// </summary>
        /// <returns></returns>
        public List<UserHouse> GetAllUserHouses()
        {
            DataAccessLayer DAL = new DataAccessLayer();
            return DAL.GetAllUserHouses();
        }

        /// <summary>
        /// Tato metoda načítá a vrací seznam všech domů v databázi. Nejprve vytvoří objekt DataAccessLayer, který slouží k interakci s databází.
        /// Poté zavolá metodu GetAllUsers v objektu DAL a vrátí výsledek této metody, což je seznam uživatelů v databázi.
        /// </summary>
        /// <returns></returns>
        public List<UserFlats> GetAllUserFlats()
        {
            DataAccessLayer DAL = new DataAccessLayer();
            return DAL.GetAllUserFlats();
        } 
    }
}
