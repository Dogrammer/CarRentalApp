using System;
using System.ComponentModel.DataAnnotations;

namespace CarRentalApp.Models
{
    public class Customer : BaseModel
    {
        [Required(ErrorMessage="Polje 'ime' je obvezno polje."), StringLength(100, ErrorMessage = "Duljina naziva imena smije biti maksimalno 100 znakova")]
        public string FirstName { get; set; }
        [Required(ErrorMessage="Polje 'prezime' je obvezno polje"), StringLength(100, ErrorMessage = "Duljina naziva prezimena smije biti maksimalno 100 znakova")]
        public string LastName { get; set; }
        [Required(ErrorMessage="Polje 'Datum rođenja' je obvezno polje.")]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        [Required(ErrorMessage="Polje 'broj vozacke dozvole je obvezno polje.")]
        [StringLength(8, MinimumLength = 8, ErrorMessage ="Duljina broja vozačke dozvole mora iznositi 8 znakova")]
        public string  DrivingLicenceNumber{ get; set; }
    }
}