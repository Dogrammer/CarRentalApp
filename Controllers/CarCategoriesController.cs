using System.Collections.Generic;
using System.Threading.Tasks;
using CarRentalApp.Data;
using CarRentalApp.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarRentalApp.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class CarCategoriesController : ControllerBase
    {
        private readonly IRepository<CarCategory> _repo;
        private readonly CarRentalContext _context;

        public CarCategoriesController(IRepository<CarCategory> repo, CarRentalContext context)
        {
            _context = context;
            _repo = repo;

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarCategory>>> GetCarCategories()
        {
            // var carCategories = await _context.CarCategories.ToListAsync();

            // return Ok(carCategories);
            var categories = await _repo.Get();

            if (categories == null)
                return NotFound();

            return Ok(categories);
        }

        [HttpGet("{id}")]
        public ActionResult<CarCategory> GetCarCategory(int id)
        {
            var category = _repo.GetById(id);

            if (category == null)
                return NotFound();

            return Ok(category);
        }


        [HttpPost]
        public async Task<ActionResult<CarCategory>> PostCarCategory([FromBody] CarCategory category)
        {
            await _repo.Add(category);
            await _repo.Save();

            return CreatedAtAction(nameof(GetCarCategory), new { id = category.Id }, category);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<CarCategory>> PutCarCategory(int id, [FromBody]CarCategory carCategory)
        {
            if (id != carCategory.Id)
                return BadRequest();

            _repo.Update(carCategory);
            await _repo.Save();

            return NoContent();
        }

        [HttpPatch("{id}")]
        public async Task<ActionResult<City>> PatchCarCategory([FromBody]JsonPatchDocument<CarCategory> carCategory, int id)
        {

            await _repo.Patch(carCategory, id);

            await _repo.Save();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarCategory(int id)
        {
            var category = await _repo.GetById(id);

            if (category == null)
                return NotFound();

            _repo.Remove(category);
            await _repo.Save();

            return NoContent();
        }




        // private readonly CarRentalContext _context;
        // public CarCategoriesController(CarRentalContext context)
        // {
        //     _context = context;
        // }

        // [HttpGet]
        // public async Task<ActionResult<IEnumerable<CarCategory>>> GetCarCategories()
        // {
        //     var categories = await _context.CarCategories.ToListAsync();

        //     if (categories == null)
        //         return NotFound();

        //     return Ok(categories);
        // }

        // [HttpGet("{id}")]
        // public async Task<ActionResult<CarCategory>> GetCarCategory(int id)
        // {
        //     var category = await _context.CarCategories.FindAsync(id);

        //     if (category == null)
        //         return NotFound();

        //     return Ok(category);
        // }


        // [HttpPost]
        // public async Task<ActionResult<CarCategory>> PostCarCategory([FromBody] CarCategory category)
        // {
        //     await _context.CarCategories.AddAsync(category);
        //     await _context.SaveChangesAsync();

        //     return CreatedAtAction(nameof(GetCarCategory), new { id = category.Id }, category);
        // }

        //   [HttpPut("{id}")]
        // public async Task<ActionResult<CarCategory>> PutCarCategory(int id, [FromBody]CarCategory carCategory)
        // {
        //     if ( id != carCategory.Id)
        //     {
        //         return BadRequest();
        //     }

        //     _context.Entry(carCategory).State = EntityState.Modified;
        //     await _context.SaveChangesAsync();

        //     return NoContent();
        // }

        // [HttpDelete("{id}")]
        // public async Task<IActionResult> DeleteCarCategory(int id)
        // {
        //     var category = await _context.CarCategories.FirstOrDefaultAsync(x => x.Id == id);

        //     if (category == null)
        //         return NotFound();

        //     _context.CarCategories.Remove(category);
        //     await _context.SaveChangesAsync();

        //     return NoContent();
        // }
    }
}