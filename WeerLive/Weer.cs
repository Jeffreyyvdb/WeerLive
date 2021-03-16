using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.IO;

namespace WeerLive
{
    public class Weer
    {
        public string plaatsNaam { get; set; }

        public string plaats { get; set; }
        public string temp { get; set; }
        public string gtemp { get; set; }
        public string samenv { get; set; }
        public string lv { get; set; }
        public string windr { get; set; }
        public string windms { get; set; }
        public string winds { get; set; }
        public string windk { get; set; }
        public string windkmh { get; set; }
        public string luchtd { get; set; }
        public string ldmmhg { get; set; }
        public string dauwp { get; set; }
        public string zicht { get; set; }
        public string verw { get; set; }
        public string sup { get; set; }
        public string sunder { get; set; }
        public string image { get; set; }
        public string d0weer { get; set; }
        public string d0tmax { get; set; }
        public string d0tmin { get; set; }
        public string d0windk { get; set; }
        public string d0windknp { get; set; }
        public string d0windms { get; set; }
        public string d0windkmh { get; set; }
        public string d0windr { get; set; }
        public string d0neerslag { get; set; }
        public string d0zon { get; set; }
        public string d1weer { get; set; }
        public string d1tmax { get; set; }
        public string d1tmin { get; set; }
        public string d1windk { get; set; }
        public string d1windknp { get; set; }
        public string d1windms { get; set; }
        public string d1windkmh { get; set; }
        public string d1windr { get; set; }
        public string d1neerslag { get; set; }
        public string d1zon { get; set; }
        public string d2weer { get; set; }
        public string d2tmax { get; set; }
        public string d2tmin { get; set; }
        public string d2windk { get; set; }
        public string d2windknp { get; set; }
        public string d2windms { get; set; }
        public string d2windkmh { get; set; }
        public string d2windr { get; set; }
        public string d2neerslag { get; set; }
        public string d2zon { get; set; }
        public string alarm { get; set; }

        public DateTime datum { get; set; }


        const string API_KEY = "aadaeb7685";
        const string path_Weer = @"../../../geladenWeer.json";
        static List<Weer> weerList = new List<Weer>();
        static int i = 0;

        public static Weer WeerPlaats(string plaats)
        {
            //Make a httpClient for getting api data
            HttpClient client = new HttpClient();
            //Url for api + key + plaats
            client.BaseAddress = new Uri("https://weerlive.nl/api/json-data-10min.php?key=" + API_KEY + "&locatie=" + plaats);
            //Async response 
            HttpResponseMessage response = client.GetAsync("").Result;
            //Response naar variabele Liveweer
            var result = response.Content.ReadAsStringAsync().Result;
            //Weer object van api data liveweer 0 anders hebben wij een array met data erin.
            Weer rWeer = JsonConvert.DeserializeObject<Root>(result).liveweer[0];

            rWeer.plaatsNaam = plaats;
            rWeer.datum = DateTime.Now;

            //Kijk of het weer nog niet voorkomt in de lijst.
            if (!weerList.Contains(rWeer) && i != 0)
                weerList.Add(rWeer);
            else if (!weerList.Contains(rWeer) && i == 0)
                weerList.Add(rWeer);

            //Maak een weer array met de lengthe van de weerlijst
            Weer[] weerArray = new Weer[weerList.Count];
            int j = 0;
            //add weerlijst objecten in de weer array
            foreach (Weer weer in weerList)
            {
                weerArray[j] = weer;
                j++;
            }
            i++;
            //serialize de weer array
            string x = JsonConvert.SerializeObject(weerArray, Formatting.Indented);
            //Schrijf naar file
            File.WriteAllText(path_Weer, x);
            //Return weer naar Programma zodat we de data kunnen laten zien.
            return rWeer;
        }

    }

    
    public class Root
    {
        public List<Weer> liveweer { get; set; }
    }
}
