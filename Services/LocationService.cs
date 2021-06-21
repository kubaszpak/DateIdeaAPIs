using JakubSzpakLab6___DateIdeaAPIs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JakubSzpakLab6___DateIdeaAPIs.Services
{
    public class LocationService : ILocationService
    {
        /// <summary>
        /// Lista zawierająca wszystkie ciekawe lokacje
        /// </summary>
        private static List<Location> listOfLocations = new List<Location>()
        {
            new Location()
            {
                Id = 0,
                Name = "Szczytnicki Park",
                City = "Wrocław",
                Description = "Jeden z największych parków Wrocławia zajmujący powierzchnię około 100 hektarów. Położony jest na wschód od Starej Odry, na terenie dawnej wsi Szczytniki, włączonej w obręb miasta w 1868 roku. Park ma charakter krajobrazowy i duże walory kompozycyjne oraz dendrologiczne (około 400 gatunków drzew i krzewów).",
                Longitude = 51.1151427470253,
                Latitude = 17.080861279307708,
                GoogleMapsLink = "https://goo.gl/maps/wiAmnjraQEeQzfTS9"
            },
            new Location()
            {
                Id = 1,
                Name = "Łazienki Park",
                City = "Warszawa",
                Description = "Zespół pałacowo-ogrodowy w Warszawie założony w XVIII wieku przez Stanisława Augusta Poniatowskiego. Nazwa pochodzi od barokowego pawilonu Łaźni, wzniesionego w latach 80. XVII wieku przez Stanisława Herakliusza Lubomirskiego i przebudowanego przez Stanisława Augusta Poniatowskiego na pałac Na Wyspie. Oprócz budynków, pawilonów oraz wolnostojących rzeźb znajdują się tam cztery ogrody: Królewski, Romantyczny, Modernistyczny oraz Chiński. Od 1960 zespół jest siedzibą Muzeum Łazienki Królewskie.",
                Longitude = 52.215195893976386,
                Latitude = 21.034817424072372,
                GoogleMapsLink = "https://goo.gl/maps/iDc5wmzJXQCeDXvr9"
            },
            new Location()
            {
                Id = 2,
                Name = "Wyspa Słodowa",
                City = "Wrocław",
                Description ="Lubiane miejsce spotkań w sercu miasta z dobrą energią, przyjaznymi knajpkami, ładnymi widokami. Niewielka wysepka na Odrze w obrębie wrocławskiego Starego Miasta oraz Śródmiejskiego Węzła Wodnego – Górnego, w sąsiedztwie mniejszych nieco od niej Wyspy Bielarskiej i Wyspy Młyńskiej.",
                Longitude = 51.116177666846134,
                Latitude = 17.037552401833928,
                GoogleMapsLink = "https://goo.gl/maps/1rSK6a28Jm8aLXWN7"
            }
        };

        public List<Location> Get()
        {
            return listOfLocations;
        }

        public int Post(Location location)
        {
            int id = 0;
            if(listOfLocations.Count() != 0)
            {
                id = listOfLocations.Max(l => l.Id) + 1;
            }
            location.Id = id;
            listOfLocations.Add(location);

            return id;
        }

        public bool Put(int Id, Location location)
        {
            var locationToUpdate = listOfLocations.Where(l => l.Id.Equals(Id)).SingleOrDefault();
            if (locationToUpdate == null)
                return false;

            locationToUpdate.Name = location.Name;
            locationToUpdate.City = location.City;
            locationToUpdate.Description = location.Description;
            locationToUpdate.Longitude = location.Longitude;
            locationToUpdate.Latitude = location.Latitude;
            locationToUpdate.GoogleMapsLink = locationToUpdate.GoogleMapsLink;

            return true;
        }
        public bool Delete(int Id)
        {
            var locationToDelete = listOfLocations.Where(l => l.Id.Equals(Id)).SingleOrDefault();
            if (locationToDelete == null)
                return false;

            listOfLocations.Remove(locationToDelete);
            return true;
        }
    }
}
