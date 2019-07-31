using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.JsonPatch;
using CarRentalApp.Models;
using System.Threading.Tasks;

namespace CarRentalApp.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseModel
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

        

        
    }
}