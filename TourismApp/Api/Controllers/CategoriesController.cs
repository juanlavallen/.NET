using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers {

    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : Controller {

        private readonly IRepository<Category> _categoryRepository;

        public CategoriesController(IRepository<Category> categoryRepository){
            this._categoryRepository = categoryRepository;
        }

        [HttpGet("getAll")]
        public async Task<ActionResult<List<Category>>> getAll() {
            var categories = await _categoryRepository.getAll();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> getById(int id) {
            var category = await _categoryRepository.getById(id);
            return Ok(category);
        }
    }
}