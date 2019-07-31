using System;
using CarRentalApp.Models;

namespace CarRentalApp.Data.Services
{
    public interface IRentalService
    {
         bool CarAvailable(Rental rental);
         bool DateValid(DateTime? startDate, DateTime? endDate);

    }
}