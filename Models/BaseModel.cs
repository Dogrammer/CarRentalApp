using System;
using System.ComponentModel.DataAnnotations;
using CarRentalApp.Data;

namespace CarRentalApp.Models
{
    public class BaseModel : ISoftDeletable
    {

        //[Required(ErrorMessage="Id je obvezno polje.")]
        // [Range(1, int.MaxValue, ErrorMessage="Id mora biti pozitivan broj veći od 0")] -bad 
        public int Id { get; set; }


        //[Required(ErrorMessage="CreatedAt je obvezno polje.")]
        [DataType(DataType.DateTime,ErrorMessage="Krivi format datuma.")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [DataType(DataType.DateTime,ErrorMessage="Krivi format datuma.")]
        public DateTime? ModifiedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}