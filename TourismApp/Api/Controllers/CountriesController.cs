using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers {

    [ApiController]
    [Route("api/[controller]")]
    public class CountriesController : Controller {

        private readonly IRepository<Country> _countryRepository;

        public CountriesController(IRepository<Country> countryRepository) {
            this._countryRepository = countryRepository;
        }
    }
}