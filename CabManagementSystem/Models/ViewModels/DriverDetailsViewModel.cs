namespace CabManagementSystem.Models.ViewModels
{

    public class DriverDetailsViewModel
    {

        [Required]
        [Display(Name = "Registration Number")]
        public string RegistrationNo { get; set; }

        [Required]
        [Display(Name = "License Number")]
        public string LicenceNo { get; set; }

        public CarModels CarModel { get; set; }

        [Required]
        [Display(Name = "Cab Name")]
        public string CabName { get; set; }

        [Required]
        [Display(Name = "Pick Up")]
        public Location From { get; set; }



        [Required]
        [Display(Name = "Destination")]
        public Location To { get; set; }
        [Required]
        public DateTime Date { get; set; }


    }
}
