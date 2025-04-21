using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

//For each class, gets a list of JSON info from the swapi.py4e database, then deserializes the JSON and creates/returns an associated C# object.

namespace StarWarsAPI
{
    public class JSONHelper
    {
        static readonly HttpClient client = new HttpClient();

        public static async Task<Planet> ListPlanetInfo(string ID)
        {
            Planet userPlanet = new Planet();
            try
            {
                HttpResponseMessage httpResponse = await client.GetAsync("https://swapi.py4e.com/api/planets/" + ID);
                httpResponse.EnsureSuccessStatusCode();
                string planetResponse = await httpResponse.Content.ReadAsStringAsync();

                userPlanet = JsonConvert.DeserializeObject<Planet>(planetResponse);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return userPlanet;
        }

        public static async Task<Person> ListPersonInfo(string ID)
        {
            Person userPerson = new Person();
            try
            {
                HttpResponseMessage httpResponse = await client.GetAsync("https://swapi.py4e.com/api/people/" + ID);
                httpResponse.EnsureSuccessStatusCode();
                string personResponse = await httpResponse.Content.ReadAsStringAsync();

                userPerson = JsonConvert.DeserializeObject<Person>(personResponse);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return userPerson;
        }

        public static async Task<Starship> ListStarshipInfo(string ID)
        {
            Starship userStarship = new Starship();
            try
            {
                HttpResponseMessage httpResponse = await client.GetAsync("https://swapi.py4e.com/api/starships/" + ID);
                httpResponse.EnsureSuccessStatusCode();
                string starshipResponse = await httpResponse.Content.ReadAsStringAsync();

                userStarship = JsonConvert.DeserializeObject<Starship>(starshipResponse);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return userStarship;
        }

        public static async Task<Species> ListSpeciesInfo(int ID)
        {
            Species userSpecies = new Species();
            try
            {
                HttpResponseMessage httpResponse = await client.GetAsync("https://swapi.py4e.com/api/species/" + ID.ToString());
                httpResponse.EnsureSuccessStatusCode();
                string speciesResponse = await httpResponse.Content.ReadAsStringAsync();

                userSpecies = JsonConvert.DeserializeObject<Species>(speciesResponse);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return userSpecies;
        }

        public static async Task<AllSpecies> ListAllSpeciesInfo()
        {
            AllSpecies allSpecies = new AllSpecies();
            try
            {
                HttpResponseMessage httpResponse = await client.GetAsync("https://swapi.py4e.com/api/species/");
                httpResponse.EnsureSuccessStatusCode();
                string allSpeciesResponse = await httpResponse.Content.ReadAsStringAsync();

                allSpecies = JsonConvert.DeserializeObject<AllSpecies>(allSpeciesResponse);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return allSpecies;
        }
    }
}
