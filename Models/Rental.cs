using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace CarRentalApp.Models
{
    public class Rental : BaseModel
    {

        [Required(ErrorMessage="Polje 'pocetni datum' je obvezno polje.")]
        [DataType(DataType.DateTime, ErrorMessage="Datum je u pogrešnom formatu.")]
        public DateTime? StartDate { get; set; }
        
        [Required(ErrorMessage="Polje 'završni datum' je obvezno polje.")]
        [DataType(DataType.DateTime,ErrorMessage="Datum je u pogrešnom formatu.")]
        public DateTime? EndDate { get; set; }
        
        public string Remarks { get; set; }
        //[JsonIgnore]
        public Location PickUpLocation { get; set; }

        [Required(ErrorMessage="Polje 'polazna lokacija' je obvezno polje."),
         Range(1, int.MaxValue, ErrorMessage="Id stranog kljuca mora biti u itnervalu od 1 do maks")]
        public int PickUpLocationId { get; set; }
        //[JsonIgnore]
        public Location DropOffLocation { get; set; }

        [Required(ErrorMessage="Polje 'dolazna lokacija' je obvezno polje."),
         Range(1, int.MaxValue, ErrorMessage="Id stranog kljuca mora biti u itnervalu od 1 do maks")]
        public int DropOffLocationId { get; set; }

        //[JsonIgnore]        
        public Customer Customer { get; set; }
        
        
        [Required(ErrorMessage="Polje 'Kupac' je obvezno polje."),
         Range(1, int.MaxValue, ErrorMessage="Id stranog kljuca mora biti u itnervalu od 1 do maks")]
        public int CustomerId { get; set; }

        //[JsonIgnore]
        public Car Car { get; set; }
        
        [Required(ErrorMessage="Polje 'auto' je obvezno polje."), Range(1, int.MaxValue, ErrorMessage="Id stranog kljuca mora biti u itnervalu od 1 do maks")]
        public int CarId { get; set; }

        [Required(ErrorMessage="Polje 'rezervirano' je obvezno polje.")]
        [Display(Name = "Is Active")]
        [Range(typeof(bool), "false", "true", ErrorMessage="Polje 'rezervirano' je obvezno polje.")]
        public bool Reserved { get; set; }

        
        
    }
}