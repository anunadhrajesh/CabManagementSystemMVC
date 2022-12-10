namespace CabManagementSystem.Models.ViewModels
{
    public class PaymentViewModel
    {

        [Required]
        [StringLength(15)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Email")]
        public string Email { get; set; }
        public string UserId { get; set; }

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

        public Location From { get; set; }



        [Required]
        [Display(Name = "Destination")]
        public Location To { get; set; }
        [Required]
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
