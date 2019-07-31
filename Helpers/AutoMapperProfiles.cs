using AutoMapper;
using CarRentalApp.Dtos;
using CarRentalApp.Models;

namespace CarRentalApp.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            //<source,destionation>
            CreateMap<CustomerForListDto, Customer>();
            
        }
    }
}