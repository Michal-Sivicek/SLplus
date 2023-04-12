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
        public bool InsertUser(string jmeno, string prijmeni, string bydliste, string nabozenstvi, string telefonni_cislo, string email, string narodnost, string statni_obcanstvi, string vzdelani)
        {
            //vytvoření objektu uživatele s daty
            UserPopulation user = new UserPopulation();
            user.jmeno = jmeno;
            user.prijmeni = prijmeni;
            user.bydliste = bydliste;
            user.nabozenstvi = nabozenstvi;
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
    }
}
