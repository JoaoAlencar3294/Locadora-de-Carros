using ApiLocacaoCarro.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiLocacaoCarro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Route("v1")]
    public class BrandController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BrandController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("Brands")]
        public async Task<IActionResult> GetAllCarsAsync()
        {
            var brands = await _context.Brands.AsNoTracking().ToListAsync();

            return Ok(brands);
        }

        //[HttpGet]
        //[Route("Brands/{id}")]
        //public async Task<IActionResult> GetByIdAsync(int id)
        //{
        //    var brands = await _context
        //        .Brands
        //        .AsNoTracking()
        //        .FirstOrDefaultAsync(x => x.BrandId == id);


        //    //var movieDtos = _mapper.Map<List<MovieDTO>>(movie);
        //    //return movieDtos == null ? NotFound() : Ok(movieDtos);
        //}
    }
}
