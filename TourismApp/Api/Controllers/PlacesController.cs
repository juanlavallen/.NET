using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class PlacesController : Controller {

        private readonly IPlaceRepository _placeRepository;
        
        public PlacesController(IPlaceRepository placeRepository) {
            this._placeRepository = placeRepository;
        }

        [HttpGet("getAll")]
        public async Task<ActionResult<List<Place>>> getAll() {
            var places = await _placeRepository.getAll();
            return Ok(places);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Place>> getById(int id) {
            return await _placeRepository.getById(id);
        }
    }
}