using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScitaniLidu
{
    internal static class Config
    {

        //Tato metoda slouží k načtení konfiguračních dat ze souboru config.json pokud soubor neexistuje metoda zavolá metodu makeConfig

        /// <summary>
        /// Tato metoda slouží k načtení konfiguračních dat uložených v souboru "config.json".
        /// Pokud soubor neexistuje, metoda volá metodu "makeConfig()" pro vytvoření nového souboru.
        /// </summary>
        /// <returns></returns>
        public static dynamic GetConfig()
        {

            if (!File.Exists("config.json"))
            {
                makeConfig();
            }

            string json = File.ReadAllText("config.json");
            return JsonConvert.DeserializeObject(json);

        }

        //Tato metoda slouží k vytvoření souboru config.json s výchozými daty

        /// <summary>
        /// Tato metoda vytváří konfigurační soubor pro připojení k databázi v případě, že soubor neexistuje.
        /// Konfigurace se ukládá ve formátu JSON a obsahuje informace o serveru, databázi a přihlašovacích údajích.
        /// Konfigurační soubor se ukládá do souboru "config.json" v aktuálním adresáři.
        /// </summary>
        static void makeConfig()
        {
            string configText = @"{
""server"": ""37.120.169.246"",
""database"": ""loginScitaniLidu"",
""uid"": ""michal30"",
""password"": ""xgamerx""
}";

            File.WriteAllText("config.json", configText);

        }
    }
}
