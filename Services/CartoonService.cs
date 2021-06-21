using JakubSzpakLab6___DateIdeaAPIs.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JakubSzpakLab6___DateIdeaAPIs.Services
{
    public class CartoonService : ICartoonService
    {
        /// <summary>
        /// Lista przechowująca wszystkie bajki
        /// </summary>
        private static List<Cartoon> listOfCartoons = new List<Cartoon>()
        {
            new Cartoon()
            {
                Id = 0,
                Name = "Fineasz i Ferb",
                IsAnimated = true,
                LinkToOpeningTheme = "https://www.youtube.com/watch?v=NkQrKxTFARM",
                NumberOfEpisodes = 129
            },
            new Cartoon()
            {
                Id = 1,
                Name = "Nie ma to jak hotel",
                IsAnimated = false,
                LinkToOpeningTheme = "https://www.youtube.com/watch?v=_9dYvfao6WY",
                NumberOfEpisodes = 87
            },
            new Cartoon()
            {
                Id = 2,
                Name = "Czarodzieje z Waverly Place",
                IsAnimated = false,
                LinkToOpeningTheme = "https://www.youtube.com/watch?v=lshzQJ1YAzU",
                NumberOfEpisodes = 106
            },
            new Cartoon()
            {
                Id = 3,
                Name = "Xiaolin Pojedynek Mistrzów",
                IsAnimated = true,
                LinkToOpeningTheme = "https://www.youtube.com/watch?v=IbFOfYKt6mY",
                NumberOfEpisodes = 52
            },
            new Cartoon()
            {
                Id = 4,
                Name = "Galactik Football",
                IsAnimated = true,
                LinkToOpeningTheme = "https://www.youtube.com/watch?v=9kSZ8Uihz0w",
                NumberOfEpisodes = 78
            },

        };

        public List<Cartoon> Get()
        {
            return listOfCartoons;
        }

        public int Post(Cartoon cartoon)
        {
            int id = 0;
            if (listOfCartoons.Count() != 0)
            {
                id = listOfCartoons.Max(c => c.Id) + 1;
            }
            cartoon.Id = id;
            listOfCartoons.Add(cartoon);

            return id;
        }

        public bool Put(int Id, Cartoon cartoon)
        {
            var cartoonToUpdate = listOfCartoons.Where(c => c.Id.Equals(Id)).SingleOrDefault();
            if (cartoonToUpdate == null)
                return false;

            cartoonToUpdate.Name = cartoon.Name;
            cartoonToUpdate.IsAnimated = cartoon.IsAnimated;
            cartoonToUpdate.LinkToOpeningTheme = cartoon.LinkToOpeningTheme;
            cartoonToUpdate.NumberOfEpisodes = cartoon.NumberOfEpisodes;

            return true;
        }

        public bool Delete(int Id)
        {
            var cartoonToDelete = listOfCartoons.Where(c => c.Id.Equals(Id)).SingleOrDefault();
            if (cartoonToDelete == null)
                return false;

            listOfCartoons.Remove(cartoonToDelete);
            return true;
        }
    }
}
