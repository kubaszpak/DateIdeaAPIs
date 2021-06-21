using JakubSzpakLab6___DateIdeaAPIs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JakubSzpakLab6___DateIdeaAPIs.Services
{
    public interface ICartoonService
    {
        /// <summary>
        /// Zwraca listę ciekawych bajek
        /// </summary>
        /// <returns></returns>
        List<Cartoon> Get();

        /// <summary>
        /// Dodaje nową bajkę i zwraca jej Id
        /// </summary>
        /// <param name="cartoon"></param>
        /// <returns></returns>
        int Post(Cartoon cartoon);

        /// <summary>
        /// Edytuje bajkę i zwraca boolean czy edycja się powiodła
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="cartoon"></param>
        /// <returns></returns>
        bool Put(int Id, Cartoon cartoon);

        /// <summary>
        /// Usuwa bajkę i zwraca boolean czy usunięcie się powiodło
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        bool Delete(int Id);
    }
}
