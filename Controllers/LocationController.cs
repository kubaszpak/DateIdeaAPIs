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
    [Route("api/locations")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private ILocationService _locationService;

        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        /// <summary>
        /// Zwraca wszystkie miejsca
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces(typeof(List<Location>))]
        public IActionResult Get()
        {
            var locations = _locationService.Get();
            return Ok(locations);
        }

        /// <summary>
        /// Dodaje miejsce z ciała zapytania
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        [HttpPost]
        [Produces(typeof(int))]
        public IActionResult Post([FromBody]Location location)
        {
            int id = _locationService.Post(location);
            return Ok(id);
        }

        /// <summary>
        /// Edytuje istniejące miejsce o określonym id na miejsce z ciała
        /// </summary>
        /// <param name="id"></param>
        /// <param name="location"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}")]
        [Produces(typeof(string))]
        public IActionResult Put([FromRoute]int id, [FromBody]Location location)
        {
            if(id != location.Id)
            {
                return Conflict("Podane Id są różne, sprawdź zapytanie i spróbuj ponownie");
            }
            else
            {
                var isUpdateSuccessful = _locationService.Put(id, location);
                if (isUpdateSuccessful)
                {
                    return Ok("Sukses! Edytowano miejcse o Id: " + id);
                }
                else
                {
                    return NotFound("Nie znaleziono lokacji o podanym Id");
                }
            }
        }

        /// <summary>
        /// Usuwa istniejącą lokację o wskazanym id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id}")]
        [Produces(typeof(string))]
        public IActionResult Delete([FromRoute]int id)
        {
            var isDeletionSuccessful = _locationService.Delete(id);
            if (isDeletionSuccessful)
            {
                return Ok("Sukces! Usunięto miejsce o Id: " + id);
            }
            else
            {
                return NotFound("Nie znaleziono lokacji o podanym Id");
            }
        }
    }
}
