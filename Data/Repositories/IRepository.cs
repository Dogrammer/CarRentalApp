using System.Collections.Generic;
using System.Threading.Tasks;
using CarRentalApp.Models;
using Microsoft.AspNetCore.JsonPatch;

namespace CarRentalApp.Data
{
    public interface IRepository<T> where T : BaseModel
    {
         Task Add(T entity);
         Task<T> GetById(int id);
         Task<IEnumerable<T>> Get();
         void Remove(T entity);
         Task Save();
         void Update(T entity);
         Task Patch(JsonPatchDocument<T> entity, int id);
         
         





    }
}