using System;

namespace CarRentalApp.Dtos
{
    public class CustomerForListDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        
    }
}