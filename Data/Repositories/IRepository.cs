using System.Collections.Generic;
using System.Threading.Tasks;
using CarRentalApp.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalApp.Data
{
    public interface IRepository<T> where T : class
    {
         Task Add(T entity);
         Task<T> GetById(int id);
         Task<IEnumerable<T>> Get();
         void Remove(T entity);
         Task Save();
         void Update(T entity);
         Task Patch(JsonPatchDocument<T> entity, int id);

         //fetch data with eager loading

         Task<IEnumerable<Rental>> GetRentals();
         Task<Rental> GetRentalById(int id);
         Task<IEnumerable<Car>> GetCars();
         Task<Car> GetCarById(int id);
         Task<IEnumerable<Location>> GetLocations();
         Task<Location> GetLocationById(int id);


         






    }
}