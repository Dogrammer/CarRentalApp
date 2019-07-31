using System.ComponentModel.DataAnnotations;

namespace CarRentalApp.Models
{
    public class CarCategory : BaseModel
    {
        
        [Required(ErrorMessage = "Ime kategorije vozila je obvezno polje"), StringLength(100, ErrorMessage = "Duljina naziva kategorije vozila ne može biti veća od 100 znakova!")]
        public string Name { get; set; }
    }
}