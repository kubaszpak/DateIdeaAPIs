using JakubSzpakLab6___DateIdeaAPIs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JakubSzpakLab6___DateIdeaAPIs.Services
{
    public interface ILocationService
    {
        /// <summary>
        /// Zwraca listę wszystkich ciekawych miejsc
        /// </summary>
        /// <returns></returns>
        List<Location> Get();

        /// <summary>
        /// Dodaje nowe miejsce i zwraca jego Id
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        int Post(Location location);

        /// <summary>
        /// Edycja wskazanego miejsca
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="location"></param>
        /// <returns></returns>
        bool Put(int Id, Location location);

        /// <summary>
        /// Usuwa dane miejsce
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        bool Delete(int Id);
    }
}
