using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.JsonPatch;
using CarRentalApp.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalApp.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {

        private readonly CarRentalContext _context;
        public Repository(CarRentalContext context)
        {
            _context = context;
        }
        public async Task Add(T entity)
        {
           await _context.Set<T>().AddAsync(entity);
        }

        public async Task<IEnumerable<T>> Get()
        {
            var items = await _context.Set<T>().ToListAsync();

            return items;

        }

        public async Task<T> GetById(int id)
        {
            var getItem = await _context.Set<T>().FindAsync(id);

            return getItem;
        }

        public void Remove(T entity)
        {
            // var item = _context.Set<T>().Find(id);

              _context.Set<T>().Remove(entity);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            // _context.Set<T>().Attach(entity);
              _context.Entry(entity).State = EntityState.Modified;
        }

        public async Task Patch(JsonPatchDocument<T> entity, int id)
        {
            var element = entity as BaseModel;
            element.Id = id;

    //         blogs = db.Blogs
    // .Include(b => b.Posts)
    // .IgnoreQueryFilters()
    // .ToList();
            var data = await _context.Set<BaseModel>().Where(el => el.Id == id).IgnoreQueryFilters().FirstOrDefaultAsync();
            // var ignored = await _context.Set<T>().Include(a => ((ISoftDeletable)a).IsDeleted).IgnoreQueryFilters().ToListAsync();
            var itemToPatch = await _context.Set<T>().ToListAsync();
            // entity.ApplyTo(itemToPatch);
            
        }

        public async Task<IEnumerable<Rental>> GetRentals()
        {
            var rentals = await _context
                .Rentals
                .Include(c => c.Car).ThenInclude(c => c.CarCategory)
                .Include(c => c.Customer)
                .Include(p => p.PickUpLocation)
                .Include(d => d.DropOffLocation)
                .ToListAsync();

            return rentals;
        }
        

        public async Task<IEnumerable<Car>> GetCars()
        {
            var cars = await _context.Cars.Include(c => c.CarCategory).ToListAsync();

            return cars;
        }

        public async Task<Car> GetCarById(int id)
        {
            var car = await _context.Cars
                .Include(c => c.CarCategory)
                .FirstOrDefaultAsync(x => x.Id == id);
            
            return car;
        }

        public async Task<IEnumerable<Location>> GetLocations()
        {
            var locations = await _context.Locations.Include(c => c.City)
                                                    .ToListAsync();

            return locations;
        }

        public async Task<Location> GetLocationById(int id)
        {
            var location = await _context.Locations
                .Include(c => c.City)
                .FirstOrDefaultAsync(x => x.Id == id);
            
            return location;
        }

        public async Task<Rental> GetRentalById(int id)
        {
            var rental = await _context.Rentals
                .Include(l => l.PickUpLocation)
                .Include(d => d.DropOffLocation)
                .Include(c => c.Customer)
                .Include(r => r.Car)
                .FirstOrDefaultAsync(x => x.Id == id);
            
            return rental;
        }

        
       

        
    }
}