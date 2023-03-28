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

        public static dynamic GetConfig()
        {

            if (!File.Exists("config.json"))
            {
                makeConfig();
            }

            string json = File.ReadAllText("config.json");
            return JsonConvert.DeserializeObject(json);

        }


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
