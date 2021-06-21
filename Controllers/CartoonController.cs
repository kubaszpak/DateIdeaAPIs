using JakubSzpakLab6___DateIdeaAPIs.Models;
using JakubSzpakLab6___DateIdeaAPIs.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JakubSzpakLab6___DateIdeaAPIs.Controllers
{
    [Route("api/cartoons")]
    [ApiController]
    public class CartoonController : ControllerBase
    {

        private ICartoonService _cartoonService;

        public CartoonController(ICartoonService cartoonService)
        {
            _cartoonService = cartoonService;
        }

        /// <summary>
        /// Zwraca wszystkie bajki
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces(typeof(List<Cartoon>))]
        public IActionResult Get()
        {
            var cartoons = _cartoonService.Get();
            return Ok(cartoons);
        }

        /// <summary>
        /// Dodaje bajki z ciała zapytania
        /// </summary>
        /// <param name="cartoon"></param>
        /// <returns></returns>
        [HttpPost]
        [Produces(typeof(int))]
        public IActionResult Post([FromBody] Cartoon cartoon)
        {
            int id = _cartoonService.Post(cartoon);
            return Ok(id);
        }

        /// <summary>
        /// Edytuje istniejącą bajkę o określonym id na miejsce z ciała
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cartoon"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}")]
        [Produces(typeof(string))]
        public IActionResult Put([FromRoute] int id, [FromBody] Cartoon cartoon)
        {
            if (id != cartoon.Id)
            {
                return Conflict("Podane Id są różne, sprawdź zapytanie i spróbuj ponownie");
            }
            else
            {
                var isUpdateSuccessful = _cartoonService.Put(id, cartoon);
                if (isUpdateSuccessful)
                {
                    return Ok("Sukses! Edytowano bajkę o Id: " + id);
                }
                else
                {
                    return NotFound("Nie znaleziono bajki o podanym Id");
                }
            }
        }

        /// <summary>
        /// Usuwa istniejącą bajkę o id wskazanym w adresie
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id}")]
        [Produces(typeof(string))]
        public IActionResult Delete([FromRoute] int id)
        {
            var isDeletionSuccessful = _cartoonService.Delete(id);
            if (isDeletionSuccessful)
            {
                return Ok("Sukces! Usunięto bajkę o Id: " + id);
            }
            else
            {
                return NotFound("Nie znaleziono bajki o podanym Id");
            }
        }
    }
}
