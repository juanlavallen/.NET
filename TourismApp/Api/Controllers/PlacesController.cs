using Core.Models;
using Infrastructure.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers {
    
    [ApiController]
    [Route("[controller]")]
    public class PlacesController : Controller {
        
        private readonly ContextDb _db;
     
        public PlacesController(ContextDb db) {
            this._db = db;
        }

        [HttpGet("getAll")]
        public async Task<ActionResult<List<Place>>> getAll() {
            var places = await _db.Places.ToListAsync();
            return Ok(places);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Place>> getById(int id) {
            return await _db.Places.FindAsync(id);
        }
    }
}