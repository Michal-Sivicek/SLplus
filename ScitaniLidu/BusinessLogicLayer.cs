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
            User user = new User();
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
    }
}
